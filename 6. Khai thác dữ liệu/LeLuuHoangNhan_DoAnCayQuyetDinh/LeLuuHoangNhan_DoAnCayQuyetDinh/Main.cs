using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace DecisionTreeSimulation
{
    public partial class Main : Form
    {
        private DataTable dataTable;
        private Node decisionTree;
        private int levels = 0;
        public Main()
        {
            InitializeComponent();

            //Setup data table
            dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("ID", typeof(string)));
            dataGrid.DataSource = dataTable;
        }
        public bool loadSamples(string file)
        {
            try
            {
                StreamReader reader = new StreamReader(file);
                int numberOfClauses = int.Parse(reader.ReadLine());
                for (int i = 0; i < numberOfClauses; i++)
                {
                    dataTable.Columns.Add(reader.ReadLine(),typeof(string));
                }
                int numberOfSamples = int.Parse(reader.ReadLine());
                for (int i = 0; i < numberOfSamples; i++)
                {
                    List<string> answer = new List<string>();
                    dataTable.Rows.Add(reader.ReadLine().Split('_'));
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Nhập file bị lỗi!");
                return false;
            }
        }

        private void addClause_Button_Click(object sender, EventArgs e)
        {
            string clause = inputClause_TextBox.Text;
            if (dataTable.Columns.Contains(clause))
            {
                MessageBox.Show("Cột vừa tạo đã tồn tại");
                return;
            }
            dataTable.Columns.Add(clause,typeof(string));
        }

        private void removeClause_Button_Click(object sender, EventArgs e)
        {
            if(dataTable.Columns.Count>1)
            {
               
                int indexColumn = int.Parse(txt_xoaColumn.Text.ToString());
                if (indexColumn > (dataTable.Columns.Count - 1) || indexColumn < 0)
                {
                    MessageBox.Show("Vị trí cột cần xóa không hợp lệ");
                    return;
                }
                dataTable.Columns.RemoveAt(indexColumn - 1);
            }
        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            resetDataTable();
        }
        public void resetDataTable()
        {
            while (dataTable.Columns.Count > 1)
            {
                dataTable.Columns.RemoveAt(dataTable.Columns.Count - 1);
            }
            dataTable.Rows.Clear();
        }

        private void buildDecisionTree_Button_Click(object sender, EventArgs e)
        {
            List<Clause> clauses = createClauses();
            List<Sample> samples = createSamples();
            if (clauses.Count == 0 || samples.Count == 0)
            {
                MessageBox.Show("Lỗi tạo cây!");
                return;
            }
            Clause result = clauses[clauses.Count - 1];
            clauses.Remove(result);
            decisionTree = new Node(null, clauses, samples);
            levels = partition(decisionTree, result, 1) + 1;
            graph_Panel.Refresh();
            return;
        }
        private int partition(Node parent,Clause result,int level)
        {
            if (parent.samples.Count == 0 || parent.clauses.Count == 0 || checkPartition(parent.samples))
            {
                return level;
            }
            List<List<List<float>>> featureVectors = computeFeatureVectors(parent.clauses,parent.samples,result);
            int bestFeature = getBestFeature(featureVectors);
            parent.partition_clause = parent.clauses[bestFeature];
            List<Clause> brandClauses = new List<Clause>();
            for(int i = 0; i<parent.clauses.Count;i++)
            {
                if (i != bestFeature)
                {
                    brandClauses.Add(parent.clauses[i]);
                }
            }
            List<List<Sample>> brandsSamples = new List<List<Sample>>();

            for (int i = 0; i < parent.clauses[bestFeature].possibleAnswers.Count; i++)
            {
                List<Sample> brandSamples = new List<Sample>();
                foreach (Sample sample in parent.samples)
                {
                    if (sample.answers[bestFeature] == parent.clauses[bestFeature].possibleAnswers[i])
                    {
                        Sample temp = sample.copy();
                        temp.answers.RemoveAt(bestFeature);
                        brandSamples.Add(temp);
                    }
                }
                brandsSamples.Add(brandSamples);
            }
            parent.branch = new List<Node>();
            int maxlv = level;
            for (int i = 0; i < parent.clauses[bestFeature].possibleAnswers.Count; i++)
            {
                Node brand = new Node(null, brandClauses, brandsSamples[i]);
                if (featureVectors[bestFeature][i].Max() != 1)
                {
                    int lv = partition(brand, result,level+1);
                    if (lv > maxlv) maxlv = lv;
                }
                parent.branch.Add(brand);
            }
            return maxlv ;
        }
        
        private int getBestFeature(List<List<List<float>>> featureVectors)
        {
            List<int> unitVectorCount = new List<int>();
            foreach(List<List<float>> featureVector in featureVectors)
            {
                int count = 0;
                foreach(List<float> vector in featureVector)
                {
                    if (vector.Max() == 1) count++;
                }
                unitVectorCount.Add(count);
            }
            return unitVectorCount.IndexOf(unitVectorCount.Max());
        }
        private bool checkPartition(List<Sample> samples)
        {
            string first = samples[0].answers[samples[0].answers.Count - 1];
            foreach(Sample sample in samples)
            {
                if(sample.answers[sample.answers.Count-1]!=first)
                {
                    return false;
                }
            }
            return true;
        }
        private List<List<List<float>>> computeFeatureVectors(List<Clause> clauses,List<Sample> samples,Clause result)
        {
            List<List<List<float>>> featureVectors = new List<List<List<float>>>();
            for(int c=0;c<clauses.Count;c++)
            {
                List<List<float>> featureVector = new List<List<float>>();
                for(int i =0;i<clauses[c].possibleAnswers.Count;i++)
                {
                    List<float> vector = new List<float>();
                    for (int j = 0; j < result.possibleAnswers.Count; j++)
                    {
                        int count = 0;
                        int total = 0;
                        foreach (Sample sample in samples)
                        {
                            if (sample.answers[c]==clauses[c].possibleAnswers[i])
                            {
                                total++;
                                if (sample.answers[sample.answers.Count - 1] == result.possibleAnswers[j])
                                {
                                    count++;
                                }
                            }
                        }
                        vector.Add((float)count / total);
                    }
                    featureVector.Add(vector);
                }
                featureVectors.Add(featureVector);
            }
            return featureVectors;
        }
        private List<Clause> createClauses()
        {
            int clauses_count = dataTable.Columns.Count;
            List<Clause> clauses = new List<Clause>();
            for (int i = 1; i < clauses_count; i++)
            {
                string question = dataTable.Columns[i].ColumnName;
                List<string> possibleAnswers = new List<string>();
                foreach (DataRow r in dataTable.Rows)
                {
                    if (!possibleAnswers.Contains(r[i]))
                    {
                        possibleAnswers.Add(r[i].ToString());
                    }
                }
                clauses.Add(new Clause(question, possibleAnswers));
            }
            return clauses;
        }

        private List<Sample> createSamples()
        {
            List<Sample> samples = new List<Sample>();
            foreach (DataRow r in dataTable.Rows)
            {
                List<string> answers = new List<string>();
                
                for(int i=1;i<r.ItemArray.Length;i++)
                {
                    answers.Add(r.ItemArray[i].ToString());
                }
                samples.Add(new Sample(answers,r.ItemArray[0].ToString()));
            }
            return samples;
        }
        private void graph_Panel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            drawGraph(e.Graphics);
        }
        private void drawGraph(Graphics g)
        {
            if(decisionTree == null) return;
            int levelHeight = graph_Panel.Height / (levels+1);
            drawNode(g,decisionTree,1,levelHeight,0,graph_Panel.Width);
        }
        private Point drawNode(Graphics g, Node node, int level, int levelHeight, int begin, int end)
        {
            int area = (end - begin) / 3;
            int pos_x = begin + area;
            int pos_y = levelHeight * level;
            Font font = new Font("Arial", 9);
            if (node.partition_clause != null)
            {
                
                SizeF question_size = g.MeasureString(node.partition_clause.question, font);
                pos_x = (int)(pos_x + (area - (question_size.Width - question_size.Height)) / 2);
                g.DrawRectangle(new Pen(Color.Blue), pos_x , pos_y, question_size.Width, question_size.Height);
                g.DrawString(node.partition_clause.question, font, new SolidBrush(Color.Red), pos_x, pos_y);
            }
            else
            {
                string sampleNames = "";
                foreach(Sample sample in node.samples)
                {
                    sampleNames += sample.name+"("+sample.answers[sample.answers.Count-1]+")" + "\n";
                }
                g.DrawString(sampleNames,font,new SolidBrush(Color.Yellow), pos_x, pos_y);
                //g.DrawRectangle(new Pen(Color.Blue), pos_x , pos_y, 20, 20);
                
            }
            if (node.branch != null)
            {
                List<Node> drawBranch = new List<Node>();
                foreach (Node brand in node.branch)
                {
                    if (brand.samples.Count > 0)
                    {
                        drawBranch.Add(brand);
                    }
                }
                int branArea = (end - begin) / drawBranch.Count;
                for (int i = 0; i < drawBranch.Count; i++)
                {
                    Point des = drawNode(g, drawBranch[i], level + 1, levelHeight, begin+branArea*i, begin + branArea*(i+1));
                    g.DrawLine(new Pen(Color.Green), pos_x, pos_y, des.X, des.Y);
                    g.DrawString(node.partition_clause.possibleAnswers[i], font, new SolidBrush(Color.Red), (pos_x + des.X) / 2, (pos_y + des.Y) / 2);
                }
            }
            return new Point(pos_x, pos_y);
        }
        private void open_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if(d.ShowDialog()==DialogResult.OK)
            {
                loadSamples(d.FileName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_dongHo.Text = "Thời gian:  " + dt.ToString("hh:mm:ss");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            this.Hide();
            Main m = new Main();
            m.ShowDialog();
            this.Close();
            
        }

    }
}
