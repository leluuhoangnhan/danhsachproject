/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modul;

import static java.lang.Thread.sleep;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JLabel;

/**
 *
 * @author LeLuuHoangNhan
 */
public class DongHo extends Thread 
{
    int gio, phut, giay;
    JLabel thoiGian;
    
    public DongHo()
    {
        super();
    }
    
    public DongHo(int hh, int mm, int ss, JLabel time)
    {
        gio = hh;
        phut = mm;
        giay = ss;
        thoiGian = time;   
    }
    
    public void run()
    {
        for(int i=0;i<2;i++)
        {
            giay++;
            if(giay==60)
            {
                giay=0;
                phut++;
                if(phut==60)
                {
                    phut=0;
                    gio++;
                    if(gio==24)
                        gio=0;
                }
            }

            String strGio = gio + "", strPhut = phut + "", strGiay = giay + "";
            if(gio<10)
                strGio="0" + gio;
            if(phut<10)
                strPhut="0" + phut;
            if(giay<10)
                strGiay="0" + giay;

            thoiGian.setText(strGio + ":" + strPhut + ":" + strGiay);

            try {
                sleep(1000);
            } catch (InterruptedException ex) {}
            i--;
        }
    }
}
