using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Nilai
    {
        static void Main(string[] args)
        {
            int nilai;
           
            Console.Write("masukan nilai anda: ");
            nilai = int.Parse(Console.ReadLine());

            if (nilai >= 80)
            {
                Console.WriteLine("A");
            }
            else if (nilai < 80 && nilai >= 65)
            {
                Console.WriteLine("B");
            }
            else if (nilai < 65 && nilai >= 45)
            {
                Console.WriteLine("C");
            }
            else if (nilai < 45 && nilai >= 30)
            {
                Console.WriteLine("D");
            }
            else if (nilai < 30)
            {
                Console.WriteLine("E");
            }

            Console.ReadLine();
        }
    }
}
