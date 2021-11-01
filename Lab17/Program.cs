using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite Account Number:");
            int accnum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite Account Number Propisyu:");
            string accnum2 = Console.ReadLine();
            Console.Write("Vvedite balance:");
            double balance1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedite Full Name:");
            string fname1 = Console.ReadLine();
            Account<int> account1 = new Account<int>(accnum1, balance1, fname1);
            Account<string> account2 = new Account<string>(accnum2, balance1, fname1);
            account1.Print();
            Console.WriteLine();
            account2.Print();
            Console.ReadKey();
        }
    }
    class Account<T>
    {
        private T AccNumb;
        private double Balance;
        private string FullName;
        public Account(T accnumb, double balance, string fullname)
        {
            AccNumb = accnumb;
            Balance = balance;
            FullName = fullname;
        }
        public void Print()
        {
            Console.Write("Account Number:{0} ", AccNumb);
            Console.Write("Balance:{0} ", Balance);
            Console.Write("Full Name:{0} ", FullName);
        }
    }
}







