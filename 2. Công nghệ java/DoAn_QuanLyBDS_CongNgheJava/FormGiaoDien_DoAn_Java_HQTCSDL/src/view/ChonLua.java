/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package view;

import java.awt.Frame;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

/**
 *
 * @author LeLuuHoangNhan
 */
public class ChonLua extends javax.swing.JFrame {

    private Connection conn;
    private Object comboOption;

    /**
     * Creates new form ChonLua
     */
    public ChonLua() {
        initComponents();
        this.setVisible(false);
        
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            conn=DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=DB_QLDA;"
                    + "username=sa;password=1321");
        }
        catch(Exception e)
        {
            e.printStackTrace();
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

        jLabel1 = new javax.swing.JLabel();
        combox_ls = new javax.swing.JComboBox<>();
        but_moform = new javax.swing.JButton();
        lbl_kq = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        but_thoat = new javax.swing.JButton();
        Quaylai = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 28)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 255));
        jLabel1.setText("Mời Bạn Chọn Form");

        combox_ls.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        combox_ls.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Chủ đầu tư", "Khách hàng", "Thuế", "Dự án", "Khu đất", "Quản lý người dùng", "Khác" }));
        combox_ls.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        combox_ls.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                combox_lsMousePressed(evt);
            }
        });
        combox_ls.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                combox_lsActionPerformed(evt);
            }
        });

        but_moform.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        but_moform.setText("Mở");
        but_moform.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                but_moformMouseClicked(evt);
            }
            public void mousePressed(java.awt.event.MouseEvent evt) {
                but_moformMousePressed(evt);
            }
        });
        but_moform.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_moformActionPerformed(evt);
            }
        });

        lbl_kq.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lbl_kq.setForeground(new java.awt.Color(255, 0, 51));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 30)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(255, 0, 0));
        jLabel2.setText("ĐỒ ÁN HỆ QUẢN TRỊ CSDL + JAVA");

        but_thoat.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        but_thoat.setText("Thoát");
        but_thoat.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                but_thoatMouseClicked(evt);
            }
        });
        but_thoat.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                but_thoatActionPerformed(evt);
            }
        });

        Quaylai.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        Quaylai.setText("Đăng xuất");
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
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGap(0, 11, Short.MAX_VALUE)
                        .addComponent(jLabel2))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(303, 303, 303)
                        .addComponent(lbl_kq, javax.swing.GroupLayout.PREFERRED_SIZE, 192, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addComponent(combox_ls, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(but_moform))
                            .addComponent(jLabel1))
                        .addGap(126, 126, 126))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(Quaylai)
                        .addGap(33, 33, 33)
                        .addComponent(but_thoat, javax.swing.GroupLayout.PREFERRED_SIZE, 83, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(jLabel2)
                .addGap(37, 37, 37)
                .addComponent(jLabel1)
                .addGap(39, 39, 39)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(combox_ls, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(but_moform))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 55, Short.MAX_VALUE)
                .addComponent(lbl_kq)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(but_thoat, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(Quaylai, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGap(1, 1, 1)))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void but_moformActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_moformActionPerformed

    }//GEN-LAST:event_but_moformActionPerformed

    private void but_moformMousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_but_moformMousePressed


    }//GEN-LAST:event_but_moformMousePressed

    private void combox_lsMousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_combox_lsMousePressed

    }//GEN-LAST:event_combox_lsMousePressed

    private void combox_lsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_combox_lsActionPerformed

    }//GEN-LAST:event_combox_lsActionPerformed

    private void but_moformMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_but_moformMouseClicked
        int index=combox_ls.getSelectedIndex();
        String value=combox_ls.getItemAt(index);
        if(value.equals("Dự án")==true)
        {   
            this.setVisible(false);
            DuAn da=new DuAn();
            da.setVisible(true);
            
        }
        else if(value.equals("Chủ đầu tư")==true)
        {   
            this.setVisible(false);
            ChuDauTu cdt=new ChuDauTu();
            cdt.setVisible(true);
            
        }
        else if(value.equals("Khu đất")==true)
        {   
            this.setVisible(false);
            KhuDat kd=new KhuDat();
            kd.setVisible(true);
        }
        else if(value.equals("Thuế")==true)
        {   
            this.setVisible(false);
            Thue t=new Thue();
            t.setVisible(true);
        }
        else if(value.equals("Khách hàng")==true || value.equals("Quản lý người dùng")==true)
        {   
            //---Nếu là người quản trị mới được xem table khách hàng, quản lý người dùng
            String sql="SELECT TK.LOAI FROM SAVE_DANGNHAP SA, TAIKHOAN TK WHERE SA.TEN=TK.TEN";
            try
            {
                PreparedStatement ps=conn.prepareStatement(sql);
                ResultSet rs=ps.executeQuery();
                int kt=0;
                while(rs.next())
                {
                    if(rs.getString(1).equals("Quan_tri"))
                    {
                        kt++;

                    }
                }
                rs.close();
                ps.close();
                
                
                if(kt!=0)
                {
                    this.setVisible(false);
                    if(value.equals("Khách hàng")==true)
                    {
                        KhachHang kh=new KhachHang();
                        kh.setVisible(true);
                    }
                    else
                    {
                        QL_NguoiDung ql=new QL_NguoiDung();
                        ql.setVisible(true);
                    }
                }
                else
                {
                        JOptionPane.showMessageDialog(this, "Chỉ có người quản trị mới được truy cập!");
                }
                
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, "Erro Select Loai From Save_DangNhap!");
                ex.printStackTrace();
            }
            
            
            //-------------------------------------
            
        }
        else
        {
            JOptionPane.showMessageDialog(this, "Trang này không tồn tại!");
        }
    }//GEN-LAST:event_but_moformMouseClicked

    private void but_thoatActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_but_thoatActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_but_thoatActionPerformed

    private void but_thoatMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_but_thoatMouseClicked
        JFrame f=new JFrame("Exit");
        if(JOptionPane.showConfirmDialog(f, "Bạn có muốn thoát chương trình ?", "Thông báo", JOptionPane.YES_NO_OPTION)==JOptionPane.YES_OPTION)
            System.exit(0);
    }//GEN-LAST:event_but_thoatMouseClicked

    private void QuaylaiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_QuaylaiActionPerformed
       String sql2="DELETE FROM SAVE_DANGNHAP";
        try{
            PreparedStatement ps2=conn.prepareStatement(sql2);
            ps2.executeUpdate();
            ps2.close();
            
            this.setVisible(false);
            DangNhap dn=new DangNhap();
            dn.setVisible(true);
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(this, "Lỗi đăng xuất(1)!");
        }
            
    }//GEN-LAST:event_QuaylaiActionPerformed

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
            java.util.logging.Logger.getLogger(ChonLua.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ChonLua.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ChonLua.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ChonLua.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ChonLua().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton Quaylai;
    private javax.swing.JButton but_moform;
    private javax.swing.JButton but_thoat;
    private javax.swing.JComboBox<String> combox_ls;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel lbl_kq;
    // End of variables declaration//GEN-END:variables


   
}
