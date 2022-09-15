/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modul;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Scanner;
import java.util.Set;

/**
 *
 * @author LeLuuHoangNhan
 */
public class ListDinh {
    List <Dinh> ls=new ArrayList<>();

    
    public void nhapListDinh()
    {
        Scanner sc=new Scanner(System.in);
        int n;
        System.out.println("Nhap so luong dinh: ");
        n=sc.nextInt();
        for (int i=0;i<n;i++)
        {
            Dinh d=new Dinh();
            int ktDinh;
            do
            {
                d.nhapDinh();
                ktDinh=checkDinhExits(d);
                if((d.getBac()>=n))
                {
                    System.out.println("So luong dinh khong chinh xac, vui long nhap lai nhe !!!");
                }
                if(ktDinh==1)
                {
                    System.out.println("Dinh ban vua nhap da ton tai, vui long nhap lai nhe !!!");
                }
            }while(d.getBac()>=n || ktDinh==1);
            ls.add(d);
        }
        

        if(ls!=null)
        {
            int index=0;
            for(Dinh x: ls)
            {
                System.out.println("Nhap thong tin dinh " + ls.get(index).getTenDinh() + " : ");
                String[] tenDLQ = new String[x.getBac()];
                String tam;
                for(int i=0;i<x.getBac();i++)
                {
                    do
                    {
                        System.out.println("Nhap ten dinh lien quan thu " + (i+1) + " : ");
                        tam=sc.next();
                    }while(tam.equals(x.getTenDinh())==true || checkTenDinhExists(tam)==false ||checkElementExitsMang(tenDLQ,tam)==1);
                    tenDLQ[i]=tam;
                }
                x.setDinhLQ(tenDLQ);
                ls.set(index, x);
                index++;
            }
        }
        

    }
//  Kiểm tra tên đỉnh đã tồn tại hay chưa
    public boolean checkTenDinhExists(String x)
    {
        for(Dinh d : ls)
        {
            if(d.getTenDinh().equals(x)==true)
                return true;
        }
        return false;
    }
    
    // Kiểm tra đỉnh liên quan nhập có trùng không
    public int checkElementExitsMang(String[] a,String x)
    {
        if(a!=null)
        {
            for(int j=0;j<a.length;j++)
            {
                if(a[j]!=null)
                {
                    if(a[j].equals(x)==true)
                    {
                        return 1;
                    }
                }
            }
        }
        return 0;
    }
    
    //Kiểm tra màu cấm đã được nhập chưa (Nếu đã nhập rồi => Không nhập nữa)
    public int checkMauCamExits(int[] a,int x)
    {
        if(a!=null)
        {
            for(int j=0;j<a.length;j++)
            {
                if(a[j]!=0)
                {
                    if(a[j]==x)
                    {
                        return 1;
                    }
                }
            }
        }
        return 0;
    }
    
    //Kiểm tra đỉnh vừa nhập đã tồn tại trong ds chưa
    public int checkDinhExits(Dinh x)
    {
        for(Dinh d: ls)
        {
            if(d.getTenDinh().equals(x.getTenDinh())==true)
            {
                return 1;
            }
        }
        return 0;
    }
    
    
    public void xuatListDinh()
    {
        for (Dinh x: ls)
        {
            x.xuatDinh();
        }
    }
    
    
    //Tìm bậc lớn nhất trong danh sách đỉnh
    public int timBacMax(List <Dinh> list)
    {
        int max=0;
        for(Dinh x: ls)
        {
            max=x.getBac();
            for(Dinh y: ls)
            {
                if(max<y.getBac())
                {
                    max=y.getBac();
                }
            }
        }
        return max;
    }
    
    
    

    //Hạ bậc đỉnh có liên quan với đỉnh được truyền vào
    public int haBacDinhLQ(String [] str)
    {
        if(str.length==0)
        {
            return 0;
        }
        int index=0;
        for(Dinh x : ls)
        {
            for (int i=0;i<str.length;i++)
            {
                if(x.getTenDinh().equals(str[i])==true)
                {
                    if(x.getBac()!=0)
                    {
                        int bac=x.getBac()-1;
                        x.setBac(bac);
                        ls.set(index, x);
                        
                    }
                }
            }
            index++;
        }
        return 1;
    }
    
    
    
