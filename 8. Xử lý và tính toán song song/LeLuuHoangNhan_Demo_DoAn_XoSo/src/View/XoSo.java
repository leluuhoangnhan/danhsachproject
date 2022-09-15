/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package View;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import static java.lang.Thread.sleep;
import java.util.Date;
import java.util.Locale;
import java.util.Random;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.Timer;
import javax.swing.table.DefaultTableModel;
import modul.DongHo;
import modul.Thread_XoSo;

/**
 *
 * @author LeLuuHoangNhan
 */
public class XoSo extends javax.swing.JFrame {
    Vector td=new Vector();
    Vector nd=new Vector();
    Vector td1=new Vector();
    Vector nd1=new Vector();
    Vector td2=new Vector();
    Vector nd2=new Vector();
    Vector td3=new Vector();
    Vector nd3=new Vector();
    
    int soVeDatMua=-1;
    long soTienTrongVi=0;
    long giaTriTrungThuong=0;
    
    int giaiDD=2000000000;
    int giaiNhat=30000000;
    int giaiNhi=15000000;
    int giaiBa=10000000;
    int giaiTu=3000000;
    int giaiNam=1000000;
    int giaiSau=400000;
    int giaiBay=200000;
    int giaiTam=100000;
    
    
    
    
    public XoSo() {
        initComponents();
        
        txt_soVe.setEnabled(false);
        btn_datMua.setEnabled(false);
        
        txt_so1.setEditable(false);
        txt_so2.setEditable(false);
        txt_so3.setEditable(false);
        txt_so4.setEditable(false);
        txt_so5.setEditable(false);
        txt_so6.setEditable(false);
        
        hienThiVeBan();
        rd_giaiTam.doClick();
        
        td1.add("Số vé");
        td1.add("Số lượng mua");
        tab_veMua.setModel(new DefaultTableModel(nd1,td1));
        
        td2.add("Giải thưởng");
        td2.add("Kết quả");
        tab_ketQua.setModel(new DefaultTableModel(nd2,td2));
        
        td3.add("Số vé");
        td3.add("Số lượng");
        td3.add("Trúng giải");
        td3.add("Giá trị giải thưởng");
        tab_ktTrungThuong.setModel(new DefaultTableModel(nd3,td3));
        
        DongHo dh=new DongHo(15,58,0,lbl_dongHo);
        dh.start();
        
        quayXoSoTuDong();
    }
    
    public XoSo(String soDu) 
    {
        initComponents();
        
        txt_soVe.setEnabled(false);
        btn_datMua.setEnabled(false);
        
        txt_so1.setEditable(false);
        txt_so2.setEditable(false);
        txt_so3.setEditable(false);
        txt_so4.setEditable(false);
        txt_so5.setEditable(false);
        txt_so6.setEditable(false);
        
        hienThiVeBan();
        rd_giaiTam.doClick();
        
        td1.add("Số vé");
        td1.add("Số lượng mua");
        tab_veMua.setModel(new DefaultTableModel(nd1,td1));
        
        td2.add("Giải thưởng");
        td2.add("Kết quả");
        tab_ketQua.setModel(new DefaultTableModel(nd2,td2));
        
        td3.add("Số vé");
        td3.add("Số lượng");
        td3.add("Trúng giải");
        td3.add("Giá trị giải thưởng");
        tab_ktTrungThuong.setModel(new DefaultTableModel(nd3,td3));
        
        DongHo dh=new DongHo(15,58,0,lbl_dongHo);
        dh.start();
        
        quayXoSoTuDong();
        laySoDuTrongVi(soDu);
    }
    
    //Phần mới thêm
    public void laySoDuTrongVi(String soDu)
    {
        if(soDu!=null)
        {
            String tienVi="";
            String []str1=soDu.split("đ");
            String []str2=str1[0].trim().split(",");
            for(int i=0;i<str2.length;i++)
            {
                tienVi+=str2[i];
            }
            soTienTrongVi=Long.parseLong(tienVi);
        }
    }
    
    public int randomSoNgauNhien(int n)
    {
        Date now=new Date();
        Random rd=new Random(now.getTime());
        
        return Math.abs(rd.nextInt())%n;
    }
    
    public String taoVeSo()
    {
        String veSo="";
        for(int i=0;i<6;i++)
        {
            String ve;
            do
            {
                ve=(randomSoNgauNhien(10) + "").trim();
            }while(veSo.contains(ve));
            
            veSo+=ve;
        }
        
        return veSo.trim();
    }
    
    public void taoDSVeSo(int n)
    {
        td.add("Số vé");
        td.add("Số lượng còn");
        tab_veBan.setModel(new DefaultTableModel(nd,td));
        
        for(int i=0;i<n;i++)
        {
            int kt;
            String veSo;
            do
            {
                kt=0;
                veSo=taoVeSo();
                for(int j=0;j<tab_veBan.getRowCount();j++)
                {
                    if(tab_veBan.getValueAt(j,0).toString().equals(veSo))
                    {
                        kt++;
                    }
                }
            }while(kt!=0);
            
            String soLuong=(randomSoNgauNhien(101) + "").trim();
            
            Vector v=new Vector();
            v.add(veSo);
            v.add(soLuong);
            
            nd.add(v);
        }
        tab_veBan.setModel(new DefaultTableModel(nd,td));
    }
    
    public void hienThiVeBan()
    { 
        taoDSVeSo(200);
    }
    
    public String layNSoDuoi(String x, int n)
    {
        return x.substring(x.length()-n, x.length());
    }
   
    public void hienThiVeSoTrung(String soVe, int soLuong, String giaiTrung, int giaTriGiaiThuong)
    {
        Vector t=new Vector();
        t.add(soVe);
        t.add(String.valueOf(soLuong));
        t.add(giaiTrung);
        t.add(String.valueOf(giaTriGiaiThuong));
        
        nd3.add(t);
        tab_ktTrungThuong.setModel(new DefaultTableModel(nd3,td3));
    }
    
