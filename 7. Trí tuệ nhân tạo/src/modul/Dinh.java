/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modul;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author LeLuuHoangNhan
 */
public class Dinh {
    String tenDinh;
    String[] dinhLQ;
    int mauto;
    int[] mauCamTo;
    int bac;
    
    
    
    public Dinh() {
        tenDinh=null;
        dinhLQ=null;
        mauto=0;
        mauCamTo=null;
        bac=0;
    }

    public Dinh(String tenDinh, String[] dinhLQ, int mauto, int[] mauCamTo, int bac) {
        this.tenDinh = tenDinh;
        this.dinhLQ = dinhLQ;
        this.mauto = mauto;
        this.mauCamTo = mauCamTo;
        this.bac = bac;
    }

    public String getTenDinh() {
        return tenDinh;
    }

    public String[] getDinhLQ() {
        return dinhLQ;
    }

    public int getMauto() {
        return mauto;
    }

    public int[] getMauCamTo() {
        return mauCamTo;
    }

    public int getBac() {
        return bac;
    }

    public void setTenDinh(String tenDinh) {
        this.tenDinh = tenDinh;
    }

    public void setDinhLQ(String[] dinhLQ) {
        this.dinhLQ = dinhLQ;
    }

    public void setMauto(int mauto) {
        this.mauto = mauto;
    }

    public void setMauCamTo(int[] mauCamTo) {
        this.mauCamTo = mauCamTo;
    }

    public void setBac(int bac) {
        this.bac = bac;
    }
    
    //xuất ds đỉnh liên quan
    public void showDLQ()
    {
        System.out.print(", dinhLQ = ");
        if(dinhLQ!=null)
        {
            for(int i=0;i<dinhLQ.length;i++)
            {
                System.out.print(dinhLQ[i]);
                if(i+1!=dinhLQ.length)
                {
                    System.out.print(", ");
                }
            }
        }
        else
        {
            System.out.print("NULL");
        }
    }
    
    //xuất ds màu cấm tô
    public void showMauCamTo()
    {
        System.out.print(", mauCamTo = ");
        if(mauCamTo!=null)
        {
            for(int i=0;i<mauCamTo.length;i++)
            {
                System.out.print(mauCamTo[i]);
                if(i+1!=mauCamTo.length)
                {
                    System.out.print(", ");
                }
            }
        }
        else
        {
            System.out.print("NULL");
        }
    }

    @Override
    public String toString() {
        return "Dinh{" + "tenDinh=" + tenDinh + ", mauto=" + mauto + ", bac=" + bac;
    }


    
    
    
    
    

    public void nhapDinh()
    {
        Scanner sc=new Scanner(System.in);
        System.out.println("Nhap ten dinh: ");
        tenDinh=sc.next();
        System.out.println("Nhap so luong dinh co lien ket: ");
        bac=sc.nextInt();
    }
    

    
    
    public void xuatDinh()
    {
        System.out.print(toString());
        showDLQ();
        showMauCamTo();
        System.out.print("}");
        System.out.println();
        
    }
    
    
    
}
