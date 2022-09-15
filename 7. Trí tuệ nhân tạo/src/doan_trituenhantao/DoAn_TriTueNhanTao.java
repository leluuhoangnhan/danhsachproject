/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package doan_trituenhantao;
import java.util.ArrayList;
import java.util.List;
import modul.Dinh;
import modul.ListDinh;

/**
 *
 * @author LeLuuHoangNhan
 */
public class DoAn_TriTueNhanTao {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        ListDinh ls=new ListDinh();
        ls.nhapListDinh();
        ls.xuatListDinh();


        ls.toMau();
        ls.reSetBac();

        System.out.println("Danh sach sau khi to mau tat ca");
        ls.xuatListDinh();
        System.out.println("Tong so mau to la: " + ls.tinhTongSoMau());

    }
    
}