    public void doVeSo(int giai, String kqxs)
    {
        for(int i=0;i<tab_veMua.getRowCount();i++)
        {
            switch(giai)
            {
                case 0: //Giải đặc biệt
                {
                    String soVeDaMua=tab_veMua.getValueAt(i, 0).toString();
                    int soLuongDaMua=Integer.parseInt(tab_veMua.getValueAt(i, 1).toString());
                    
                    String soVe=layNSoDuoi(soVeDaMua, 6);
                    if(soVe.equals(kqxs))
                    {
                        hienThiVeSoTrung(soVeDaMua, soLuongDaMua, "Giải đặc biệt", giaiDD);
                        tinhSoVeVaGiaTriTrungThuong(soLuongDaMua,giaiDD * soLuongDaMua);
                    }
                    break;
                }
                case 1: //Giải nhất ...
                {
                    String soVeDaMua=tab_veMua.getValueAt(i, 0).toString();
                    int soLuongDaMua=Integer.parseInt(tab_veMua.getValueAt(i, 1).toString());
                    
                    String soVe=layNSoDuoi(soVeDaMua, 5);
                    if(soVe.equals(kqxs))
                    {
                        hienThiVeSoTrung(soVeDaMua, soLuongDaMua, "Giải nhất", giaiNhat);
                        tinhSoVeVaGiaTriTrungThuong(soLuongDaMua,giaiNhat * soLuongDaMua);
                    }
                    break;
                }
                case 2: 
                {
                    String soVeDaMua=tab_veMua.getValueAt(i, 0).toString();
                    int soLuongDaMua=Integer.parseInt(tab_veMua.getValueAt(i, 1).toString());
                    
                    String soVe=layNSoDuoi(soVeDaMua, 5);
                    if(soVe.equals(kqxs))
                    {
                        hienThiVeSoTrung(soVeDaMua, soLuongDaMua, "Giải nhì", giaiNhi);
                        tinhSoVeVaGiaTriTrungThuong(soLuongDaMua,giaiNhi * soLuongDaMua);
                    }
                    break;
                }
                case 3:
                {
                    String soVeDaMua=tab_veMua.getValueAt(i, 0).toString();
                    int soLuongDaMua=Integer.parseInt(tab_veMua.getValueAt(i, 1).toString());
                    
                    String soVe=layNSoDuoi(soVeDaMua, 5);
                    if(soVe.equals(kqxs))
                    {
                        hienThiVeSoTrung(soVeDaMua, soLuongDaMua, "Giải ba", giaiBa);
                        tinhSoVeVaGiaTriTrungThuong(soLuongDaMua,giaiBa * soLuongDaMua);
                    }
                    break;
                }
                case 4:
                {
                    String soVeDaMua=tab_veMua.getValueAt(i, 0).toString();
                    int soLuongDaMua=Integer.parseInt(tab_veMua.getValueAt(i, 1).toString());
                    
                    String soVe=layNSoDuoi(soVeDaMua, 5);
                    if(soVe.equals(kqxs))
                    {
                        hienThiVeSoTrung(soVeDaMua, soLuongDaMua, "Giải tư", giaiTu);
                        tinhSoVeVaGiaTriTrungThuong(soLuongDaMua,giaiTu * soLuongDaMua);
                    }
                    break;
                }
                case 5:
                {
                    String soVeDaMua=tab_veMua.getValueAt(i, 0).toString();
                    int soLuongDaMua=Integer.parseInt(tab_veMua.getValueAt(i, 1).toString());
                    
                    String soVe=layNSoDuoi(soVeDaMua, 4);
                    if(soVe.equals(kqxs))
                    {
                        hienThiVeSoTrung(soVeDaMua, soLuongDaMua, "Giải năm", giaiNam);
                        tinhSoVeVaGiaTriTrungThuong(soLuongDaMua,giaiNam * soLuongDaMua);
                    }
                    break;
                }
                case 6:
                {
                    String soVeDaMua=tab_veMua.getValueAt(i, 0).toString();
                    int soLuongDaMua=Integer.parseInt(tab_veMua.getValueAt(i, 1).toString());
                    
                    String soVe=layNSoDuoi(soVeDaMua, 4);
                    if(soVe.equals(kqxs))
                    {
                        hienThiVeSoTrung(soVeDaMua, soLuongDaMua, "Giải sáu", giaiSau);
                        tinhSoVeVaGiaTriTrungThuong(soLuongDaMua,giaiSau * soLuongDaMua);
                    }
                    break;
                }
                case 7:
                {
                    String soVeDaMua=tab_veMua.getValueAt(i, 0).toString();
                    int soLuongDaMua=Integer.parseInt(tab_veMua.getValueAt(i, 1).toString());
                    
                    String soVe=layNSoDuoi(soVeDaMua, 3);
                    if(soVe.equals(kqxs))
                    {
                        hienThiVeSoTrung(soVeDaMua, soLuongDaMua, "Giải bảy", giaiBay);
                        tinhSoVeVaGiaTriTrungThuong(soLuongDaMua,giaiBay * soLuongDaMua);
                    }
                    break;
                }
                case 8: //Giải tám
                {
                    String soVeDaMua=tab_veMua.getValueAt(i, 0).toString();
                    int soLuongDaMua=Integer.parseInt(tab_veMua.getValueAt(i, 1).toString());
                    
                    String soVe=layNSoDuoi(soVeDaMua, 2);
                    if(soVe.equals(kqxs))
                    {
                        hienThiVeSoTrung(soVeDaMua, soLuongDaMua, "Giải tám", giaiTam);
                        tinhSoVeVaGiaTriTrungThuong(soLuongDaMua,giaiTam * soLuongDaMua);
                    }
                    break;
                }
            }
        }
    }
    
    public int ktTrungGiai(String tenGiai)
    {
        for(int i=0;i<tab_ketQua.getRowCount();i++)
        {
            if(tab_ketQua.getValueAt(i, 0).toString().equals(tenGiai))
                return i;
        }
        return 0;
    }
    
