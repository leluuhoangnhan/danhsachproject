/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package view;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Vector;
import javax.swing.DefaultListModel;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author LeLuuHoangNhan
 */
public class QL_NguoiDung extends javax.swing.JFrame {
    private Connection conn;
    Vector td=new Vector();
    Vector nd=new Vector();
    /**
     * Creates new form QL_NguoiDung
     */
    public QL_NguoiDung() {
        initComponents();
        
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            conn=DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=DB_QLDA;"
                    + "username=sa;password=1321");
        }
        catch(Exception e)
        {
            e.printStackTrace();
        }
        
        
        td.add("Username");
        td.add("Password");
        td.add("Nhóm người dùng");
        table_danhSach_ND.setModel(new DefaultTableModel(nd,td));
        docdata();
        
        
        docDanhSachNhom();
        docDanhSachTable();
        
        
        //Các mục mặc định bị ẩn
        txt_quyenTT_Default.setEnabled(false);
        txt_userThucThi.setEnabled(false);
        btn_themNhom_CN.setEnabled(false);
        btn_kickNhom_CN.setEnabled(false);
        btn_phanQuyen_CN.setEnabled(false);
        combo_nhomCaNhan.setEnabled(false);
        btn_ok.setEnabled(false);
        
        txt_tenNhom.setEnabled(false);
        btn_taoNhom.setEnabled(false);
        btn_xoaNhom.setEnabled(false);
        btn_phanQuyen_Nhom.setEnabled(false);
        combo_nhomNguoiDung.setEnabled(false);
        btn_ok_Nhom.setEnabled(false);
        
        ls_danhSachTable.setEnabled(false);
        combo_quyen.setEnabled(false);
        btn_taoQuyen.setEnabled(false);
        btn_xoaQuyen.setEnabled(false);
                
        
        
    }
    
    
    public void docdata()
    {
        String sql="SELECT * FROM TAIKHOAN";
        try{
            PreparedStatement ps=conn.prepareStatement(sql);
            ResultSet rs=ps.executeQuery();
            while(rs.next())
            {
                String user=rs.getString(1);
                String pass=rs.getString(2);
                String loai=rs.getString(3);
                
                
                Vector r=new Vector();
                r.add(user);
                r.add(pass);
                if(loai.equals("QUANTRI") || loai.equals("KH"))
                {
                    if(loai.equals("QUANTRI"))
                        r.add("Quan_tri");
                    else
                        r.add("Thong_thuong");
                        
                }
                else
                {
                    r.add(loai);
                }
                
                
                nd.add(r);
                table_danhSach_ND.setModel(new DefaultTableModel(nd,td));
            }
            rs.close();
            ps.close();
        }
        catch(Exception e)
        {
            JOptionPane.showMessageDialog(this, "Doc du lieu loi!");
            e.printStackTrace();
        }
    }
    
    public void docDanhSachNhom()
    {
        String sql="SELECT DISTINCT * FROM DS_NHOM";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ResultSet rs=ps.executeQuery();
            DefaultListModel ds=new DefaultListModel();
            while(rs.next())
            {
                ds.addElement(rs.getString(1));
            }
            ls_loaiND_CaNhan.setModel(ds);
            rs.close();
            ps.close();
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Đọc danh sách nhóm default lỗi(1)!");
            ex.printStackTrace();
        }
    }
    
    
    public void docDanhSachTable()
    {
        String sql="SELECT DISTINCT * FROM DS_TABLE";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ResultSet rs=ps.executeQuery();
            DefaultListModel ds=new DefaultListModel();
            while(rs.next())
            {
                ds.addElement(rs.getString(1));
            }
            ls_danhSachTable.setModel(ds);
            rs.close();
            ps.close();
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Đọc danh sách bảng lỗi(1)!");
            ex.printStackTrace();
        }
    }
    
    public void docDanhSachNhom_Combo_CN()
    {
        combo_nhomCaNhan.removeAll();
        String sql="SELECT DISTINCT * FROM DS_NHOM";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ResultSet rs=ps.executeQuery();
            DefaultListModel ds=new DefaultListModel();
            while(rs.next())
            {
                combo_nhomCaNhan.addItem(rs.getString(1));
            }
            rs.close();
            ps.close();
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Đọc danh sách nhóm default lỗi(1)!");
            ex.printStackTrace();
        }
    }
    
    
    public void docDanhSachNhom_Combo()
    {
        combo_nhomNguoiDung.removeAll();
        String sql="SELECT DISTINCT * FROM DS_NHOM";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ResultSet rs=ps.executeQuery();
            DefaultListModel ds=new DefaultListModel();
            while(rs.next())
            {
                combo_nhomNguoiDung.addItem(rs.getString(1));
            }
            rs.close();
            ps.close();
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Đọc danh sách nhóm default lỗi(2)!");
            ex.printStackTrace();
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollBar1 = new javax.swing.JScrollBar();
        jLabel3 = new javax.swing.JLabel();
        jRadioButton1 = new javax.swing.JRadioButton();
        buttonGroup1 = new javax.swing.ButtonGroup();
        buttonGroup2 = new javax.swing.ButtonGroup();
        jScrollPane4 = new javax.swing.JScrollPane();
        jTextArea1 = new javax.swing.JTextArea();
        jLabel1 = new javax.swing.JLabel();
        jPanel1 = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        txt_user = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        txt_quyenTT_Default = new javax.swing.JTextField();
        jLabel8 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        ls_loaiND_CaNhan = new javax.swing.JList<>();
        btn_xoa_ND = new javax.swing.JButton();
        btn_taoMoi_ND = new javax.swing.JButton();
        txt_pass = new javax.swing.JPasswordField();
        jPanel2 = new javax.swing.JPanel();
        jLabel10 = new javax.swing.JLabel();
        jLabel11 = new javax.swing.JLabel();
        jScrollPane3 = new javax.swing.JScrollPane();
        ls_danhSachTable = new javax.swing.JList<>();
        btn_taoQuyen = new javax.swing.JButton();
        btn_xoaQuyen = new javax.swing.JButton();
        jPanel3 = new javax.swing.JPanel();
        jLabel12 = new javax.swing.JLabel();
        radio_caNhan = new javax.swing.JRadioButton();
        radio_nhom_ND = new javax.swing.JRadioButton();
        jPanel4 = new javax.swing.JPanel();
        jLabel9 = new javax.swing.JLabel();
        txt_userThucThi = new javax.swing.JTextField();
        btn_themNhom_CN = new javax.swing.JButton();
        btn_phanQuyen_CN = new javax.swing.JButton();
        jPanel6 = new javax.swing.JPanel();
        jLabel15 = new javax.swing.JLabel();
        combo_nhomCaNhan = new javax.swing.JComboBox<>();
        btn_ok = new javax.swing.JButton();
        btn_kickNhom_CN = new javax.swing.JButton();
        jPanel5 = new javax.swing.JPanel();
        combo_nhomNguoiDung = new javax.swing.JComboBox<>();
        jLabel13 = new javax.swing.JLabel();
        jLabel14 = new javax.swing.JLabel();
        txt_tenNhom = new javax.swing.JTextField();
        btn_taoNhom = new javax.swing.JButton();
        btn_xoaNhom = new javax.swing.JButton();
        btn_ok_Nhom = new javax.swing.JButton();
        btn_phanQuyen_Nhom = new javax.swing.JButton();
        combo_quyen = new javax.swing.JComboBox<>();
        jScrollPane1 = new javax.swing.JScrollPane();
        table_danhSach_ND = new javax.swing.JTable();
        btn_lamMoi = new javax.swing.JButton();
        btn_dong = new javax.swing.JButton();
        jLabel16 = new javax.swing.JLabel();
        btn_saoLuu = new javax.swing.JButton();
        btn_khoiPhuc = new javax.swing.JButton();
        Quaylai = new javax.swing.JButton();

        jLabel3.setText("jLabel3");

        jRadioButton1.setText("jRadioButton1");

        jTextArea1.setColumns(20);
        jTextArea1.setRows(5);
        jScrollPane4.setViewportView(jTextArea1);

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setBackground(new java.awt.Color(0, 153, 102));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(255, 0, 0));
        jLabel1.setText("QUẢN LÝ NGƯỜI DÙNG");

        jPanel1.setBorder(javax.swing.BorderFactory.createTitledBorder("Thông tin người dùng"));

        jLabel2.setText("Username:");

        jLabel5.setText("Password:");

        jLabel6.setText("Nhóm người dùng: ");

        txt_quyenTT_Default.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txt_quyenTT_DefaultActionPerformed(evt);
            }
        });

        jLabel8.setText("Quyền thực thi (default):");

        jScrollPane2.setViewportView(ls_loaiND_CaNhan);

        btn_xoa_ND.setBackground(new java.awt.Color(255, 102, 102));
        btn_xoa_ND.setText("Xóa");
        btn_xoa_ND.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_xoa_NDActionPerformed(evt);
            }
        });

        btn_taoMoi_ND.setBackground(new java.awt.Color(204, 255, 102));
        btn_taoMoi_ND.setText("Tạo mới");
        btn_taoMoi_ND.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_taoMoi_NDActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addComponent(jLabel2)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(txt_user, javax.swing.GroupLayout.PREFERRED_SIZE, 160, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel6)
                            .addComponent(jLabel8)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGap(74, 74, 74)
                                .addComponent(btn_taoMoi_ND))
                            .addComponent(jLabel5))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 9, Short.MAX_VALUE)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(txt_quyenTT_Default, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jScrollPane2, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, 160, Short.MAX_VALUE)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGap(26, 26, 26)
                                .addComponent(btn_xoa_ND, javax.swing.GroupLayout.PREFERRED_SIZE, 72, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addComponent(txt_pass))))
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel2)
                    .addComponent(txt_user, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel5)
                    .addComponent(txt_pass, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel6)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 69, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_quyenTT_Default, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel8))
                .addGap(24, 24, 24)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btn_xoa_ND)
                    .addComponent(btn_taoMoi_ND))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        jPanel2.setBorder(javax.swing.BorderFactory.createTitledBorder("Quyền thực thi"));

        jLabel10.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel10.setForeground(new java.awt.Color(0, 0, 255));
        jLabel10.setText("Các quyền được thiết lập mặc định:");

        jLabel11.setText("Chọn bảng");

        ls_danhSachTable.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                ls_danhSachTableMousePressed(evt);
            }
        });
        jScrollPane3.setViewportView(ls_danhSachTable);

        btn_taoQuyen.setBackground(new java.awt.Color(204, 255, 102));
        btn_taoQuyen.setText("Tạo");
        btn_taoQuyen.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_taoQuyenActionPerformed(evt);
            }
        });

        btn_xoaQuyen.setBackground(new java.awt.Color(255, 51, 51));
        btn_xoaQuyen.setText("Xóa");
        btn_xoaQuyen.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_xoaQuyenActionPerformed(evt);
            }
        });

        jLabel12.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel12.setForeground(new java.awt.Color(0, 0, 255));
        jLabel12.setText("Thiết lập");

        buttonGroup1.add(radio_caNhan);
        radio_caNhan.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        radio_caNhan.setText("Cá nhân");
        radio_caNhan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                radio_caNhanActionPerformed(evt);
            }
        });

        buttonGroup1.add(radio_nhom_ND);
        radio_nhom_ND.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        radio_nhom_ND.setText("Nhóm người dùng");
        radio_nhom_ND.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                radio_nhom_NDActionPerformed(evt);
            }
        });

        jLabel9.setText("Username:");

        btn_themNhom_CN.setBackground(new java.awt.Color(204, 255, 102));
        btn_themNhom_CN.setText("Add nhóm");
        btn_themNhom_CN.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_themNhom_CNActionPerformed(evt);
            }
        });

        btn_phanQuyen_CN.setBackground(new java.awt.Color(255, 255, 102));
        btn_phanQuyen_CN.setText("Phân quyền");
        btn_phanQuyen_CN.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_phanQuyen_CNActionPerformed(evt);
            }
        });

        jLabel15.setText("Danh sách nhóm");

        btn_ok.setBackground(new java.awt.Color(0, 255, 255));
        btn_ok.setText("OK");
        btn_ok.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_okActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel6Layout = new javax.swing.GroupLayout(jPanel6);
        jPanel6.setLayout(jPanel6Layout);
        jPanel6Layout.setHorizontalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel6Layout.createSequentialGroup()
                .addContainerGap(82, Short.MAX_VALUE)
                .addComponent(btn_ok)
                .addGap(58, 58, 58))
            .addGroup(jPanel6Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel15)
                .addGap(0, 0, Short.MAX_VALUE))
            .addGroup(jPanel6Layout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(combo_nhomCaNhan, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        jPanel6Layout.setVerticalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel6Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel15)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(combo_nhomCaNhan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(btn_ok, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        btn_kickNhom_CN.setBackground(new java.awt.Color(255, 102, 102));
        btn_kickNhom_CN.setText("Kick nhóm");
        btn_kickNhom_CN.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_kickNhom_CNActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(jPanel6, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel4Layout.createSequentialGroup()
                        .addContainerGap()
                        .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                                .addComponent(jLabel9)
                                .addGap(12, 12, 12)
                                .addComponent(txt_userThucThi, javax.swing.GroupLayout.PREFERRED_SIZE, 114, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(jPanel4Layout.createSequentialGroup()
                                .addGap(8, 8, 8)
                                .addComponent(btn_themNhom_CN)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(btn_kickNhom_CN))))
                    .addGroup(jPanel4Layout.createSequentialGroup()
                        .addGap(63, 63, 63)
                        .addComponent(btn_phanQuyen_CN)))
                .addContainerGap())
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addGap(16, 16, 16)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel9)
                    .addComponent(txt_userThucThi, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btn_themNhom_CN)
                    .addComponent(btn_kickNhom_CN))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(btn_phanQuyen_CN)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel6, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        jLabel13.setText("Danh sách nhóm");

        jLabel14.setText("Tên nhóm:");

        btn_taoNhom.setBackground(new java.awt.Color(204, 255, 102));
        btn_taoNhom.setText("Tạo mới");
        btn_taoNhom.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_taoNhomActionPerformed(evt);
            }
        });

        btn_xoaNhom.setBackground(new java.awt.Color(255, 51, 51));
        btn_xoaNhom.setText("Xóa");
        btn_xoaNhom.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_xoaNhomActionPerformed(evt);
            }
        });

        btn_ok_Nhom.setBackground(new java.awt.Color(255, 102, 255));
        btn_ok_Nhom.setText("OK");
        btn_ok_Nhom.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_ok_NhomActionPerformed(evt);
            }
        });

        btn_phanQuyen_Nhom.setBackground(new java.awt.Color(255, 255, 102));
        btn_phanQuyen_Nhom.setText("Phân quyền");
        btn_phanQuyen_Nhom.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_phanQuyen_NhomActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel5Layout = new javax.swing.GroupLayout(jPanel5);
        jPanel5.setLayout(jPanel5Layout);
        jPanel5Layout.setHorizontalGroup(
            jPanel5Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel5Layout.createSequentialGroup()
                .addGap(0, 0, Short.MAX_VALUE)
                .addComponent(btn_ok_Nhom)
                .addGap(62, 62, 62))
            .addGroup(jPanel5Layout.createSequentialGroup()
                .addGroup(jPanel5Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel5Layout.createSequentialGroup()
                        .addGap(40, 40, 40)
                        .addComponent(combo_nhomNguoiDung, javax.swing.GroupLayout.PREFERRED_SIZE, 133, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel5Layout.createSequentialGroup()
                        .addGap(73, 73, 73)
                        .addComponent(jLabel14))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel5Layout.createSequentialGroup()
                        .addGap(20, 20, 20)
                        .addGroup(jPanel5Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel13)
                            .addGroup(jPanel5Layout.createSequentialGroup()
                                .addComponent(btn_taoNhom, javax.swing.GroupLayout.PREFERRED_SIZE, 69, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)
                                .addComponent(btn_xoaNhom, javax.swing.GroupLayout.PREFERRED_SIZE, 66, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel5Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(jPanel5Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel5Layout.createSequentialGroup()
                        .addComponent(btn_phanQuyen_Nhom)
                        .addGap(51, 51, 51))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel5Layout.createSequentialGroup()
                        .addComponent(txt_tenNhom, javax.swing.GroupLayout.PREFERRED_SIZE, 173, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap())))
        );
        jPanel5Layout.setVerticalGroup(
            jPanel5Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel5Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel14)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(txt_tenNhom, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel5Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btn_taoNhom)
                    .addComponent(btn_xoaNhom))
                .addGap(22, 22, 22)
                .addComponent(btn_phanQuyen_Nhom)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jLabel13)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(combo_nhomNguoiDung, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(btn_ok_Nhom, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );

        javax.swing.GroupLayout jPanel3Layout = new javax.swing.GroupLayout(jPanel3);
        jPanel3.setLayout(jPanel3Layout);
        jPanel3Layout.setHorizontalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGap(71, 71, 71)
                .addComponent(radio_caNhan)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(radio_nhom_ND)
                .addGap(57, 57, 57))
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanel4, javax.swing.GroupLayout.PREFERRED_SIZE, 199, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 16, Short.MAX_VALUE)
                .addComponent(jPanel5, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel3Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jLabel12)
                .addGap(186, 186, 186))
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel12)
                .addGap(18, 18, 18)
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(radio_caNhan, javax.swing.GroupLayout.PREFERRED_SIZE, 23, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(radio_nhom_ND))
                .addGap(7, 7, 7)
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jPanel5, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jPanel4, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addGap(12, 12, 12))
        );

        combo_quyen.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "SELECT", "INSERT", "DELETE", "UPDATE", "ALL" }));
        combo_quyen.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                combo_quyenMousePressed(evt);
            }
        });

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(btn_taoQuyen, javax.swing.GroupLayout.PREFERRED_SIZE, 84, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(30, 30, 30)
                .addComponent(btn_xoaQuyen, javax.swing.GroupLayout.PREFERRED_SIZE, 76, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(133, 133, 133))
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(135, 135, 135)
                        .addComponent(jLabel10))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(20, 20, 20)
                        .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 175, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(41, 41, 41)
                        .addComponent(combo_quyen, javax.swing.GroupLayout.PREFERRED_SIZE, 143, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(71, 71, 71)
                        .addComponent(jLabel11)))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addComponent(jPanel3, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jLabel10)
                .addGap(15, 15, 15)
                .addComponent(jLabel11)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 65, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(19, 19, 19))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(combo_quyen, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(38, 38, 38)))
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btn_taoQuyen)
                    .addComponent(btn_xoaQuyen))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        table_danhSach_ND.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        table_danhSach_ND.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                table_danhSach_NDMousePressed(evt);
            }
        });
        jScrollPane1.setViewportView(table_danhSach_ND);

        btn_lamMoi.setBackground(new java.awt.Color(0, 0, 0));
        btn_lamMoi.setForeground(new java.awt.Color(255, 255, 255));
        btn_lamMoi.setText("Làm mới");
        btn_lamMoi.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_lamMoiActionPerformed(evt);
            }
        });

        btn_dong.setBackground(new java.awt.Color(0, 0, 0));
        btn_dong.setForeground(new java.awt.Color(255, 255, 255));
        btn_dong.setText("Đóng");
        btn_dong.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_dongActionPerformed(evt);
            }
        });

        jLabel16.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel16.setForeground(new java.awt.Color(255, 153, 0));
        jLabel16.setText("Danh sách người dùng:");

        btn_saoLuu.setBackground(new java.awt.Color(0, 0, 0));
        btn_saoLuu.setForeground(new java.awt.Color(255, 255, 255));
        btn_saoLuu.setText("Sao lưu");
        btn_saoLuu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_saoLuuActionPerformed(evt);
            }
        });

        btn_khoiPhuc.setBackground(new java.awt.Color(0, 0, 0));
        btn_khoiPhuc.setForeground(new java.awt.Color(255, 255, 255));
        btn_khoiPhuc.setText("Khôi phục");
        btn_khoiPhuc.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_khoiPhucActionPerformed(evt);
            }
        });

        Quaylai.setBackground(new java.awt.Color(0, 0, 0));
        Quaylai.setForeground(new java.awt.Color(255, 255, 255));
        Quaylai.setText("Quay Lại");
        Quaylai.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                QuaylaiActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(btn_lamMoi, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(btn_saoLuu, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(48, 48, 48))
                    .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(83, 83, 83)
                        .addComponent(jLabel16)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 28, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(btn_khoiPhuc, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(71, 71, 71)
                        .addComponent(Quaylai, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(54, 54, 54)
                        .addComponent(btn_dong, javax.swing.GroupLayout.PREFERRED_SIZE, 99, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap())
            .addGroup(layout.createSequentialGroup()
                .addGap(263, 263, 263)
                .addComponent(jLabel1)
                .addGap(0, 0, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addGap(19, 19, 19)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(jLabel16)
                        .addGap(18, 18, 18)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 204, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(btn_dong)
                        .addComponent(Quaylai))
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(btn_lamMoi)
                        .addComponent(btn_saoLuu))
                    .addComponent(btn_khoiPhuc))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btn_phanQuyen_CNActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_phanQuyen_CNActionPerformed
        ls_danhSachTable.setEnabled(true);
    }//GEN-LAST:event_btn_phanQuyen_CNActionPerformed

    public int taoLogin(String user,String pass)
    {
        if(user.equals("") || pass.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Lỗi tạo login do thiếu user || pass!");
            return 0;
        }
        else
        {
            String sql="sp_addlogin ?, ?";
            try
            {
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1, user);
                ps.setString(2, pass);
                ps.execute();
                ps.close();
                
                return 1;
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, "Lỗi tạo login (1)!");
                ex.printStackTrace();
                return 0;
            }
        }
    }
    
    
    public int taoUser(String user,String tenNguoiDung)
    {
        if(user.equals("") || tenNguoiDung.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Lỗi tạo user do thiếu user || tenNguoiDung!");
            return 0;
        }
        else
        {
            String sql="sp_adduser ?, ?";
            try
            {
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1, user);
                ps.setString(2, tenNguoiDung);
                ps.execute();
                ps.close();
                
                return 1;
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, "Lỗi tạo User (1)!");
                ex.printStackTrace();
                return 0;
            }
        }
    }
    
    public int taoNhom(String tenNhom)
    {
        if(tenNhom.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Lỗi tạo nhóm quyền do thiếu tên nhóm!");
            return 0;
        }
        else
        {
            String sql="sp_addrole ?";
            try
            {
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1, tenNhom);
                ps.execute();
                ps.close();
                
                String sql1="INSERT INTO DS_NHOM VALUES(?)";
                try
                {
                    PreparedStatement ps1=conn.prepareStatement(sql1);
                    ps1.setString(1, tenNhom);
                    ps1.executeUpdate();
                    ps1.close();
                    
                    return 1;
                }
                catch(Exception ex)
                {
                    JOptionPane.showMessageDialog(this, "Lỗi tạo nhóm quyền(2)!");
                    ex.printStackTrace();
                    return 0;
                }
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, "Lỗi tạo nhóm quyền(1)!");
                ex.printStackTrace();
                return 0;
            }
        }
    }
    
    
    public int themThanhVienNhom(String tenNhom, String thanhVien)
    {
        if(tenNhom.equals("") || thanhVien.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Lỗi thêm thành viên vào nhóm =>> Tên nhóm || tên người dùng rỗng!");
            return 0;
        }
        else
        {
            String sql="sp_addrolemember ?, ?";
            try
            {
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1, tenNhom);
                ps.setString(2, thanhVien);
                ps.execute();
                ps.close();
                
                String sql1="SELECT DISTINCT PASS FROM TAIKHOAN WHERE TEN=?";
                try
                {
                    PreparedStatement ps1=conn.prepareStatement(sql1);
                    ps1.setString(1, thanhVien);
                    ResultSet rs=ps1.executeQuery();
                    String pass="";
                    while(rs.next())
                    {
                        pass=rs.getString(1);
                    }    
                    rs.close();
                    ps1.close();
                    
                    String sql3="SELECT * FROM TAIKHOAN WHERE TEN=? AND PASS=? AND LOAI=?";
                    try
                    {
                        PreparedStatement ps3=conn.prepareStatement(sql3);
                        ps3.setString(1, thanhVien);
                        ps3.setString(2, pass);
                        ps3.setString(3, tenNhom);
                        ResultSet rs1=ps3.executeQuery();
                        int kt3=0;
                        while(rs1.next())
                        {
                            kt3++;
                        }    
                        rs1.close();
                        ps3.close();
                        if(kt3!=0)
                        {
                            JOptionPane.showMessageDialog(this, "Thành viên đã tồn tại trong nhóm!");
                            return 1;
                        }
                        else
                        {
                            int them=themNguoiDung_TableTaiKhoan(thanhVien,pass,tenNhom);
                            if(them!=0)
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        JOptionPane.showMessageDialog(this, "Lỗi thêm thành viên vào nhóm(3)!");
                        ex.printStackTrace();
                        return 0;
                    }

                }
                catch(Exception ex)
                {
                    JOptionPane.showMessageDialog(this, "Lỗi thêm thành viên vào nhóm(2)!");
                    ex.printStackTrace();
                    return 0;
                }
                
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, "Lỗi thêm thành viên vào nhóm(1)!");
                ex.printStackTrace();
                return 0;
            }
        }
    }
    
    public int xoaThanhVienNhom(String tenNhom, String thanhVien)
    {
        if(tenNhom.equals("") || thanhVien.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Lỗi xóa thành viên nhóm =>> Tên nhóm || tên người dùng rỗng!");
            return 0;
        }
        else
        {
            String sql="sp_droprolemember ?, ?";
            try
            {
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1, tenNhom);
                ps.setString(2, thanhVien);
                ps.execute();
                ps.close();
                
                String sql1="DELETE FROM TAIKHOAN WHERE TEN=? AND LOAI=?";
                try
                {
                    PreparedStatement ps1=conn.prepareStatement(sql1);
                    ps1.setString(1, thanhVien);
                    ps1.setString(2, tenNhom);
                    ps1.executeUpdate();
                    ps1.close();
                    
                    lamMoi();
                    return 1;
                }
                catch(Exception ex)
                {
                    JOptionPane.showMessageDialog(this, "Lỗi xóa thành viên nhóm(2)!");
                    ex.printStackTrace();
                    return 0;
                }
                
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, "Lỗi xóa thành viên nhóm(1)!");
                ex.printStackTrace();
                return 0;
            }
        }
    }
    
    
    public int xoaNhom(String tenNhom)
    {
        if(tenNhom.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Lỗi xóa nhóm quyền do thiếu tên nhóm!");
            return 0;
        }
        else
        {
            String sql="sp_droprole ?";
            try
            {
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1, tenNhom);
                ps.execute();
                ps.close();
                
                String sql1="DELETE FROM DS_NHOM WHERE TENNHOM=?";
                try
                {
                    PreparedStatement ps1=conn.prepareStatement(sql1);
                    ps1.setString(1, tenNhom);
                    ps1.executeUpdate();
                    ps1.close();
                    
                    return 1;
                }
                catch(Exception ex)
                {
                    JOptionPane.showMessageDialog(this, "Lỗi xóa nhóm quyền(2)!");
                    ex.printStackTrace();
                    return 0;
                }
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, "Lỗi xóa nhóm quyền(1)!");
                ex.printStackTrace();
                return 0;
            }
        }
    }
    
    
    public int xoaUser(String user)
    {
        if(user.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Lỗi xóa user do thiếu tên người dùng!");
            return 0;
        }
        else
        {
            String sql="sp_dropuser ?";
            try
            {
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1, user);
                ps.execute();
                ps.close();
                
                return 1;
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, "Lỗi xóa User (1)!");
                ex.printStackTrace();
                return 0;
            }
        }
    }
    
    
    public int xoaLogin(String user)
    {
        if(user.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Lỗi xóa login do thiếu tên đăng nhập!");
            return 0;
        }
        else
        {
            String sql="sp_droplogin ?";
            try
            {
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1, user);
                ps.execute();
                ps.close();
                
                return 1;
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, "Lỗi xóa login (1)!");
                ex.printStackTrace();
                return 0;
            }
        }
    }
    
    
    public void lamMoi()
    {
        this.setVisible(false);
        QL_NguoiDung nd=new QL_NguoiDung();
        nd.setVisible(true);
    }
    
    
    public int themNguoiDung_TableTaiKhoan(String user, String pass, String nhom)
    {
        String sql="INSERT INTO TAIKHOAN VALUES(?,?,?)";   
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.setString(1, user);
            ps.setString(2, pass);
            ps.setString(3, nhom);  
            ps.executeUpdate();
            ps.close();
            
            lamMoi();
            return 1;
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Lỗi thêm người dùng mới vào bảng tài khoản (1)!");
            ex.printStackTrace();
            return 0;
        }
    }
    
    
    public String layPass_TableTaiKhoan(String user)
    {
        String pass="";
        String sql="SELECT PASS FROM TAIKHOAN WHERE TEN=?";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.setString(1, user);
            ResultSet rs=ps.executeQuery();
            while(rs.next())
            {
                pass=rs.getString(1);
            }
            rs.close();
            ps.close();
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Lỗi lấy password trong bảng tài khoản (1)!");
            ex.printStackTrace();
        }
        return pass;
    }
    
    
    private void btn_taoMoi_NDActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_taoMoi_NDActionPerformed
        String user=txt_user.getText().toString();
        String pass=txt_pass.getText().toString();
        String nhom=ls_loaiND_CaNhan.getSelectedValue().toString();
        
        if(user.equals("") || pass.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Không được bỏ trống username và password khi tạo mới!");
        }
        else
        {
            int kt=kiemTaiKhoan_TonTai(user,nhom);
            if(kt!=0)
            {
                JOptionPane.showMessageDialog(this, "Username này đã tồn tại trong hệ thống!");
            }
            else
            {
                int kt_user=kiemTraUser_TonTai(user);
                if(kt_user==0)
                {
                    int login=taoLogin(user,pass);
                    if(login==1)
                    {
                        int i_user=taoUser(user,user);
                        if(i_user==1)
                        {
                            String sql="INSERT INTO TAIKHOAN VALUES(?,?,?)";   
                            try
                            {
                                PreparedStatement ps=conn.prepareStatement(sql);
                                ps.setString(1, user);
                                ps.setString(2, pass);
                                ps.setString(3, nhom);  
                                ps.executeUpdate();
                                ps.close();

                                this.setVisible(false);
                                QL_NguoiDung nd=new QL_NguoiDung();
                                nd.setVisible(true);
                                JOptionPane.showMessageDialog(this, "Thêm người dùng mới thành công!");


                                //Gắn vào nhóm quyền
                                int addNhom=themThanhVienNhom(nhom,user);
                                if(addNhom==1)
                                {
                                    JOptionPane.showMessageDialog(this, "Gán thành viên mới vào nhóm thành công!");
                                }
                                else
                                {
                                    JOptionPane.showMessageDialog(this, "Gán thành viên mới vào nhóm thất bại!");
                                }

                            }
                            catch(Exception ex)
                            {
                                JOptionPane.showMessageDialog(this, "Lỗi tạo người dùng mới(1)!");
                                ex.printStackTrace();
                            }

                        }
                    }
                }
                else
                {
                    String sql="INSERT INTO TAIKHOAN VALUES(?,?,?)";   
                    try
                    {
                        PreparedStatement ps=conn.prepareStatement(sql);
                        ps.setString(1, user);
                        ps.setString(2, pass);
                        ps.setString(3, nhom);  
                        ps.executeUpdate();
                        ps.close();

                        this.setVisible(false);
                        QL_NguoiDung nd=new QL_NguoiDung();
                        nd.setVisible(true);
                        JOptionPane.showMessageDialog(this, "Thêm người dùng mới thành công!");


                        //Gắn vào nhóm quyền
                        int addNhom=themThanhVienNhom(nhom,user);
                        if(addNhom==1)
                        {
                            JOptionPane.showMessageDialog(this, "Gán thành viên mới vào nhóm thành công!");
                        }
                        else
                        {
                            JOptionPane.showMessageDialog(this, "Gán thành viên mới vào nhóm thất bại!");
                        }

                    }
                    catch(Exception ex)
                    {
                        JOptionPane.showMessageDialog(this, "Lỗi tạo người dùng mới(1)!");
                        ex.printStackTrace();
                    }
                }
            }
        }
    }//GEN-LAST:event_btn_taoMoi_NDActionPerformed

    private void btn_xoa_NDActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_xoa_NDActionPerformed
        String user=txt_user.getText().toString();
        if(user.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Không được bỏ trống username!");
        }
        else
        {
            int kt_user=kiemTraUser_TonTai(user);
            if(kt_user!=0)
            {
                String sql="DELETE FROM TAIKHOAN WHERE TEN=?";
                try
                {
                    PreparedStatement ps=conn.prepareStatement(sql);
                    ps.setString(1, user);
                    ps.executeUpdate();
                    ps.close();
                    
                    this.setVisible(false);
                    QL_NguoiDung nd=new QL_NguoiDung();
                    nd.setVisible(true);
                    JOptionPane.showMessageDialog(this, "Xóa người dùng thành công!");
                    

                    int xoaUser=xoaUser(user);
                    if(xoaUser==1)
                    {
                        JOptionPane.showMessageDialog(this, "Xóa user người dùng thành công!");
                    }
                    else
                    {
                        JOptionPane.showMessageDialog(this, "Xóa user người dùng thất bại!");
                    }

                    int xoaLogin=xoaLogin(user);
                    if(xoaLogin==1)
                    {
                        JOptionPane.showMessageDialog(this, "Xóa tài khoản login thành công!");
                    }
                    else
                    {
                        JOptionPane.showMessageDialog(this, "Xóa tài khoản login thất bại!");
                    }

                }
                catch(Exception ex)
                {
                    JOptionPane.showMessageDialog(this, "Xóa người dùng thất bại!");
                    ex.printStackTrace();
                }
            }
            else
            {
                JOptionPane.showMessageDialog(this, "Người dùng cần xóa không tồn tại!");
            }
            
        }
    }//GEN-LAST:event_btn_xoa_NDActionPerformed

    private void table_danhSach_NDMousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_table_danhSach_NDMousePressed
        int row=table_danhSach_ND.getSelectedRow();
        txt_user.setText((String) table_danhSach_ND.getValueAt(row, 0));
        txt_pass.setText((String) table_danhSach_ND.getValueAt(row, 1));
    }//GEN-LAST:event_table_danhSach_NDMousePressed

    private void btn_lamMoiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_lamMoiActionPerformed
        lamMoi();
    }//GEN-LAST:event_btn_lamMoiActionPerformed

    private void btn_dongActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_dongActionPerformed
        JFrame f=new JFrame("Exit");
        if(JOptionPane.showConfirmDialog(f, "Bạn có muốn thoát chương trình ?", "Thông báo", JOptionPane.YES_NO_OPTION)==JOptionPane.YES_OPTION)
            System.exit(0);
    }//GEN-LAST:event_btn_dongActionPerformed

    private void btn_saoLuuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_saoLuuActionPerformed
        String sql="EXEC DBO.TT_BACKUP";
        try{
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.execute();
            ps.close();
            
            JOptionPane.showMessageDialog(this, "Sao lưu dữ liệu thành công!");
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Sao lưu dữ liệu không thành công!");
            ex.printStackTrace();
        }
    }//GEN-LAST:event_btn_saoLuuActionPerformed

    private void btn_khoiPhucActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_khoiPhucActionPerformed
        String sql="USE master " + "EXEC DBO.TT_RESTORE";
        try{
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.executeUpdate();
            ps.close();
            this.conn.close();
            
            
            this.setVisible(false);
            QL_NguoiDung nd=new QL_NguoiDung();
            nd.setVisible(true);
            JOptionPane.showMessageDialog(this, "Khôi phục dữ liệu thành công!");
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Khôi phục dữ liệu không thành công!");
            ex.printStackTrace();
        }
    }//GEN-LAST:event_btn_khoiPhucActionPerformed

    private void radio_caNhanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_radio_caNhanActionPerformed
        txt_userThucThi.setEnabled(true);
        btn_themNhom_CN.setEnabled(true);
        btn_kickNhom_CN.setEnabled(true);
        btn_phanQuyen_CN.setEnabled(true);
        combo_nhomCaNhan.setEnabled(false);
        btn_ok.setEnabled(false);
        
        txt_tenNhom.setEnabled(false);
        btn_taoNhom.setEnabled(false);
        btn_xoaNhom.setEnabled(false);
        btn_phanQuyen_Nhom.setEnabled(false);
        combo_nhomNguoiDung.setEnabled(false);
        btn_ok_Nhom.setEnabled(false);
    }//GEN-LAST:event_radio_caNhanActionPerformed

    private void radio_nhom_NDActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_radio_nhom_NDActionPerformed
        txt_tenNhom.setEnabled(true);
        btn_taoNhom.setEnabled(true);
        btn_xoaNhom.setEnabled(true);
        btn_phanQuyen_Nhom.setEnabled(true);
        combo_nhomNguoiDung.setEnabled(false);
        btn_ok_Nhom.setEnabled(false);
        
        txt_quyenTT_Default.setEnabled(false);
        txt_userThucThi.setEnabled(false);
        btn_themNhom_CN.setEnabled(false);
        btn_kickNhom_CN.setEnabled(false);
        btn_phanQuyen_CN.setEnabled(false);
        combo_nhomCaNhan.setEnabled(false);
        btn_ok.setEnabled(false);
    }//GEN-LAST:event_radio_nhom_NDActionPerformed

    private void btn_themNhom_CNActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_themNhom_CNActionPerformed
        btn_kickNhom_CN.setEnabled(false);
        btn_phanQuyen_CN.setEnabled(false);
        combo_nhomCaNhan.setEnabled(true);
        btn_ok.setEnabled(true);

        docDanhSachNhom_Combo_CN();
 
    }//GEN-LAST:event_btn_themNhom_CNActionPerformed

    private void btn_phanQuyen_NhomActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_phanQuyen_NhomActionPerformed
        txt_tenNhom.setEnabled(false);
        btn_taoNhom.setEnabled(false);
        btn_xoaNhom.setEnabled(false);
        combo_nhomNguoiDung.setEnabled(true);
        btn_ok_Nhom.setEnabled(true);
        
        docDanhSachNhom_Combo();
    }//GEN-LAST:event_btn_phanQuyen_NhomActionPerformed

    private void btn_okActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_okActionPerformed
        String user=txt_userThucThi.getText().toString();
        if(user.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Không được bỏ trống username!");
        }
        else
        {
            int kt_user=kiemTraUser_TonTai(user);
            if(kt_user!=0)
            {
                int index=combo_nhomCaNhan.getSelectedIndex();
                String nhom=combo_nhomCaNhan.getItemAt(index).toString();
                boolean a=btn_themNhom_CN.isEnabled();
                if(a==true)
                {
                    String pass=layPass_TableTaiKhoan(user);
                    int addNhom=themThanhVienNhom(nhom,user);
                    if(addNhom==1)
                    {
                        JOptionPane.showMessageDialog(this, "Thêm người dùng " + user + " vào nhóm "+ nhom + " thành công!");
                    }
                    else
                    {
                        JOptionPane.showMessageDialog(this, "Thêm người dùng " + user + " vào nhóm "+ nhom + " thất bại!");
                    }
                }
                else
                {
                    int xoaNhom=xoaThanhVienNhom(nhom,user);
                    if(xoaNhom==1)
                    {
                        JOptionPane.showMessageDialog(this, "Xóa người dùng " + user + " trong nhóm "+ nhom + " thành công!");
                    }
                    else
                    {
                        JOptionPane.showMessageDialog(this, "Xóa người dùng " + user + " trong nhóm "+ nhom + " thất bại!");
                    }
                }
            }
            else
            {
                JOptionPane.showMessageDialog(this, "Lỗi usename vừa nhập phía trên không tồn tại(1)!");
            }
        }
    }//GEN-LAST:event_btn_okActionPerformed

    private void btn_kickNhom_CNActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_kickNhom_CNActionPerformed
        btn_themNhom_CN.setEnabled(false);
        btn_phanQuyen_CN.setEnabled(false);
        combo_nhomCaNhan.setEnabled(true);
        btn_ok.setEnabled(true);
        
        docDanhSachNhom_Combo_CN();
    }//GEN-LAST:event_btn_kickNhom_CNActionPerformed

    private void btn_taoNhomActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_taoNhomActionPerformed
        btn_xoaNhom.setEnabled(false);
        btn_phanQuyen_Nhom.setEnabled(false);
        
        String nhom=txt_tenNhom.getText().toString();
        if(nhom.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Không được bỏ trống tên nhóm!");
        }
        else
        {
            int kt=kiemTraNhom_TonTai(nhom);
            if(kt!=0)
            {
                JOptionPane.showMessageDialog(this, "Nhóm bạn vừa tạo đã tồn tại!");
            }
            else
            {
                String sql="sp_addrole ?";
                try
                {
                    PreparedStatement ps=conn.prepareStatement(sql);
                    ps.setString(1, nhom);
                    ps.execute();
                    ps.close();
                    
                    int kt1=themNhomMoiVao_DSNhom(nhom);
                    if(kt1!=0)
                    {
                        JOptionPane.showMessageDialog(this, "Tạo nhóm mới thành công!");
                    }
                    else
                    {
                        JOptionPane.showMessageDialog(this, "Tạo nhóm mới thất bại!");
                    } 
                }
                catch(Exception ex)
                {
                    JOptionPane.showMessageDialog(this, "Lỗi tạo nhóm (1)!");
                    ex.printStackTrace();
                }
                
            }
        }
    }//GEN-LAST:event_btn_taoNhomActionPerformed

    private void btn_xoaNhomActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_xoaNhomActionPerformed
        btn_taoNhom.setEnabled(false);
        btn_phanQuyen_Nhom.setEnabled(false);
        
        String nhom=txt_tenNhom.getText().toString();
        if(nhom.equals(""))
        {
            JOptionPane.showMessageDialog(this, "Không được bỏ trống tên nhóm!");
        }
        else
        {
            int kt=kiemTraNhom_TonTai(nhom);
            if(kt==0)
            {
                JOptionPane.showMessageDialog(this, "Nhóm bạn vừa nhập không tồn tại!");
            }
            else
            {
                int xoaNhom=0;
                String sql="sp_droprole ?";
                try
                {
                    PreparedStatement ps=conn.prepareStatement(sql);
                    ps.setString(1, nhom);
                    ps.execute();
                    ps.close();
                    
                    xoaNhom++;
                }
                catch(Exception ex)
                {
                    JOptionPane.showMessageDialog(this, "Lỗi xóa nhóm ra khỏi danh sách(1)! =>> Có thể là còn thành viên trong nhóm nên không thể xóa!!");
                    ex.printStackTrace();
                }
                if(xoaNhom!=0)
                {
                    int kt1=xoaNhomRaKhoi_DSNhom(nhom);
                    if(kt1!=0)
                    {
                        JOptionPane.showMessageDialog(this, "Xóa nhóm ra khỏi danh sách thành công!");
                    }
                    else
                    {
                        JOptionPane.showMessageDialog(this, "Xóa nhóm ra khỏi danh sách thất bại!");
                    } 
                }
                
            }
        }
    }//GEN-LAST:event_btn_xoaNhomActionPerformed

    private void btn_ok_NhomActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_ok_NhomActionPerformed
        ls_danhSachTable.setEnabled(true);
        
    }//GEN-LAST:event_btn_ok_NhomActionPerformed

    private void ls_danhSachTableMousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ls_danhSachTableMousePressed
        String table=ls_danhSachTable.getSelectedValue().toString();
        if(!table.equals(""))
        {
            combo_quyen.setEnabled(true);
            btn_taoQuyen.setEnabled(true);
            btn_xoaQuyen.setEnabled(true);
        }
    }//GEN-LAST:event_ls_danhSachTableMousePressed

    private void combo_quyenMousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_combo_quyenMousePressed
        // TODO add your handling code here:
    }//GEN-LAST:event_combo_quyenMousePressed

    private void btn_taoQuyenActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_taoQuyenActionPerformed
        String user_group="";
        String quyen="";
        String bang="";
        
        if(txt_userThucThi.isEnabled()==false)  //Đang thực thi trên nhóm quyền
        {
            int index=combo_nhomNguoiDung.getSelectedIndex();
            user_group=combo_nhomNguoiDung.getItemAt(index).toString();
        }
        else    //Thực thi trên user cá nhân
        {
            user_group=txt_userThucThi.getText().toString();
            if(user_group.equals(""))
            {
                JOptionPane.showMessageDialog(this, "Không được bỏ trống Username!");
                return;
            }
            else
            {
                int kt = kiemTraUser_TonTai(user_group);
                if(kt==0)
                {
                    JOptionPane.showMessageDialog(this, "Username vừa nhập không tồn tại!");
                    return;
                }  
            }
        }
        
        int index1=combo_quyen.getSelectedIndex();
        quyen=combo_quyen.getItemAt(index1).toString();

        bang=ls_danhSachTable.getSelectedValue().toString();
        
        
        String sql="EXEC DBO.TT_TAO_PHANQUYEN ?, ?, ?";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.setString(1, user_group);
            ps.setString(2, quyen);
            ps.setString(3, bang);
            ps.execute();
            ps.close();
            
            JOptionPane.showMessageDialog(this, "Tạo quyền thành công!");
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Lỗi tạo quyền(1)!");
            ex.printStackTrace();
        }
             
    }//GEN-LAST:event_btn_taoQuyenActionPerformed

    private void btn_xoaQuyenActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_xoaQuyenActionPerformed
        String user_group="";
        String quyen="";
        String bang="";
        
        if(txt_userThucThi.isEnabled()==false)  //Đang thực thi trên nhóm quyền
        {
            int index=combo_nhomNguoiDung.getSelectedIndex();
            user_group=combo_nhomNguoiDung.getItemAt(index).toString();
        }
        else    //Thực thi trên user cá nhân
        {
            user_group=txt_userThucThi.getText().toString();
            if(user_group.equals(""))
            {
                JOptionPane.showMessageDialog(this, "Không được bỏ trống Username!");
                return;
            }
            else
            {
                int kt = kiemTraUser_TonTai(user_group);
                if(kt==0)
                {
                    JOptionPane.showMessageDialog(this, "Username vừa nhập không tồn tại!");
                    return;
                }  
            }
        }
        
        int index1=combo_quyen.getSelectedIndex();
        quyen=combo_quyen.getItemAt(index1).toString();

        bang=ls_danhSachTable.getSelectedValue().toString();
        
        
        
        String sql="EXEC DBO.TT_XOA_PHANQUYEN ?, ?, ?";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.setString(1, user_group);
            ps.setString(2, quyen);
            ps.setString(3, bang);
            ps.execute();
            ps.close();
            
            JOptionPane.showMessageDialog(this, "Xóa quyền thành công!");
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Lỗi xóa quyền(1)!");
            ex.printStackTrace();
        }
    }//GEN-LAST:event_btn_xoaQuyenActionPerformed

    private void QuaylaiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_QuaylaiActionPerformed
        this.setVisible(false);
        ChonLua da=new ChonLua();
        da.setVisible(true);
    }//GEN-LAST:event_QuaylaiActionPerformed

    private void txt_quyenTT_DefaultActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txt_quyenTT_DefaultActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txt_quyenTT_DefaultActionPerformed

    
    public void phanQuyen(String tenBang, String user_hoac_nhom)
    {
        
    }
    
    
    public int kiemTaiKhoan_TonTai(String tk,String loai)
    {
        int kt=0;
        String sql="SELECT * FROM TAIKHOAN WHERE TEN=? AND LOAI=?";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.setString(1, tk);
            ps.setString(2, loai);
            ResultSet rs=ps.executeQuery();
            while(rs.next())
            {
                rs.close();
                ps.close();
                return 1;
            }

        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Lỗi kiểm tra tài khoản tồn tại!");
            ex.printStackTrace();
        }
        return kt;
    }
    
    public int kiemTraUser_TonTai(String tk)
    {
        int kt=0;
        String sql="SELECT * FROM TAIKHOAN WHERE TEN=?";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.setString(1, tk);
            ResultSet rs=ps.executeQuery();
            while(rs.next())
            {
                rs.close();
                ps.close();
                return 1;
            }

        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Lỗi kiểm tra user tồn tại!");
            ex.printStackTrace();
        }
        return kt;
    }
    
    public int kiemTraNhom_TonTai(String tenNhom)
    {
        String sql="SELECT * FROM DS_NHOM WHERE TENNHOM=?";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.setString(1, tenNhom);
            ResultSet rs=ps.executeQuery();
            while(rs.next())
            {
                rs.close();
                ps.close();
                return 1;
            }
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Lỗi kiểm tra tên nhóm tồn tại(1)!");
            ex.printStackTrace();
            return 0;
        }
        return 0;
    }
    
    public int themNhomMoiVao_DSNhom(String tenNhom)
    {
        int kt=kiemTraNhom_TonTai(tenNhom);
        if(kt!=0)
        {
            JOptionPane.showMessageDialog(this, "Nhóm đã tồn tại không thể thêm(1)!");
            return 0;
        }
        else
        {
            String sql="INSERT INTO DS_NHOM VALUES(?)";
            try
            {
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1, tenNhom);
                ps.executeUpdate();
                ps.close();
                
                lamMoi();
                return 1;
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, "Lỗi thêm tên nhóm vào danh sách nhóm (2)!");
                ex.printStackTrace();
                return 0;
            }
        }
    }

    public int xoaNhomRaKhoi_DSNhom(String tenNhom)
    {
        int kt=kiemTraNhom_TonTai(tenNhom);
        if(kt==0)
        {
            JOptionPane.showMessageDialog(this, "Nhóm này không tồn tại(1)!. Erro xóa nhóm ra khỏi danh sách nhóm");
            return 0;
        }
        else
        {
            String sql="DELETE FROM DS_NHOM WHERE TENNHOM=?";
            try
            {
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1, tenNhom);
                ps.executeUpdate();
                ps.close();
                
                lamMoi();
                return 1;
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, "Lỗi xóa tên nhóm ra khỏi danh sách nhóm (2)!");
                ex.printStackTrace();
                return 0;
            }
        }
    }
    
    
    
    
    
    
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(QL_NguoiDung.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(QL_NguoiDung.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(QL_NguoiDung.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(QL_NguoiDung.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new QL_NguoiDung().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton Quaylai;
    private javax.swing.JButton btn_dong;
    private javax.swing.JButton btn_khoiPhuc;
    private javax.swing.JButton btn_kickNhom_CN;
    private javax.swing.JButton btn_lamMoi;
    private javax.swing.JButton btn_ok;
    private javax.swing.JButton btn_ok_Nhom;
    private javax.swing.JButton btn_phanQuyen_CN;
    private javax.swing.JButton btn_phanQuyen_Nhom;
    private javax.swing.JButton btn_saoLuu;
    private javax.swing.JButton btn_taoMoi_ND;
    private javax.swing.JButton btn_taoNhom;
    private javax.swing.JButton btn_taoQuyen;
    private javax.swing.JButton btn_themNhom_CN;
    private javax.swing.JButton btn_xoaNhom;
    private javax.swing.JButton btn_xoaQuyen;
    private javax.swing.JButton btn_xoa_ND;
    private javax.swing.ButtonGroup buttonGroup1;
    private javax.swing.ButtonGroup buttonGroup2;
    private javax.swing.JComboBox<String> combo_nhomCaNhan;
    private javax.swing.JComboBox<String> combo_nhomNguoiDung;
    private javax.swing.JComboBox<String> combo_quyen;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel14;
    private javax.swing.JLabel jLabel15;
    private javax.swing.JLabel jLabel16;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JRadioButton jRadioButton1;
    private javax.swing.JScrollBar jScrollBar1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JScrollPane jScrollPane4;
    private javax.swing.JTextArea jTextArea1;
    private javax.swing.JList<String> ls_danhSachTable;
    private javax.swing.JList<String> ls_loaiND_CaNhan;
    private javax.swing.JRadioButton radio_caNhan;
    private javax.swing.JRadioButton radio_nhom_ND;
    private javax.swing.JTable table_danhSach_ND;
    private javax.swing.JPasswordField txt_pass;
    private javax.swing.JTextField txt_quyenTT_Default;
    private javax.swing.JTextField txt_tenNhom;
    private javax.swing.JTextField txt_user;
    private javax.swing.JTextField txt_userThucThi;
    // End of variables declaration//GEN-END:variables
}
