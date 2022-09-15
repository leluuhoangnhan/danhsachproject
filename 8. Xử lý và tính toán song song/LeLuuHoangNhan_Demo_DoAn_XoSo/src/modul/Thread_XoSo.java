/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modul;

import static java.lang.Thread.sleep;
import java.util.Date;
import java.util.Random;
import javax.swing.JTextField;

/**
 *
 * @author LeLuuHoangNhan
 */
public class Thread_XoSo extends Thread 
{
    public JTextField txt;
    public int n;
    
    public Thread_XoSo()
    {
        super();
    }
    
    public Thread_XoSo(JTextField t, int lanQuay)
    {
        txt=t;
        n=lanQuay;
    }
    
    public void run()
    {
        Date now=new Date();
        Random rd=new Random(now.getTime()); //---------Lấy số tự động
        for(int i=0;i<n;i++)
        {
            int num=Math.abs(rd.nextInt())%10;
            txt.setText(""+num);
            try{
                sleep(20); //--------Hàm nghỉ 0.02 giây
            }
            catch(Exception ex)
            {
                ex.printStackTrace();
            }
        }
    }
}