    //Hạ bậc đỉnh và các đỉnh có liên quan
    public int haBacDinh(Dinh x)
    {
        if(x==null)
        {
            return 0;
        }
        int index=0;
        for(Dinh n : ls)
        {
            if(n.getTenDinh().equals(x.getTenDinh())==true)
            {
                String [] chuoiCanHB=new String[n.getBac()];
                chuoiCanHB=n.getDinhLQ();
                int tb=haBacDinhLQ(chuoiCanHB);
                n.setBac(0);
           
            }
            index++;
        }
        return 1;
        
    }
    
    public void reSetBac()
    {
        int index=0;
        for(Dinh x: ls)
        {
            int dem=0;
            for(int i=0;i<x.getDinhLQ().length;i++)
            {
                dem++;
            }
            x.setBac(dem);
            ls.set(index, x);
            index++;
        }
    }
    
    
    
    //Nhập màu cấm tô cho những đỉnh có liên quan với đỉnh vừa tô màu.
    public int nhapMauCam(String [] str, int mauCamTo)
    {
        if(str.length==0)
        {
            return 0;
        }
        int index=0;
        for(Dinh x : ls)
        {
            for (int i=0;i<str.length;i++)
            {
                if(x.getTenDinh().equals(str[i])==true)
                {
                    if(x.getMauCamTo()==null)
                    {
                        int[] mau=new int [1];
                        mau[0]=mauCamTo;
                        x.setMauCamTo(mau);
                    }
                    else
                    {
                        int soLuong=x.getMauCamTo().length;
                        soLuong++;
                        int[] mauCamMoi=new int[soLuong];
                        for(int j=0;j<x.getMauCamTo().length;j++)
                        {
                            mauCamMoi[j]=x.getMauCamTo()[j];
                        }
                        int len=x.getMauCamTo().length;
                        mauCamMoi[len]=mauCamTo;
                        if(checkMauCamExits(x.getMauCamTo(),mauCamMoi[len])!=1)
                        {
                            x.setMauCamTo(mauCamMoi);
                        }
                    }
                    ls.set(index, x);
                }
            }
            index++;
        }
        return 1;
    }
    
    
    //Kiểm tra trong ds còn đỉnh nào chưa tô màu không
    public int kiemTraToMau(List <Dinh> ls)
    {
        int kt=0;
        for(Dinh x: ls)
        {
            if(x.getMauto()==0)
            {
                kt++;
            }
        }
        return kt;
    }
            

    
    
    
    //TH1: Tô màu tất cả các đỉnh 
    public void toMau()
    {      
        int mauTo=1;   
        int max=timBacMax(ls);
        do
        {
            if(max!=0)
            {
                for(Dinh x: ls)
                {

                    if(max!=0)
                    {
                        int bac=x.getBac();
                        if(bac==max)
                        {
                            if(x.getMauCamTo()!=null)
                            {
                                int kt=0;
                                int min=mauTo;
                                do
                                {
                                    for(int i=0;i<x.getMauCamTo().length;i++)
                                    {
                                        if(min==x.getMauCamTo()[i])
                                        {
                                            kt++;
                                        }
                                    }
                                    if(kt!=0)
                                    {
                                        min++;
                                        kt=0;
                                    }
                                    else
                                    {
                                        x.setMauto(min);
                                    }

                                }while(x.getMauto()==0);

                            }
                            else
                            {
                                x.setMauto(mauTo);
                            }
                            haBacDinh(x);
                            nhapMauCam(x.getDinhLQ(),x.getMauto());
                        }
                    }
                    max=timBacMax(ls);
                }
            }
            else
            {
                for(Dinh x: ls)
                {
                    if(x.getMauto()==0)
                    {
                            if(x.getMauCamTo()!=null)
                            {
                                int kt=0;
                                int min=mauTo;
                                do
                                {
                                    for(int i=0;i<x.getMauCamTo().length;i++)
                                    {
                                        if(min==x.getMauCamTo()[i])
                                        {
                                            kt++;
                                        }
                                    }
                                    if(kt!=0)
                                    {
                                        min++;
                                        kt=0;
                                    }
                                    else
                                    {
                                        x.setMauto(min);
                                    }

                                }while(x.getMauto()==0);

                            }
                            else
                            {
                                x.setMauto(mauTo);
                            }
                            nhapMauCam(x.getDinhLQ(),x.getMauto());
                    }
                }
            }
        }while(max!=0 || kiemTraToMau(ls)!=0);

        
    }
    
    //Tinh tong so luong mau da to
    public int tinhTongSoMau()
    {
        Dinh d=ls.get(0);
        int mau=d.getMauto();
        for(Dinh x: ls)
        {
            if(mau<x.getMauto())
            {
                mau=x.getMauto();
            }
        }
        
        return mau;
    }

    
    

    
    
}