    public void layKQXS(int i)
    {   
        Vector t=new Vector();
        String kq="";
        int kt=0;
        int giai=-1;
        
        if(i<0 || i>17)
            return;
        else if(i==0)
        {
            t.add("Giải tám");
            kq=txt_so5.getText()+txt_so6.getText();
            t.add(kq);
            giai=8;
        }
        else if(i==1)
        {
            t.add("Giải bảy");
            kq=txt_so4.getText()+txt_so5.getText()+txt_so6.getText();
            t.add(kq);
            giai=7;
        }
        else if(i<=4)
        {
            String tenGiai="Giải sáu";
            kt=ktTrungGiai(tenGiai);
            kq=txt_so3.getText()+txt_so4.getText()+txt_so5.getText()+txt_so6.getText();
            
            t.add(tenGiai);
            t.add(kq);
            giai=6;
        }
        else if(i==5)
        {
            t.add("Giải năm");
            kq=txt_so3.getText()+txt_so4.getText()+txt_so5.getText()+txt_so6.getText();
            t.add(kq);
            giai=5;
        }
        else if(i<=12)
        {
            String tenGiai="Giải tư";
            kt=ktTrungGiai(tenGiai);
            kq=txt_so2.getText()+txt_so3.getText()+txt_so4.getText()+txt_so5.getText()+txt_so6.getText();
            
            t.add(tenGiai);
            t.add(kq);
            giai=4;
        }
        else if(i<=14)
        {
            String tenGiai="Giải ba";
            kt=ktTrungGiai(tenGiai);
            kq=txt_so2.getText()+txt_so3.getText()+txt_so4.getText()+txt_so5.getText()+txt_so6.getText();
            
            t.add(tenGiai);
            t.add(kq);
            giai=3;
        }
        else if(i==15)
        {
            t.add("Giải nhì");
            kq=txt_so2.getText()+txt_so3.getText()+txt_so4.getText()+txt_so5.getText()+txt_so6.getText();
            t.add(kq);
            giai=2;
        }
        else if(i==16)
        {
            t.add("Giải nhất");
            kq=txt_so2.getText()+txt_so3.getText()+txt_so4.getText()+txt_so5.getText()+txt_so6.getText();
            t.add(kq);
            giai=1;
        }
        else
        {
            t.add("Giải đặc biệt");
            kq=txt_so1.getText()+txt_so2.getText()+txt_so3.getText()+txt_so4.getText()+txt_so5.getText()+txt_so6.getText();
            t.add(kq);
            giai=0;
        }
        
        if(kt!=0) //Giải thứ n trong giải thứ k(K là các giải tám, bảy, ....)
        {
            tab_ketQua.setValueAt((String)tab_ketQua.getValueAt(kt, 1) + "-" + kq, kt, 1);
        }
        else
        {
            nd2.add(t);
        }
        
        tab_ketQua.setModel(new DefaultTableModel(nd2,td2));
        doVeSo(giai, kq);
    }
    
    
    public void tinhSoVeVaGiaTriTrungThuong(int soVeTrung, int giaTriTrung)
    {
        int soVeHT=Integer.parseInt(txt_tongVeTrung.getText());
        giaTriTrungThuong += giaTriTrung;
        
        txt_tongVeTrung.setText(String.valueOf(soVeHT + soVeTrung));
        txt_tongGiaTriTrung.setText(String.format("%,d", giaTriTrungThuong));
        soTienTrongVi += giaTriTrung;
    }
    
    public void ktDSVeSoTrungThuong()
    {
        if(nd3.isEmpty()==true)
        {
            hienThiVeSoTrung("0",0,"Không có",0);
        }
        
        JOptionPane.showMessageDialog(this, "CẢM ƠN BẠN ĐÃ TIN TƯỞNG VÀ SỬ DỤNG ỨNG DỤNG QUAY XỔ SỐ CỦA 'LELUUHOANGNHAN.COM' => XIN CHÀO VÀ HẸN GẶP LẠI!");
    }
    
    public int xuLiVeDaMuaTrung(String soVe, int soLuong)
    {
        for(int i=0;i<tab_veMua.getRowCount();i++)
        {
            if(tab_veMua.getValueAt(i, 0).toString().equals(soVe))
            {
                int soLuongHT = Integer.parseInt(tab_veMua.getValueAt(i, 1).toString()) + soLuong;
                tab_veMua.setValueAt(String.valueOf(soLuongHT), i, 1);
                return 1;
            }
        }
        return 0;
    }
    
    public void batDauQuayXoSo()
    {
        btn_datMua.setEnabled(false);
        btn_muaHet.setEnabled(false);
        btn_batDau.setEnabled(false);
        
        Timer timer = new Timer(20000, new ActionListener() {
          int i=0;
          public void actionPerformed(ActionEvent arg0) {
            if(i<=17)
            {
                taoVongQuay(i);
            }
            i++;
          }

        });
        
        timer.setRepeats(true);
        timer.start();
    }
    
    public void quayXoSoTuDong()
    {
        Timer timer = new Timer(1000, new ActionListener() {
          public void actionPerformed(ActionEvent arg0) {
            if(btn_batDau.isEnabled()==true && lbl_dongHo.getText().toString().equals("15:59:50"))
            {
                batDauQuayXoSo();
            }
          }
        });
        
        timer.setRepeats(true);
        timer.start();
    }
    
