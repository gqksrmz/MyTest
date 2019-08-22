//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Text;

//namespace MyTest
//{
//    class TestTransaction
//    {
//        static void Main(string[] args)
//        {
//            string str = "Data Source=DESKTOP-V4D9RI7;Initial Catalog=Test;User Id=sa;Password=123456";
//            using (SqlConnection con = new SqlConnection(str))
//            {
//                con.StateChange += (sender, e) =>
//                {
//                    Console.WriteLine($"current state:{e.CurrentState},before:{e.OriginalState} ...\n");
//                };


//                string sql = "delete from Users where id=17";
//                using (SqlCommand cmd = new SqlCommand(sql, con))
//                {
//                    con.Open();
//                    SqlTransaction transaction = con.BeginTransaction();
//                    cmd.Transaction = transaction;
//                    cmd.ExecuteNonQuery();
//                    transaction.Rollback();
//                    //transaction.Commit();
//                    Console.WriteLine("回滚了");
//                }
//            }

//        }

//    }
//}
