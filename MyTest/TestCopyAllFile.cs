//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;
//namespace MyTest
//{
//    public class TestCopyAllFile
//    {


//        public static void Main(string[] args)
//        {

//            MoveFile(@"J:\Test", @"J:\TestNew");
//            Console.WriteLine("复制成功!");
//        }
//        public static void MoveFile(string oPath, string nPath)
//        {
//            bool isSuccess = false;
//            try
//            {
//                if (!Directory.Exists(nPath))
//                {
//                    Directory.CreateDirectory(nPath);
//                }

//                DirectoryInfo sDir = new DirectoryInfo(oPath);
//                FileInfo[] fileArray = sDir.GetFiles();
//                foreach (FileInfo file in fileArray)
//                {
//                    file.CopyTo(nPath + "\\" + file.Name, true);
//                }
//                DirectoryInfo dDir = new DirectoryInfo(nPath);
//                DirectoryInfo[] subDirArray = sDir.GetDirectories();
//                foreach (DirectoryInfo subDir in subDirArray)
//                {
//                    MoveFile(subDir.FullName, nPath + "\\" + subDir.Name);
//                }
//                isSuccess = true;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.ToString());
//            }
//        }

//    }



//}


