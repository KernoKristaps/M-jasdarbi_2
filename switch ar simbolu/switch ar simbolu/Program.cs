using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_ar_simbolu
{
    class Program
    {
        static void Main(string[] args)
        {


            int mainigais;
            Console.WriteLine("$");
            string vards = Console.ReadLine();
            mainigais = Convert.ToInt16(vards);


            switch (mainigais)
            {
                case 1:
                    Console.WriteLine("1$ george");
                    break;
                case 2:
                    Console.WriteLine("$2 thomas");
                    break;
                case 5:
                    Console.WriteLine("$5 abraham");
                    break;
                case 10:
                    Console.WriteLine("$10 alexander");
                    break;
                case 20:
                    Console.WriteLine("$20 andrew");
                    break;
                case 50:
                    Console.WriteLine("$50 ulysses");
                    break;
                case 100:
                    Console.WriteLine("$100 benjamin");
                    break;
                default:
                    Console.WriteLine("nesakrit");
                    break;


            }
            Console.ReadLine();
        }
    }
}