    //End phần mới thêm
   


    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jTextField6 = new javax.swing.JTextField();
        buttonGroup1 = new javax.swing.ButtonGroup();
        jLabel1 = new javax.swing.JLabel();
        jPanel1 = new javax.swing.JPanel();
        txt_so2 = new javax.swing.JTextField();
        txt_so1 = new javax.swing.JTextField();
        txt_so3 = new javax.swing.JTextField();
        txt_so4 = new javax.swing.JTextField();
        txt_so5 = new javax.swing.JTextField();
        txt_so6 = new javax.swing.JTextField();
        btn_batDau = new javax.swing.JButton();
        rd_giaiTam = new javax.swing.JRadioButton();
        rd_giaiBay = new javax.swing.JRadioButton();
        rd_giaiSau = new javax.swing.JRadioButton();
        rd_giaiNam = new javax.swing.JRadioButton();
        rd_giaiTu = new javax.swing.JRadioButton();
        rd_giaiBa = new javax.swing.JRadioButton();
        rd_giaiNhi = new javax.swing.JRadioButton();
        rd_giaiNhat = new javax.swing.JRadioButton();
        rd_giaiDacBiet = new javax.swing.JRadioButton();
        jPanel2 = new javax.swing.JPanel();
        rd_datMua = new javax.swing.JRadioButton();
        jLabel2 = new javax.swing.JLabel();
        txt_soVe = new javax.swing.JTextField();
        btn_datMua = new javax.swing.JButton();
        spin_soLuong = new javax.swing.JSpinner();
        jLabel7 = new javax.swing.JLabel();
        jLabel9 = new javax.swing.JLabel();
        btn_lamMoi = new javax.swing.JButton();
        jLabel25 = new javax.swing.JLabel();
        jScrollPane3 = new javax.swing.JScrollPane();
        tab_veBan = new javax.swing.JTable();
        jScrollPane4 = new javax.swing.JScrollPane();
        tab_veMua = new javax.swing.JTable();
        btn_muaHet = new javax.swing.JButton();
        jPanel3 = new javax.swing.JPanel();
        jLabel3 = new javax.swing.JLabel();
        jScrollPane5 = new javax.swing.JScrollPane();
        tab_ketQua = new javax.swing.JTable();
        jPanel4 = new javax.swing.JPanel();
        jScrollPane2 = new javax.swing.JScrollPane();
        tab_ktTrungThuong = new javax.swing.JTable();
        jLabel22 = new javax.swing.JLabel();
        jLabel23 = new javax.swing.JLabel();
        txt_tongVeTrung = new javax.swing.JTextField();
        txt_tongGiaTriTrung = new javax.swing.JTextField();
        jLabel24 = new javax.swing.JLabel();
        jLabel26 = new javax.swing.JLabel();
        btn_thoat = new javax.swing.JButton();
        btn_reset = new javax.swing.JButton();
        jLabel5 = new javax.swing.JLabel();
        btn_quayLai = new javax.swing.JButton();
        lbl_dongHo = new javax.swing.JLabel();
        lbl_thu = new javax.swing.JLabel();

