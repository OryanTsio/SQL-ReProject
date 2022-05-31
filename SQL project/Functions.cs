using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SQL_project
{
    internal class Functions
    {
       public static void Selectstore()
       {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=LocalHost\\SQLEXPRESS;database=project;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "select * from store";

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                

                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                    Console.Write("  {0,-11}", mySqlDataReader.GetName(i));
                Console.WriteLine();

                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                    Console.Write("~~~~~~~~~~");
                Console.WriteLine("\n");

                while (mySqlDataReader.Read())
                {
                    for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                        Console.Write("  {0,-11}", mySqlDataReader[i].ToString());
                    Console.WriteLine();
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
       }
        
    
        public static void InsertProduct()
        {
            try
            {
                
                SqlConnection mySqlConnection = new SqlConnection("server=LocalHost\\SQLEXPRESS;database=project;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                        Console.Clear();
                        Console.WriteLine("insert products to store: ");
                        Console.Write("insert prodid: ");
                        string a1 = Console.ReadLine();
                        Console.Write("insert proname : ");
                        string a2 = Console.ReadLine();
                        Console.Write("insert price : ");
                        int a3 = int.Parse(Console.ReadLine());
                        
                        mySqlCommand.CommandText = $"insert into store values('{a1}','{a2}','{a3}')";
                int n = mySqlCommand.ExecuteNonQuery();
                Console.WriteLine("Product inserted");
                Selectstore();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public static void selectavg()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=LocalHost\\SQLEXPRESS;database=project;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                    Console.Clear();
                mySqlCommand.CommandText = "select avg(price)  as '\n AVG' from store";

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();


                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                    Console.Write("  {0,-11}", mySqlDataReader.GetName(i));
                Console.WriteLine();

                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                Console.WriteLine("~~~~~~~~");

                while (mySqlDataReader.Read())
                {
                    for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                        Console.Write("  {0,-11}", mySqlDataReader[i].ToString());
                    Console.WriteLine();
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public static void AVGprice()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=LocalHost\\SQLEXPRESS;database=project;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "select * from store";
                selectavg();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public static void Selectusers()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=LocalHost\\SQLEXPRESS;database=project;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                    Console.Clear();
                mySqlCommand.CommandText = "select * from client";

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();


                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                    Console.Write("  {0,-11}", mySqlDataReader.GetName(i));
                Console.WriteLine();

                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                    Console.Write("~~~~~~~~~~~~~~");
                Console.WriteLine("\n");

                while (mySqlDataReader.Read())
                {
                    for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                        Console.Write("  {0,-11}", mySqlDataReader[i].ToString());
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public static void Register(string id,string fname,string city)
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=LocalHost\\SQLEXPRESS;database=project;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                    Console.Clear();
                mySqlCommand.CommandText = $"insert into client values('{id}','{fname}','{city}');";

                int n = mySqlCommand.ExecuteNonQuery();
                Console.WriteLine("Account Registerd ");
                mySqlConnection.Close();
               
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        
        public static void Selectname()
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=LocalHost\\SQLEXPRESS;database=project;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                Console.Clear();
                Console.WriteLine("\tWellcom To Users Manegment!\n");
                mySqlCommand.CommandText = $"select * from client";
                Console.WriteLine("\nShowing Users....\n");
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();


                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                    Console.Write("  {0,-11}", mySqlDataReader.GetName(i));
                Console.WriteLine();

                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                    Console.Write("~~~~~~~~~~~~");
                Console.WriteLine("\n");

                while (mySqlDataReader.Read())
                {
                    for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                        Console.Write("  {0,-11}", mySqlDataReader[i].ToString());
                    Console.WriteLine();
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public static void DeleteProd()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=LocalHost\\SQLEXPRESS;database=project;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                Console.Clear();
                int num;
                Console.WriteLine("insert price to delete");
                num = int.Parse(Console.ReadLine());
                mySqlCommand.CommandText = $"delete from store where price = {num};";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                    Console.Write("  {0,-11}", mySqlDataReader.GetName(i));
                Console.WriteLine();

                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                    Console.Write("~~~~~~~~~~~");
                Console.WriteLine("\n");

                while (mySqlDataReader.Read())
                {
                    for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                        Console.Write("  {0,-11}", mySqlDataReader[i].ToString());
                    Console.WriteLine();
                }


                Console.WriteLine("Product deleted");
                mySqlDataReader.Close();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
