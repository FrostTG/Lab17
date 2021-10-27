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
            Console.Write("Vvedite Full Name:");
            string FullName = Console.ReadLine();
            Console.Write("Vvedite Account Number:");
            double AccNumb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedite Balance:");
            double Balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedite balance propisyu:");
            string BalanceP = Console.ReadLine();
            Console.WriteLine();
            Method method = new Method(AccNumb,Balance,FullName);
            Method1 method1 = new Method1(AccNumb, BalanceP, FullName);
            method.Fill();
            Console.WriteLine();
            method1.Fill();
            Console.ReadKey();           
        }
    }
    class Account<T,U>
    {
        protected T AccNumb { get; set; }
        protected U Balance { get; set; }
        protected string FullName { get; set; }
    }
    class Method : Account<double,double>
    {
        public Method(double AccNumb, double Balance, string FullName)
        {
            this.AccNumb = AccNumb;
            this.Balance = Balance;
            this.FullName = FullName;
        }
        public void Fill()
        {
            Console.WriteLine("ФИО: {0}\nНомер счета: {1}\nБаланс: {2:C2}",FullName,AccNumb,Balance);
        }
    }

    class Method1 : Account<double,string>
    {
        public Method1(double AccNumb, string Balance, string FullName)
        {
            this.AccNumb = AccNumb;
            this.Balance = Balance;
            this.FullName = FullName;
        }
        public void Fill()
        {
            Console.WriteLine("ФИО: {0}\nНомер счета: {1}\nБаланс: {2}", FullName, AccNumb, Balance);
        }
    }

}