        jTextField6.setText("jTextField1");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 32)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(255, 51, 51));
        jLabel1.setText("Vé Số Online 4.0");

        txt_so2.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        txt_so2.setForeground(new java.awt.Color(51, 51, 255));

        txt_so1.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        txt_so1.setForeground(new java.awt.Color(51, 51, 255));

        txt_so3.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        txt_so3.setForeground(new java.awt.Color(51, 51, 255));

        txt_so4.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        txt_so4.setForeground(new java.awt.Color(51, 51, 255));

        txt_so5.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        txt_so5.setForeground(new java.awt.Color(51, 51, 255));

        txt_so6.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        txt_so6.setForeground(new java.awt.Color(51, 51, 255));

        btn_batDau.setBackground(new java.awt.Color(51, 255, 102));
        btn_batDau.setFont(new java.awt.Font("Tahoma", 1, 16)); // NOI18N
        btn_batDau.setText("Bắt đầu quay xổ số");
        btn_batDau.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_batDauActionPerformed(evt);
            }
        });

        buttonGroup1.add(rd_giaiTam);
        rd_giaiTam.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        rd_giaiTam.setText("Giải tám");

        buttonGroup1.add(rd_giaiBay);
        rd_giaiBay.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        rd_giaiBay.setText("Giải bảy");

        buttonGroup1.add(rd_giaiSau);
        rd_giaiSau.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        rd_giaiSau.setText("Giải sáu");

        buttonGroup1.add(rd_giaiNam);
        rd_giaiNam.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        rd_giaiNam.setText("Giải năm");

        buttonGroup1.add(rd_giaiTu);
        rd_giaiTu.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        rd_giaiTu.setText("Giải tư");

        buttonGroup1.add(rd_giaiBa);
        rd_giaiBa.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        rd_giaiBa.setText("Giải ba");

        buttonGroup1.add(rd_giaiNhi);
        rd_giaiNhi.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        rd_giaiNhi.setText("Giải nhì");

        buttonGroup1.add(rd_giaiNhat);
        rd_giaiNhat.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        rd_giaiNhat.setText("Giải nhất");

        buttonGroup1.add(rd_giaiDacBiet);
        rd_giaiDacBiet.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        rd_giaiDacBiet.setText("Giải đặc biệt");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(36, 36, 36)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(rd_giaiTam)
                                    .addComponent(rd_giaiTu))
                                .addGap(31, 31, 31)
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(rd_giaiBay)
                                    .addComponent(rd_giaiBa))
                                .addGap(33, 33, 33)
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(rd_giaiSau)
                                    .addComponent(rd_giaiNhi))
                                .addGap(33, 33, 33)
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(jPanel1Layout.createSequentialGroup()
                                        .addComponent(rd_giaiNam)
                                        .addGap(30, 30, 30)
                                        .addComponent(rd_giaiDacBiet))
                                    .addComponent(rd_giaiNhat)))
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addComponent(txt_so1, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(37, 37, 37)
                                .addComponent(txt_so2, javax.swing.GroupLayout.PREFERRED_SIZE, 44, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(43, 43, 43)
                                .addComponent(txt_so3, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(38, 38, 38)
                                .addComponent(txt_so4, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(36, 36, 36)
                                .addComponent(txt_so5, javax.swing.GroupLayout.PREFERRED_SIZE, 47, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(35, 35, 35)
                                .addComponent(txt_so6, javax.swing.GroupLayout.PREFERRED_SIZE, 47, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(166, 166, 166)
                        .addComponent(btn_batDau, javax.swing.GroupLayout.PREFERRED_SIZE, 209, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(22, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_so2, javax.swing.GroupLayout.PREFERRED_SIZE, 63, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txt_so3, javax.swing.GroupLayout.PREFERRED_SIZE, 63, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txt_so4, javax.swing.GroupLayout.PREFERRED_SIZE, 63, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txt_so5, javax.swing.GroupLayout.PREFERRED_SIZE, 63, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txt_so6, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txt_so1, javax.swing.GroupLayout.PREFERRED_SIZE, 63, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 44, Short.MAX_VALUE)
                .addComponent(btn_batDau, javax.swing.GroupLayout.PREFERRED_SIZE, 39, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(rd_giaiNam)
                    .addComponent(rd_giaiSau)
                    .addComponent(rd_giaiBay)
                    .addComponent(rd_giaiTam)
                    .addComponent(rd_giaiDacBiet))
                .addGap(18, 18, 18)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(rd_giaiTu)
                    .addComponent(rd_giaiBa)
                    .addComponent(rd_giaiNhi)
                    .addComponent(rd_giaiNhat))
                .addContainerGap())
        );

        rd_datMua.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        rd_datMua.setText("Đặt mua vé");
        rd_datMua.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rd_datMuaActionPerformed(evt);
            }
        });

        jLabel2.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        jLabel2.setText("Số vé");

        txt_soVe.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        txt_soVe.setEnabled(false);

        btn_datMua.setBackground(new java.awt.Color(255, 255, 0));
        btn_datMua.setFont(new java.awt.Font("Tahoma", 1, 13)); // NOI18N
        btn_datMua.setForeground(new java.awt.Color(255, 0, 0));
        btn_datMua.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/icon-cong.png"))); // NOI18N
        btn_datMua.setText("Đặt mua");
        btn_datMua.setEnabled(false);
        btn_datMua.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_datMuaActionPerformed(evt);
            }
        });

        spin_soLuong.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        spin_soLuong.setEnabled(false);

        jLabel7.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        jLabel7.setText("Số lượng cần mua");

        jLabel9.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel9.setText("Vé đang bán");

        btn_lamMoi.setBackground(new java.awt.Color(51, 51, 255));
        btn_lamMoi.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btn_lamMoi.setForeground(new java.awt.Color(255, 255, 255));
        btn_lamMoi.setText("Đổi số");
        btn_lamMoi.setEnabled(false);
        btn_lamMoi.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_lamMoiActionPerformed(evt);
            }
        });

        jLabel25.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel25.setText("Vé đã mua");

        tab_veBan.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        tab_veBan.setEnabled(false);
        tab_veBan.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                tab_veBanMousePressed(evt);
            }
        });
        jScrollPane3.setViewportView(tab_veBan);

        tab_veMua.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        tab_veMua.setEnabled(false);
        tab_veMua.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                tab_veMuaMousePressed(evt);
            }
        });
        jScrollPane4.setViewportView(tab_veMua);

        btn_muaHet.setBackground(new java.awt.Color(255, 51, 51));
        btn_muaHet.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btn_muaHet.setForeground(new java.awt.Color(255, 255, 0));
        btn_muaHet.setText("Mua hết");
        btn_muaHet.setEnabled(false);
        btn_muaHet.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_muaHetActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addComponent(jLabel2)
                                .addGap(18, 18, 18)
                                .addComponent(txt_soVe, javax.swing.GroupLayout.PREFERRED_SIZE, 153, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jLabel7)
                                .addGap(23, 23, 23))
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addComponent(jLabel9)
                                .addGap(13, 13, 13)
                                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(jPanel2Layout.createSequentialGroup()
                                        .addGap(2, 2, 2)
                                        .addComponent(btn_lamMoi, javax.swing.GroupLayout.PREFERRED_SIZE, 88, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(18, 18, 18)
                                        .addComponent(btn_muaHet, javax.swing.GroupLayout.PREFERRED_SIZE, 88, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(jPanel2Layout.createSequentialGroup()
                                        .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 194, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(28, 28, 28)
                                        .addComponent(jLabel25)))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)))
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addComponent(spin_soLuong, javax.swing.GroupLayout.PREFERRED_SIZE, 71, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(btn_datMua))
                            .addComponent(jScrollPane4, javax.swing.GroupLayout.PREFERRED_SIZE, 205, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addComponent(rd_datMua)
                        .addGap(215, 215, 215)))
                .addGap(22, 22, 22))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(rd_datMua)
                .addGap(24, 24, 24)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addComponent(jLabel25)
                                .addGap(0, 97, Short.MAX_VALUE))
                            .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(btn_lamMoi)
                            .addComponent(btn_muaHet)))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel9)
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addComponent(jScrollPane4, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(txt_soVe, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btn_datMua)
                    .addComponent(jLabel7)
                    .addComponent(spin_soLuong, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(29, 29, 29))
        );

        jPanel3.setForeground(new java.awt.Color(51, 51, 255));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel3.setText("Kết quả xổ số");

        tab_ketQua.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        tab_ketQua.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        jScrollPane5.setViewportView(tab_ketQua);

        javax.swing.GroupLayout jPanel3Layout = new javax.swing.GroupLayout(jPanel3);
        jPanel3.setLayout(jPanel3Layout);
        jPanel3Layout.setHorizontalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGap(193, 193, 193)
                .addComponent(jLabel3)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane5, javax.swing.GroupLayout.DEFAULT_SIZE, 502, Short.MAX_VALUE)
                .addContainerGap())
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jScrollPane5, javax.swing.GroupLayout.PREFERRED_SIZE, 181, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        tab_ktTrungThuong.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        tab_ktTrungThuong.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        jScrollPane2.setViewportView(tab_ktTrungThuong);

        jLabel22.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        jLabel22.setText("Tổng vé trúng");

        jLabel23.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        jLabel23.setText("Tổng giá trị trúng thưởng");

        txt_tongVeTrung.setFont(new java.awt.Font("Tahoma", 1, 16)); // NOI18N
        txt_tongVeTrung.setText("0");
        txt_tongVeTrung.setEnabled(false);

        txt_tongGiaTriTrung.setFont(new java.awt.Font("Tahoma", 1, 16)); // NOI18N
        txt_tongGiaTriTrung.setForeground(new java.awt.Color(255, 0, 0));
        txt_tongGiaTriTrung.setText("0");
        txt_tongGiaTriTrung.setEnabled(false);

        jLabel24.setFont(new java.awt.Font("Tahoma", 0, 13)); // NOI18N
        jLabel24.setText("Kết quả sau khi dò");

        jLabel26.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel26.setText("Danh sách vé số trúng thưởng");

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addGap(33, 33, 33)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jScrollPane2)
                    .addGroup(jPanel4Layout.createSequentialGroup()
                        .addComponent(jLabel22)
                        .addGap(18, 18, 18)
                        .addComponent(txt_tongVeTrung, javax.swing.GroupLayout.PREFERRED_SIZE, 87, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(34, 34, 34)
                        .addComponent(jLabel23)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(txt_tongGiaTriTrung)))
                .addGap(17, 17, 17))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                        .addComponent(jLabel26)
                        .addGap(151, 151, 151))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                        .addComponent(jLabel24)
                        .addGap(229, 229, 229))))
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addGap(12, 12, 12)
                .addComponent(jLabel26)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jLabel24, javax.swing.GroupLayout.PREFERRED_SIZE, 14, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel22)
                    .addComponent(txt_tongVeTrung, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel23)
                    .addComponent(txt_tongGiaTriTrung, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(23, Short.MAX_VALUE))
        );

        btn_thoat.setBackground(new java.awt.Color(0, 0, 0));
        btn_thoat.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btn_thoat.setForeground(new java.awt.Color(255, 255, 255));
        btn_thoat.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/icon-x.png"))); // NOI18N
        btn_thoat.setText("Thoát");
        btn_thoat.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                btn_thoatMouseClicked(evt);
            }
        });

        btn_reset.setBackground(new java.awt.Color(0, 0, 0));
        btn_reset.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btn_reset.setForeground(new java.awt.Color(255, 255, 255));
        btn_reset.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/icon-dong-bo.png"))); // NOI18N
        btn_reset.setText("Reset form");
        btn_reset.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                btn_resetMouseClicked(evt);
            }
        });

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(255, 153, 0));
        jLabel5.setText("@Nhóm 02 - DA XL & TTSS ");

        btn_quayLai.setBackground(new java.awt.Color(0, 0, 0));
        btn_quayLai.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btn_quayLai.setForeground(new java.awt.Color(255, 255, 255));
        btn_quayLai.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/icon-quayLai.png"))); // NOI18N
        btn_quayLai.setText("Quay lại");
        btn_quayLai.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                btn_quayLaiMouseClicked(evt);
            }
        });

        lbl_dongHo.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        lbl_dongHo.setForeground(new java.awt.Color(255, 0, 51));
        lbl_dongHo.setText("ĐỒNG HỒ...");

        lbl_thu.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        lbl_thu.setForeground(new java.awt.Color(255, 0, 51));
        lbl_thu.setText("Thứ 2, 25/10/2021");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(jLabel1)
                        .addGap(238, 238, 238)
                        .addComponent(jLabel5))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                .addGap(71, 71, 71)
                                .addComponent(lbl_thu)
                                .addGap(82, 82, 82)
                                .addComponent(lbl_dongHo, javax.swing.GroupLayout.PREFERRED_SIZE, 162, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(jPanel4, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                                .addGap(0, 0, Short.MAX_VALUE))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addGap(0, 0, Short.MAX_VALUE)
                                .addComponent(btn_quayLai, javax.swing.GroupLayout.PREFERRED_SIZE, 148, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(42, 42, 42)
                                .addComponent(btn_reset, javax.swing.GroupLayout.PREFERRED_SIZE, 148, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(35, 35, 35)
                                .addComponent(btn_thoat, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(jLabel5))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(18, 18, 18)
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(18, 18, 18)
                        .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jPanel4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(btn_reset)
                        .addComponent(btn_thoat)
                        .addComponent(btn_quayLai))
                    .addComponent(lbl_dongHo)
                    .addComponent(lbl_thu))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents
    public void quayGiaiTam(int k)
    {
        Thread_XoSo t6=new Thread_XoSo(txt_so6,100);
        Thread_XoSo t5=new Thread_XoSo(txt_so5,200);
        t6.start();
        t5.start();
        
        
        Thread t7=new Thread(){
            public void run()
            {
                try {
                    sleep(7000);
                    layKQXS(k);
//                    JOptionPane.showMessageDialog(rootPane,"Đã quay xong!");
                } catch (InterruptedException ex) {
                    Logger.getLogger(XoSo.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        };t7.start();
    }
    
    public void quayGiaiBay(int k)
    {
        Thread_XoSo t6=new Thread_XoSo(txt_so6,100);
        Thread_XoSo t5=new Thread_XoSo(txt_so5,200);
        Thread_XoSo t4=new Thread_XoSo(txt_so4,300);
        t6.start();
        t5.start();
        t4.start();
        
        
        Thread t7=new Thread(){
            public void run()
            {
                try {
                    sleep(10000);
                    layKQXS(k);
//                    JOptionPane.showMessageDialog(rootPane,"Đã quay xong!");
                } catch (InterruptedException ex) {
                    Logger.getLogger(XoSo.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        };t7.start();
    }
    
    public void quayGiaiSau_Nam(int k)
    {
        Thread_XoSo t6=new Thread_XoSo(txt_so6,100);
        Thread_XoSo t5=new Thread_XoSo(txt_so5,200);
        Thread_XoSo t4=new Thread_XoSo(txt_so4,300);
        Thread_XoSo t3=new Thread_XoSo(txt_so3,400);
        t6.start();
        t5.start();
        t4.start();
        t3.start();
        
        
        Thread t7=new Thread(){
            public void run()
            {
                try {
                    sleep(14000);
                    layKQXS(k);
//                    JOptionPane.showMessageDialog(rootPane,"Đã quay xong!");
                } catch (InterruptedException ex) {
                    Logger.getLogger(XoSo.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        };t7.start();
    }
    
    public void quayGiaiTu_Ba_Nhi_Nhat(int k)
    {
        Thread_XoSo t6=new Thread_XoSo(txt_so6,100);
        Thread_XoSo t5=new Thread_XoSo(txt_so5,200);
        Thread_XoSo t4=new Thread_XoSo(txt_so4,300);
        Thread_XoSo t3=new Thread_XoSo(txt_so3,400);
        Thread_XoSo t2=new Thread_XoSo(txt_so2,500);
        t6.start();
        t5.start();
        t4.start();
        t3.start();
        t2.start();
        
        
        Thread t7=new Thread(){
            public void run()
            {
                try {
                    sleep(17000);
                    layKQXS(k);
//                    JOptionPane.showMessageDialog(rootPane,"Đã quay xong!");
                } catch (InterruptedException ex) {
                    Logger.getLogger(XoSo.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        };t7.start();
    }
    
    public void quayGiaiDacBiet(int k)
    {
        Thread_XoSo t6=new Thread_XoSo(txt_so6,100);
        Thread_XoSo t5=new Thread_XoSo(txt_so5,200);
        Thread_XoSo t4=new Thread_XoSo(txt_so4,300);
        Thread_XoSo t3=new Thread_XoSo(txt_so3,400);
        Thread_XoSo t2=new Thread_XoSo(txt_so2,500);
        Thread_XoSo t1=new Thread_XoSo(txt_so1,600);
        t6.start();
        t5.start();
        t4.start();
        t3.start();
        t2.start();
        t1.start();
        
        
        Thread t7=new Thread(){
            public void run()
            {
                try {
                    sleep(20000);
                    layKQXS(k);
                    ktDSVeSoTrungThuong();
//                    JOptionPane.showMessageDialog(rootPane,"Đã quay xong!");
                } catch (InterruptedException ex) {
                    Logger.getLogger(XoSo.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        };t7.start();
    }
    
    public void taoVongQuay(int lanQuay)
    {
        int i = lanQuay;
        
        if(i==0)
        {
            rd_giaiTam.doClick();
            txt_so4.setText("");
            txt_so3.setText("");
            txt_so2.setText("");
            txt_so1.setText("");
            quayGiaiTam(i);
        }
        else if(i==1)
        {
            txt_so3.setText("");
            txt_so2.setText("");
            txt_so1.setText("");
            rd_giaiBay.doClick();
            quayGiaiBay(i);
        }
        else if(i==2)
        {
            txt_so2.setText("");
            txt_so1.setText("");
            rd_giaiSau.doClick();
            quayGiaiSau_Nam(i);
        }
        else if(i==3)
        {
            txt_so2.setText("");
            txt_so1.setText("");
            rd_giaiSau.doClick();
            quayGiaiSau_Nam(i);
        }
        else if(i==4)
        {
            txt_so2.setText("");
            txt_so1.setText("");
            rd_giaiSau.doClick();
            quayGiaiSau_Nam(i);
        }
        else if(i==5)
        {
            txt_so2.setText("");
            txt_so1.setText("");
            rd_giaiNam.doClick();
            quayGiaiSau_Nam(i);
        }
        else if(i==6)
        {
            txt_so1.setText("");
            rd_giaiTu.doClick();
            quayGiaiTu_Ba_Nhi_Nhat(i);
        }
        else if(i==7)
        {
            txt_so1.setText("");
            rd_giaiTu.doClick();
            quayGiaiTu_Ba_Nhi_Nhat(i);
        }
        else if(i==8)
        {
            txt_so1.setText("");
            rd_giaiTu.doClick();
            quayGiaiTu_Ba_Nhi_Nhat(i);
        }
        else if(i==9)
        {
            txt_so1.setText("");
            rd_giaiTu.doClick();
            quayGiaiTu_Ba_Nhi_Nhat(i);
        }
        else if(i==10)
        {
            txt_so1.setText("");
            rd_giaiTu.doClick();
            quayGiaiTu_Ba_Nhi_Nhat(i);
        }
        else if(i==11)
        {
            txt_so1.setText("");
            rd_giaiTu.doClick();
            quayGiaiTu_Ba_Nhi_Nhat(i);
        }
        else if(i==12)
        {
            txt_so1.setText("");
            rd_giaiTu.doClick();
            quayGiaiTu_Ba_Nhi_Nhat(i);
        }
        else if(i==13)
        {
            txt_so1.setText("");
            rd_giaiBa.doClick();
            quayGiaiTu_Ba_Nhi_Nhat(i);
        }
        else if(i==14)
        {
            txt_so1.setText("");
            rd_giaiBa.doClick();
            quayGiaiTu_Ba_Nhi_Nhat(i);
        }
        else if(i==15)
        {
            txt_so1.setText("");
            rd_giaiNhi.doClick();
            quayGiaiTu_Ba_Nhi_Nhat(i);
        }
        else if(i==16)
        {
            txt_so1.setText("");
            rd_giaiNhat.doClick();
            quayGiaiTu_Ba_Nhi_Nhat(i);
        }
        else
        {
            rd_giaiDacBiet.doClick();
            quayGiaiDacBiet(i);
        }
    }
    
    private void btn_batDauActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_batDauActionPerformed
        batDauQuayXoSo();
    }//GEN-LAST:event_btn_batDauActionPerformed

    private void rd_datMuaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rd_datMuaActionPerformed
        tab_veBan.setEnabled(true);
        btn_lamMoi.setEnabled(true);
        btn_muaHet.setEnabled(true);
    }//GEN-LAST:event_rd_datMuaActionPerformed

    private void btn_thoatMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btn_thoatMouseClicked
        JFrame f=new JFrame("Exit");
        if(JOptionPane.showConfirmDialog(f, "Bạn có muốn thoát chương trình ?", "Thông báo", JOptionPane.YES_NO_OPTION)==JOptionPane.YES_OPTION)
            System.exit(0);
    }//GEN-LAST:event_btn_thoatMouseClicked

    private void btn_datMuaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_datMuaActionPerformed
        int soLuongCanMua=Integer.parseInt(spin_soLuong.getValue().toString());
        if(soLuongCanMua<=0)
        {
            JOptionPane.showMessageDialog(this, "Số lượng cần mua không hợp lệ!!!");
            return;
        }
        int row=tab_veBan.getSelectedRow();
        int maxSLCon=Integer.parseInt((String)tab_veBan.getValueAt(row, 1));
                
        if(soLuongCanMua>maxSLCon)
        {
            JOptionPane.showMessageDialog(this, "Số lượng còn ít hơn số vé cần mua =>> Vui lòng mua ít lại!!!");
        }
        else
        {
            long tongTienVeCanMua = soLuongCanMua*10000;
            if(tongTienVeCanMua>soTienTrongVi)
            {
                JOptionPane.showMessageDialog(this, "Số tiền trong ví không đủ thanh toán. => Số tiền trong ví chỉ còn " + String.format("%,d", soTienTrongVi) + " đ");
                return;
            }
            
            int soLuongVeConLai=maxSLCon-soLuongCanMua;
            tab_veBan.setValueAt(soLuongVeConLai+"", row, 1);
            
            int kt = xuLiVeDaMuaTrung(txt_soVe.getText(), Integer.parseInt(spin_soLuong.getValue().toString()));
            if (kt==0)
            {
                Vector t=new Vector();
                t.add(txt_soVe.getText());
                t.add(spin_soLuong.getValue());
                nd1.add(t);
            }
            tab_veMua.setModel(new DefaultTableModel(nd1,td1));
            tab_veBan.setModel(new DefaultTableModel(nd,td));
            
            soVeDatMua++;
            soTienTrongVi-= tongTienVeCanMua;
            JOptionPane.showMessageDialog(this, "Đặt mua vé thành công!");
        }
    }//GEN-LAST:event_btn_datMuaActionPerformed

    private void btn_resetMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btn_resetMouseClicked
        this.setVisible(false);
        XoSo xs=new XoSo();
        xs.setVisible(true);
    }//GEN-LAST:event_btn_resetMouseClicked

    private void btn_lamMoiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_lamMoiActionPerformed
        td.clear();
        nd.clear();
        taoDSVeSo(200);
        tab_veBan.setModel(new DefaultTableModel(nd,td));
    }//GEN-LAST:event_btn_lamMoiActionPerformed

    private void tab_veBanMousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tab_veBanMousePressed
        int row=tab_veBan.getSelectedRow();
        txt_soVe.setText((String) tab_veBan.getValueAt(row, 0));
        spin_soLuong.setValue(Integer.parseInt((String)tab_veBan.getValueAt(row, 1)));
        
        spin_soLuong.setEnabled(true);
        tab_veMua.setEnabled(true);
        if(btn_muaHet.isEnabled()==true)
            btn_datMua.setEnabled(true);
    }//GEN-LAST:event_tab_veBanMousePressed

    private void tab_veMuaMousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tab_veMuaMousePressed
        int row=tab_veMua.getSelectedRow();
        txt_soVe.setText((String)tab_veMua.getValueAt(row, 0));
    }//GEN-LAST:event_tab_veMuaMousePressed

    private void btn_muaHetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_muaHetActionPerformed
        for(int i=0;i<tab_veBan.getRowCount();i++)
        {
            String soVe=tab_veBan.getValueAt(i, 0).toString();
            String soLuong=tab_veBan.getValueAt(i, 1).toString();
            
            if((Long.parseLong(soLuong) * 10000) > soTienTrongVi)
            {
                JOptionPane.showMessageDialog(this, "Số tiền trong ví không đủ thanh toán. => Số tiền trong ví chỉ còn " + String.format("%,d", soTienTrongVi) + " đ");
                tab_veBan.setModel(new DefaultTableModel(nd,td));
                tab_veMua.setModel(new DefaultTableModel(nd1,td1));
                return;
            }
            
            soTienTrongVi -= (Long.parseLong(soLuong) * 10000);
           
            Vector t=new Vector();
            t.add(soVe);
            t.add(soLuong);
            
            int kt = xuLiVeDaMuaTrung(soVe, Integer.parseInt(soLuong));
            if(kt==0)
                nd1.add(t);
            
            tab_veBan.setValueAt("0", i, 1);
        }
        tab_veBan.setModel(new DefaultTableModel(nd,td));
        tab_veMua.setModel(new DefaultTableModel(nd1,td1));
    }//GEN-LAST:event_btn_muaHetActionPerformed

    private void btn_quayLaiMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btn_quayLaiMouseClicked
        NguoiDung nd=new NguoiDung(soTienTrongVi);
        nd.setVisible(true);
//        JOptionPane.showMessageDialog(rootPane, soTienTrongVi + "");
    }//GEN-LAST:event_btn_quayLaiMouseClicked

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
            java.util.logging.Logger.getLogger(XoSo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(XoSo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(XoSo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(XoSo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new XoSo().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btn_batDau;
    private javax.swing.JButton btn_datMua;
    private javax.swing.JButton btn_lamMoi;
    private javax.swing.JButton btn_muaHet;
    private javax.swing.JButton btn_quayLai;
    private javax.swing.JButton btn_reset;
    private javax.swing.JButton btn_thoat;
    private javax.swing.ButtonGroup buttonGroup1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel22;
    private javax.swing.JLabel jLabel23;
    private javax.swing.JLabel jLabel24;
    private javax.swing.JLabel jLabel25;
    private javax.swing.JLabel jLabel26;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JScrollPane jScrollPane4;
    private javax.swing.JScrollPane jScrollPane5;
    private javax.swing.JTextField jTextField6;
    private javax.swing.JLabel lbl_dongHo;
    private javax.swing.JLabel lbl_thu;
    private javax.swing.JRadioButton rd_datMua;
    private javax.swing.JRadioButton rd_giaiBa;
    private javax.swing.JRadioButton rd_giaiBay;
    private javax.swing.JRadioButton rd_giaiDacBiet;
    private javax.swing.JRadioButton rd_giaiNam;
    private javax.swing.JRadioButton rd_giaiNhat;
    private javax.swing.JRadioButton rd_giaiNhi;
    private javax.swing.JRadioButton rd_giaiSau;
    private javax.swing.JRadioButton rd_giaiTam;
    private javax.swing.JRadioButton rd_giaiTu;
    private javax.swing.JSpinner spin_soLuong;
    private javax.swing.JTable tab_ketQua;
    private javax.swing.JTable tab_ktTrungThuong;
    private javax.swing.JTable tab_veBan;
    private javax.swing.JTable tab_veMua;
    private javax.swing.JTextField txt_so1;
    private javax.swing.JTextField txt_so2;
    private javax.swing.JTextField txt_so3;
    private javax.swing.JTextField txt_so4;
    private javax.swing.JTextField txt_so5;
    private javax.swing.JTextField txt_so6;
    private javax.swing.JTextField txt_soVe;
    private javax.swing.JTextField txt_tongGiaTriTrung;
    private javax.swing.JTextField txt_tongVeTrung;
    // End of variables declaration//GEN-END:variables
}
