using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_project
{
    internal class Program
    {
       

    
        static void Main(string[] args)
        {
            int num = 0;
            while (num != 6)
            {
                
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Choose your option: ");
                Console.WriteLine("1 ~~~> insert product");
                Console.WriteLine("2 ~~~> show product");
                Console.WriteLine("3 ~~~> Show Users");
                Console.WriteLine("4 ~~~> delete product");
                Console.WriteLine("5 ~~~> Register");
                Console.WriteLine("6.Exit");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Functions.InsertProduct();
                        Console.WriteLine("\n");

                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Functions.Selectstore();
                        Console.WriteLine("\n");
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Functions.Selectname();
                        Console.WriteLine("\n");

                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Functions.DeleteProd();
                        Console.WriteLine("\n");

                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Enter Your ID: ");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter Your Name: ");
                        string fname = Console.ReadLine();
                        Console.WriteLine("Enter Your Home City: ");
                        string city = Console.ReadLine();
                        Functions.Register(id, fname, city);
                        Console.WriteLine("\n");

                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        
                        Console.WriteLine("Thank you And Goodbye!");
                        break;

                }
                if(num < 1 || num > 6 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not in List! Try Again Please....");
                }

            }
            Console.WriteLine();

        }
    }
}
