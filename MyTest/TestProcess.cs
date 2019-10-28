//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Text;

//namespace MyTest
//{
//    public class TestProcess
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\DELL\Desktop\Constellation.exe");
//                Process p = new Process();
//                p.StartInfo = psi;
//                p.Start();
//                Process[] pros=Process.GetProcesses();
//                foreach (var item in pros)
//                {
//                    item.Kill();
//                    Console.WriteLine(item);
//                }
//            }
//            catch (Exception e)
//            {

//                Console.WriteLine(e.ToString());
//            }
//        }
//    }
//}
