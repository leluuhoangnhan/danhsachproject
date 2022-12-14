/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package view;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.StringTokenizer;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author LeLuuHoangNhan
 */
public class ChuDauTu extends javax.swing.JFrame {
    private Connection conn;

    Vector nd=new Vector();
    Vector td=new Vector();
    public ChuDauTu() {
        initComponents();
        this.setVisible(false);
        td.add("Ma CDT");
        td.add("Ten CDT");
        td.add("Ngay DKKD");
        td.add("Ma So Thue");
        td.add("Ma Du An");
        table_kq.setModel(new DefaultTableModel(nd,td));
        
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            conn=DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=DB_QLDA;"
                    + "username=sa;password=1321");
            docdata();
            
        }
        catch(Exception e)
        {
            e.printStackTrace();
        }
        
        voHieuQuaVaPhanQuyenCacNut();
    }
    
    public void docdata()
    {
        String sql="SELECT * FROM CHUDAUTU";
        try{
            PreparedStatement ps=conn.prepareStatement(sql);
            ResultSet rs=ps.executeQuery();
            while(rs.next())
            {
                String maCDT=rs.getString(1);
                String tenCDT=rs.getString(2);
                String ngayDKKD=rs.getDate(3).toString();
                String maSoThue=rs.getString(4);
                String maDuAn=rs.getString(5);
                
                Vector r=new Vector();
                r.add(maCDT);
                r.add(tenCDT);
                r.add(ngayDKKD);
                r.add(maSoThue);
                r.add(maDuAn);
                
                nd.add(r);
                table_kq.setModel(new DefaultTableModel(nd,td));
            }
            rs.close();
            ps.close();
        }
        catch(Exception e)
        {
            JOptionPane.showMessageDialog(this, "Doc du lieu loi !");
            e.printStackTrace();
        }
        
    }
    
    public String layTenUserDN()
    {
        String sql="SELECT DISTINCT TEN FROM SAVE_DANGNHAP";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ResultSet rs=ps.executeQuery();
            while(rs.next())
            {
                return rs.getString(1);
            }
            rs.close();
            ps.close();
            return "";
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Loi lay ra ten dang nhap (1)!");
            ex.printStackTrace();
            return "";
        }
    }
    
    public String kiemTraQuyenNhom(String loaiUser, String bang)
    {
        String str="";
        String sql="SELECT QUYEN FROM PHANQUYEN WHERE TEN = ? AND BANG_CHON=?";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.setString(1, loaiUser);
            ps.setString(2, bang);
            ResultSet rs=ps.executeQuery();
            while(rs.next())
            {
                if(rs.getString(1).equals("INSERT"))
                {
                    str= str + "INSERT" + ";";
                }
                else if(rs.getString(1).equals("UPDATE"))
                {
                    str= str + "UPDATE" + ";";
                }
                else if(rs.getString(1).equals("DELETE"))
                {
                    str= str + "DELETE" + ";";
                }
            }
            rs.close();
            ps.close();
            return str;
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Loi kiem tra quyen nhom(1)!");
            ex.printStackTrace();
            return str;
        }
    }
    
    public String layQuyenSelectNhom(String tenUser)
    {   
        String str="";
        String sql="SELECT LOAI FROM TAIKHOAN WHERE TEN=?";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.setString(1, tenUser);
            ResultSet rs=ps.executeQuery();
            while(rs.next())
            {
                str = str + kiemTraQuyenNhom(rs.getString(1),"CHUDAUTU");
            }
            rs.close();
            ps.close();
            return str;
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Loi lay ra quyen nhom(2)!");
            ex.printStackTrace();
            return str;
        }    
    }
    
    public String kiemTraQuyenCaNhan(String tenUser)
    {
        String str="";
        String sql="SELECT QUYEN FROM PHANQUYEN WHERE TEN = ? AND BANG_CHON = ?";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.setString(1, tenUser);
            ps.setString(2, "CHUDAUTU");
            ResultSet rs=ps.executeQuery();
            while(rs.next())
            {
                if(rs.getString(1).equals("INSERT"))
                {
                    str= str + "INSERT" + ";";
                }
                else if(rs.getString(1).equals("UPDATE"))
                {
                    str= str + "UPDATE" + ";";
                }
                else if(rs.getString(1).equals("DELETE"))
                {
                    str= str + "DELETE" + ";";
                }
            }
            rs.close();
            ps.close();
            return str;
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Loi kiem tra quyen ca nhan(1)!");
            ex.printStackTrace();
            return str;
        }
    }
    
    public void voHieuQuaVaPhanQuyenCacNut()
    {
        int insert_Nhom = 0, update_Nhom = 0, delete_Nhom = 0, insert_CN = 0, update_CN = 0, delete_CN = 0;
        String user = layTenUserDN();
        String quyenNhom= layQuyenSelectNhom(user);
        String quyenCaNhan= kiemTraQuyenCaNhan(user);
        
        if(!quyenNhom.equals(""))
        {
            String value;
            StringTokenizer stk=new StringTokenizer(quyenNhom,";");
            for(int i=0;i-1<=stk.countTokens();i++)
            {
                value=stk.nextToken();
                if(value.equals("INSERT"))
                    insert_Nhom++;
                else if(value.equals("UPDATE"))
                    update_Nhom++;
                else if(value.equals("DELETE"))
                    delete_Nhom++;
            }
        }
        
        if(!quyenCaNhan.equals(""))
        {
            String value2;
            StringTokenizer stk2=new StringTokenizer(quyenCaNhan,";");
            for(int i=0;i-1<=stk2.countTokens();i++)
            {
                value2=stk2.nextToken();
                if(value2.equals("INSERT"))
                    insert_CN++;
                else if(value2.equals("UPDATE"))
                    update_CN++;
                else if(value2.equals("DELETE"))
                    delete_CN++;
            }
        }
        
        
        if(insert_Nhom !=0 || insert_CN != 0)
            but_them.setEnabled(true);
        else
            but_them.setEnabled(false);
        
        if(update_Nhom !=0 || update_CN != 0)
            but_capnhat.setEnabled(true);
        else
            but_capnhat.setEnabled(false);
        
        if(delete_Nhom !=0 || delete_CN != 0)
            but_xoa.setEnabled(true);
        else
            but_xoa.setEnabled(false);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        but_xoa1 = new javax.swing.JButton();
        but_xoa2 = new javax.swing.JButton();
        but_them1 = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        txt_macdt = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        txt_tencdt = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        txt_ngaydkkd = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        txt_masothue = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        txt_maduan = new javax.swing.JTextField();
        but_capnhat = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        table_kq = new javax.swing.JTable();
        but_them = new javax.swing.JButton();
        but_xoa = new javax.swing.JButton();
        but_timkiem = new javax.swing.JButton();
        but_xuatfile = new javax.swing.JButton();
        but_nhapfile = new javax.swing.JButton();
        but_dong = new javax.swing.JButton();
        btn_lamMoi = new javax.swing.JButton();
        btn_saoLuu = new javax.swing.JButton();
        btn_khoiPhuc = new javax.swing.JButton();
        btn_removeALL = new javax.swing.JButton();
        Quaylai = new javax.swing.JButton();

        but_xoa1.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        but_xoa1.setText("X??a");
        but_xoa1.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(255, 0, 51)));
        but_xoa1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_xoa1ActionPerformed(evt);
            }
        });

        but_xoa2.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        but_xoa2.setText("X??a");
        but_xoa2.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(255, 0, 51)));
        but_xoa2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_xoa2ActionPerformed(evt);
            }
        });

        but_them1.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        but_them1.setText("Th??m M???i");
        but_them1.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(255, 0, 51)));
        but_them1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_them1ActionPerformed(evt);
            }
        });

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(255, 51, 51));
        jLabel1.setText("Ch??? ?????u T??");

        jLabel2.setText("M?? C??T :");

        txt_macdt.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txt_macdtActionPerformed(evt);
            }
        });

        jLabel3.setText("T??n C??T :");

        jLabel4.setText("Ng??y DKKD :");

        jLabel5.setText("M?? s??? thu??? :");

        jLabel6.setText("M?? d??? ??n :");

        but_capnhat.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        but_capnhat.setText("C???p nh???t");
        but_capnhat.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(255, 0, 0)));
        but_capnhat.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_capnhatActionPerformed(evt);
            }
        });

        table_kq.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        table_kq.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                table_kqMousePressed(evt);
            }
        });
        jScrollPane1.setViewportView(table_kq);

        but_them.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        but_them.setText("Th??m M???i");
        but_them.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(255, 0, 51)));
        but_them.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_themActionPerformed(evt);
            }
        });

        but_xoa.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        but_xoa.setText("X??a");
        but_xoa.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(255, 0, 51)));
        but_xoa.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_xoaActionPerformed(evt);
            }
        });

        but_timkiem.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        but_timkiem.setText("T??m ki???m");
        but_timkiem.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(255, 0, 51)));
        but_timkiem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_timkiemActionPerformed(evt);
            }
        });

        but_xuatfile.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        but_xuatfile.setText("Xu???t file.txt");
        but_xuatfile.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_xuatfileActionPerformed(evt);
            }
        });

        but_nhapfile.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        but_nhapfile.setText("Nh???p file.txt");
        but_nhapfile.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_nhapfileActionPerformed(evt);
            }
        });

        but_dong.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        but_dong.setText("????ng");
        but_dong.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                but_dongMouseClicked(evt);
            }
        });
        but_dong.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_dongActionPerformed(evt);
            }
        });

        btn_lamMoi.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btn_lamMoi.setText("L??m M???i");
        btn_lamMoi.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_lamMoiActionPerformed(evt);
            }
        });

        btn_saoLuu.setBackground(new java.awt.Color(255, 204, 102));
        btn_saoLuu.setText("Sao l??u");
        btn_saoLuu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_saoLuuActionPerformed(evt);
            }
        });

        btn_khoiPhuc.setBackground(new java.awt.Color(204, 255, 102));
        btn_khoiPhuc.setText("Kh??i ph???c");
        btn_khoiPhuc.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_khoiPhucActionPerformed(evt);
            }
        });

        btn_removeALL.setBackground(new java.awt.Color(255, 0, 0));
        btn_removeALL.setText("Remove All");
        btn_removeALL.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_removeALLActionPerformed(evt);
            }
        });

        Quaylai.setText("Quay l???i");
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
                .addGap(22, 22, 22)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel2)
                            .addComponent(jLabel3))
                        .addGap(28, 28, 28)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(txt_macdt, javax.swing.GroupLayout.DEFAULT_SIZE, 166, Short.MAX_VALUE)
                            .addComponent(txt_tencdt)))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel4)
                            .addComponent(jLabel5))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(txt_ngaydkkd)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(0, 0, Short.MAX_VALUE)
                                .addComponent(txt_masothue, javax.swing.GroupLayout.PREFERRED_SIZE, 165, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel6)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(txt_maduan, javax.swing.GroupLayout.PREFERRED_SIZE, 165, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 66, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(but_capnhat, javax.swing.GroupLayout.DEFAULT_SIZE, 154, Short.MAX_VALUE)
                    .addComponent(but_them, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(but_xoa, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(but_timkiem, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addGap(123, 123, 123))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jLabel1)
                .addGap(236, 236, 236))
            .addGroup(layout.createSequentialGroup()
                .addGap(34, 34, 34)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(but_xuatfile)
                        .addGap(18, 18, 18)
                        .addComponent(but_nhapfile)
                        .addGap(29, 29, 29)
                        .addComponent(btn_lamMoi)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(Quaylai))
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(183, 183, 183)
                        .addComponent(btn_removeALL)))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(btn_khoiPhuc, javax.swing.GroupLayout.DEFAULT_SIZE, 85, Short.MAX_VALUE)
                    .addComponent(btn_saoLuu, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(but_dong, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 80, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jLabel2)
                        .addComponent(txt_macdt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(but_them, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(11, 11, 11)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel3)
                            .addComponent(txt_tencdt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(21, 21, 21)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel4)
                            .addComponent(txt_ngaydkkd, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(28, 28, 28)
                        .addComponent(but_capnhat, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(16, 16, 16)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5)
                    .addComponent(txt_masothue, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(but_xoa, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel6)
                    .addComponent(txt_maduan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(but_timkiem, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(33, 33, 33)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(btn_saoLuu, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(btn_khoiPhuc, javax.swing.GroupLayout.PREFERRED_SIZE, 49, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(45, 45, 45))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 138, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btn_removeALL)))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(but_xuatfile)
                    .addComponent(but_nhapfile)
                    .addComponent(btn_lamMoi)
                    .addComponent(Quaylai)
                    .addComponent(but_dong))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void txt_macdtActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txt_macdtActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txt_macdtActionPerformed

    private void but_capnhatActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_capnhatActionPerformed
        int row=table_kq.getSelectedRow();
        String maCDT=table_kq.getValueAt(row, 0).toString();
        String tenCDT=table_kq.getValueAt(row, 1).toString();
        String ngayDKKD=table_kq.getValueAt(row, 2).toString();
        String maSoThue=table_kq.getValueAt(row, 3).toString();
        String maDuAn=table_kq.getValueAt(row, 4).toString();
        
        String maCDT1=txt_macdt.getText().toString();
        String tenCDT1=txt_tencdt.getText().toString();
        String ngayDKKD1=txt_ngaydkkd.getText().toString();
        String maSoThue1=txt_masothue.getText().toString();
        String maDuAn1=txt_maduan.getText().toString();
        
        if(maCDT1.equals("")||tenCDT1.equals("")||ngayDKKD1.equals("")||maSoThue1.equals("")||maDuAn1.equals(""))
        {
            JOptionPane.showMessageDialog(this,"Kh??ng b??? tr???ng c??c m???c tr??n!");
        }
        else
        {
            String sql="UPDATE CHUDAUTU " + "SET MACDT=?, TENCDT=?, NGAY_DKKD=?, MASOTHUE=?, MADUAN=? " 
                    +"WHERE MACDT=? AND TENCDT=? AND NGAY_DKKD=? AND MASOTHUE=? AND MADUAN=?";

            try{
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1,maCDT1);
                ps.setString(2,tenCDT1);
                ps.setString(3,ngayDKKD1);
                ps.setString(4,maSoThue1);
                ps.setString(5,maDuAn1);

                ps.setString(6,maCDT);
                ps.setString(7,tenCDT);
                ps.setString(8,ngayDKKD);
                ps.setString(9,maSoThue);
                ps.setString(10,maDuAn);

                ps.executeUpdate();
                ps.close();
                this.setVisible(false);
                ChuDauTu cdt=new ChuDauTu();
                cdt.setVisible(true);
                JOptionPane.showMessageDialog(this,"C???p nh???t th??nh c??ng!");
            }
            catch(Exception e)
            {
                JOptionPane.showMessageDialog(this,"C???p nh???t kh??ng th??nh c??ng!");
                e.printStackTrace();
            }
        }
         
    }//GEN-LAST:event_but_capnhatActionPerformed

    private void table_kqMousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_table_kqMousePressed
        int row=table_kq.getSelectedRow();
        txt_macdt.setText((String) table_kq.getValueAt(row, 0));
        txt_tencdt.setText((String) table_kq.getValueAt(row, 1));
        txt_ngaydkkd.setText((String) table_kq.getValueAt(row, 2));
        txt_masothue.setText((String) table_kq.getValueAt(row, 3));
        txt_maduan.setText((String) table_kq.getValueAt(row, 4));
    }//GEN-LAST:event_table_kqMousePressed

    private void but_themActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_themActionPerformed
        String maCDT=txt_macdt.getText().toString();
        String tenCDT=txt_tencdt.getText().toString();
        String ngayDKKD=txt_ngaydkkd.getText().toString();
        String maSoThue=txt_masothue.getText().toString();
        String maDuAn=txt_maduan.getText().toString();
        
        if(maCDT.equals("") ||tenCDT.equals("") ||ngayDKKD.equals("") ||maSoThue.equals("") ||maDuAn.equals(""))
        {
            JOptionPane.showMessageDialog(this,"Kh??ng b??? tr???ng c??c m???c tr??n!");
        }
        else
        {
            String sql="INSERT INTO CHUDAUTU (MACDT,TENCDT,NGAY_DKKD,MASOTHUE,MADUAN) " + "VALUES(?,?,?,?,?)";
            try{
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1,maCDT);
                ps.setString(2,tenCDT);
                ps.setString(3,ngayDKKD);
                ps.setString(4,maSoThue);
                ps.setString(5,maDuAn);

                ps.executeUpdate();
                ps.close();
                this.setVisible(false);
                ChuDauTu cdt=new ChuDauTu();
                cdt.setVisible(true);
                JOptionPane.showMessageDialog(this,"Th??m m???i th??nh c??ng!");
            }
            catch(Exception e)
            {
                JOptionPane.showMessageDialog(this,"Th??m m???i kh??ng th??nh c??ng!");
                e.printStackTrace();
            }
        }

    }//GEN-LAST:event_but_themActionPerformed

    private void but_xoaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_xoaActionPerformed

        String maCDT=txt_macdt.getText().toString();
        String maST=txt_masothue.getText().toString();
        String maDA=txt_maduan.getText().toString();
        if(maCDT.equals("")||maST.equals("")||maDA.equals(""))
        {
             JOptionPane.showMessageDialog(this,"Kh??ng ???????c b??? tr???ng MACDT, MASOTHUE, MADUAN!");
        }
        else
        {
            String sql="DELETE FROM CHUDAUTU WHERE MACDT=? AND MASOTHUE=? AND MADUAN=?";
            try{
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1,maCDT);
                ps.setString(2,maST);
                ps.setString(3,maDA);

                ps.executeUpdate();
                ps.close();
                this.setVisible(false);
                ChuDauTu cdt=new ChuDauTu();
                cdt.setVisible(true);
                JOptionPane.showMessageDialog(this,"X??a d??? li???u th??nh c??ng!");
            }
            catch(Exception e)
            {
                JOptionPane.showMessageDialog(this,"X??a d??? li???u kh??ng th??nh c??ng!");
                e.printStackTrace();
            }
        }
    }//GEN-LAST:event_but_xoaActionPerformed

    private void but_xoa1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_xoa1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_but_xoa1ActionPerformed

    private void but_xoa2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_xoa2ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_but_xoa2ActionPerformed

    private void but_them1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_them1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_but_them1ActionPerformed

    private void but_timkiemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_timkiemActionPerformed
        String maCDT=txt_macdt.getText().toString();
        String maST=txt_masothue.getText().toString();
        String maDA=txt_maduan.getText().toString();
        if(maCDT.equals("") || maST.equals("") || maDA.equals(""))
        {
            JOptionPane.showMessageDialog(this,"MaCDT - Ma So Thue - Ma Du An =>>> Kh??ng ???????c b??? tr???ng !");
        }
        else{
            int tk=timKiem(maCDT, maST, maDA);
            if(tk!=0)
            {
                JOptionPane.showMessageDialog(this,"T??m th???y t???i v??? tr?? th??? : " + tk);
                JFrame f=new JFrame("ChiTiet");
                if(JOptionPane.showConfirmDialog(f, "B???n c?? mu???n xem th??ng tin chi ti???t ch??? ?????u t?? kh??ng?", "Th??ng b??o", JOptionPane.YES_NO_OPTION)==JOptionPane.YES_OPTION)
                {
                    this.setVisible(false);
                    ChiTietCDT ct=new ChiTietCDT();
                    ct.setVisible(true);
                    ct.xuatThongTin(maCDT);
                }
                
            }
            else{
                JOptionPane.showMessageDialog(this,"Kh??ng t??m th???y !");
            }
        }
    }//GEN-LAST:event_but_timkiemActionPerformed

    public int timKiem(String maCDT, String maST, String maDA)
    {
        int kt=1;
        String sql1="SELECT * FROM CHUDAUTU";
        try{
            PreparedStatement ps1=conn.prepareStatement(sql1);
            ResultSet rs=ps1.executeQuery();
            while(rs.next())
            {
                if(maCDT.equals(rs.getString("MACDT")) && maST.equals(rs.getString("MASOTHUE")) && maDA.equals(rs.getString("MADUAN")))
                {
                   return kt; 
                }
                kt++;
            }
            rs.close();
            ps1.close();
        }
        catch(Exception e)
        {
            e.printStackTrace();
        }
        return 0;
    }
    
    private void but_dongMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_but_dongMouseClicked
        JFrame f=new JFrame("Exit");
        if(JOptionPane.showConfirmDialog(f, "B???n c?? mu???n tho??t ch????ng tr??nh ?", "Th??ng b??o", JOptionPane.YES_NO_OPTION)==JOptionPane.YES_OPTION)
            System.exit(0);
    }//GEN-LAST:event_but_dongMouseClicked

    private void but_xuatfileActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_xuatfileActionPerformed
        int k=1;
        try{
            File f=new File("E:/CDT.TXT");
            while(f.exists())
            {
                f=new File("E:/CDT" + "(" + k + ")" + ".TXT");
                k++;
            }
            FileWriter fw=new FileWriter(f);
            for(int i=0;i<table_kq.getRowCount();i++)
            {
                  fw.write((String) table_kq.getValueAt(i, 0)+";");
                  fw.write((String) table_kq.getValueAt(i, 1)+";");
                  fw.write((String) table_kq.getValueAt(i, 2)+";");
                  fw.write((String) table_kq.getValueAt(i, 3)+";");
                  fw.write((String) table_kq.getValueAt(i, 4));
                  if(i+1!=table_kq.getRowCount())
                      fw.write("\n");
            }
            fw.close();
            JOptionPane.showMessageDialog(this, "Xuat file thanh cong !");
        }
        catch(Exception e)
        {
            JOptionPane.showMessageDialog(this, "Loi xuat file !");
            e.printStackTrace();
        }
    }//GEN-LAST:event_but_xuatfileActionPerformed

    private void but_nhapfileActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_nhapfileActionPerformed

            int nhapFile=this.nhapFileMoi("E:/CDT.TXT");
            if(nhapFile!=0)
            {
                int nhap=this.nhapDataVaoSQL();
                if(nhap==1)
                {
                    this.setVisible(false);
                    ChuDauTu cdt=new ChuDauTu();
                    cdt.setVisible(true);
                    JOptionPane.showMessageDialog(this,"Nhap file thanh cong !");
                }
                else{
                    JOptionPane.showMessageDialog(this,"Nhap file khong thanh cong !");
                }
            }
            else{
                JOptionPane.showMessageDialog(this,"Nhap file.txt vao java khong thanh cong !");
            }
            
    }//GEN-LAST:event_but_nhapfileActionPerformed

    private void but_dongActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_dongActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_but_dongActionPerformed

    private void btn_lamMoiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_lamMoiActionPerformed
        this.setVisible(false);
        ChuDauTu cdt=new ChuDauTu();
        cdt.setVisible(true);
    }//GEN-LAST:event_btn_lamMoiActionPerformed

    private void btn_saoLuuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_saoLuuActionPerformed
        String sql="EXEC DBO.TT_BACKUP";
        try{
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.execute();
            ps.close();
            
            JOptionPane.showMessageDialog(this, "Sao l??u d??? li???u th??nh c??ng!");
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Sao l??u d??? li???u kh??ng th??nh c??ng!");
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
            ChuDauTu cdt=new ChuDauTu();
            cdt.setVisible(true);
            JOptionPane.showMessageDialog(this, "Kh??i ph???c d??? li???u th??nh c??ng!");
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Kh??i ph???c d??? li???u kh??ng th??nh c??ng!");
            ex.printStackTrace();
        }
    }//GEN-LAST:event_btn_khoiPhucActionPerformed

    private void btn_removeALLActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_removeALLActionPerformed
        String sql="DELETE FROM CHUDAUTU";
        try
        {
            PreparedStatement ps=conn.prepareStatement(sql);
            ps.executeUpdate();
            ps.close();
            
            this.setVisible(false);
            ChuDauTu cdt=new ChuDauTu();
            cdt.setVisible(true);
            JOptionPane.showMessageDialog(this, "Remove All th??nh c??ng!");
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Remove All kh??ng th??nh c??ng!");
            ex.printStackTrace();
        }
    }//GEN-LAST:event_btn_removeALLActionPerformed

    private void QuaylaiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_QuaylaiActionPerformed
        // TODO add your handling code here:
                    this.setVisible(false);
            ChonLua da=new ChonLua();
            da.setVisible(true);
    }//GEN-LAST:event_QuaylaiActionPerformed

    
    public int nhapFileMoi(String url)
    {
        int kq=0;
        try{
            File f = new File(url);
            if(f.exists())
            {
                try(BufferedReader br=new BufferedReader(new FileReader(f)))
                {
                    String value;
                    while((value=br.readLine())!=null)
                    {
                        StringTokenizer stk=new StringTokenizer(value,";");
                        String maCDT=stk.nextToken();
                        String tenCDT=stk.nextToken();
                        String ngayDKKD=stk.nextToken();
                        String maSoThue=stk.nextToken();
                        String maDuAn=stk.nextToken();
                        Vector r=new Vector();
                        r.add(maCDT);
                        r.add(tenCDT);
                        r.add(ngayDKKD);
                        r.add(maSoThue);
                        r.add(maDuAn);
                        nd.add(r);
                        kq++;
                    }
                }
                catch(Exception ex)
                {
                    ex.printStackTrace();
                }
            }
            return kq;
        }
        catch(Exception e){
            e.printStackTrace();
            return kq;
        }
    }
    
    public int nhapDataVaoSQL()
    {
        int kq=0;
        for(int i=0;i<table_kq.getRowCount();i++)
        {
            String maCDT = (String) table_kq.getValueAt(i, 0);
            String tenCDT = (String) table_kq.getValueAt(i, 1);
            String ngayDKKD = (String) table_kq.getValueAt(i, 2);
            String maST = (String) table_kq.getValueAt(i, 3);
            String maDA = (String) table_kq.getValueAt(i, 4);

            String sql="INSERT INTO CHUDAUTU (MACDT,TENCDT,NGAY_DKKD,MASOTHUE,MADUAN) VALUES(?,?,?,?,?)";
            try{
                PreparedStatement ps=conn.prepareStatement(sql);
                ps.setString(1, maCDT);
                ps.setString(2, tenCDT);
                ps.setString(3,ngayDKKD);
                ps.setString(4, maST);
                ps.setString(5, maDA);
                
                ps.executeUpdate();
                ps.close();
                kq=1;
            }
            catch(Exception e)
            {
                e.printStackTrace(); 
            }
        }
        return kq;
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
            java.util.logging.Logger.getLogger(ChuDauTu.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ChuDauTu.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ChuDauTu.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ChuDauTu.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ChuDauTu().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton Quaylai;
    private javax.swing.JButton btn_khoiPhuc;
    private javax.swing.JButton btn_lamMoi;
    private javax.swing.JButton btn_removeALL;
    private javax.swing.JButton btn_saoLuu;
    private javax.swing.JButton but_capnhat;
    private javax.swing.JButton but_dong;
    private javax.swing.JButton but_nhapfile;
    private javax.swing.JButton but_them;
    private javax.swing.JButton but_them1;
    private javax.swing.JButton but_timkiem;
    private javax.swing.JButton but_xoa;
    private javax.swing.JButton but_xoa1;
    private javax.swing.JButton but_xoa2;
    private javax.swing.JButton but_xuatfile;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable table_kq;
    private javax.swing.JTextField txt_macdt;
    private javax.swing.JTextField txt_maduan;
    private javax.swing.JTextField txt_masothue;
    private javax.swing.JTextField txt_ngaydkkd;
    private javax.swing.JTextField txt_tencdt;
    // End of variables declaration//GEN-END:variables
}
