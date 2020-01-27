using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Timers;
namespace RTS_task_1
{
    class Program
    {
        //public static void InitTimer(int interval)
        //{
        //    var timer = new System.Timers.Timer();
        //    timer.Interval = interval;
        //    timer.Start();
        //    timer.Elapsed += (sender, args) =>
        //    {
        //        timer.Enabled = false;
        //        timer1_Tick(sender, args);
        //        timer.Enabled = true;
        //    };
        //}

        //private static void timer1_Tick(object sender, EventArgs e)
        //{
        //    //SendKeys.SendWait("{CAPSLOCK}");
        //    Console.WriteLine("CAPS");
        //    //Thread.Sleep(time);
        //}
        static void Main()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            int time = 1000;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    while (Console.KeyAvailable)
                    {
                        if (time >= 100)
                        {
                            time = time - 100;
                        }
                        cki = Console.ReadKey(true);
                        //InitTimer(time);
                        SendKeys.SendWait("{CAPSLOCK}");
                        Console.WriteLine("CAPS, time = {0}", time);
                        Thread.Sleep(time);
                    }
                }
                time = 1000;
                //InitTimer(1000);
                SendKeys.SendWait("{CAPSLOCK}");
                Console.WriteLine("CAPS, time = {0}", time);
                Thread.Sleep(time);

            } 
        }
    }
}
