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
            Method method = new Method();
            Console.WriteLine();
            Method1 method1 = new Method1();
            method.Fill();
            Console.WriteLine();
            method1.Fill();
            Console.ReadKey();
        }
    }
    class Account<T, U>
    {
        protected T AccNumb { get; set; }
        protected U Balance { get; set; }
        protected string FullName { get; set; }
    }
    class Method : Account<double, double>
    {
        public Method()
        {
            Console.Write("Vvedite Account Number:");
            AccNumb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedite Balance:");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedite Full Name:");
            FullName = Console.ReadLine();
        }
        public void Fill()
        {
            Console.WriteLine("ФИО: {0}\nНомер счета: {1}\nБаланс: {2:C2}", FullName, AccNumb, Balance);
        }
    }

    class Method1 : Account<double, string>
    {
        public Method1()
        {
            Console.Write("Vvedite Account Number:");
            AccNumb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedite balance propisyu:");
            Balance = Console.ReadLine();
            Console.Write("Vvedite Full Name:");
            FullName = Console.ReadLine();
        }
        public void Fill()
        {
            Console.WriteLine("ФИО: {0}\nНомер счета: {1}\nБаланс: {2}", FullName, AccNumb, Balance);
        }
    }

}







