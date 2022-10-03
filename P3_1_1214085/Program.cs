using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_1214085
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ANAK AYAM TURUN ");
            var anakayam = int.Parse(Console.ReadLine());
            var anakayam2 = anakayam - 1;
            Console.WriteLine(" ");

            if (anakayam >= 1 && anakayam <= 10)
            {
                for (int i = anakayam; i > 0; i--)
                {
                    if (i > 1)
                    {
                        var j = i - 1;
                        Console.WriteLine("Anak ayam turunlah " + i + ", mati satu tinggallah " + j);
                    }
                    else { Console.WriteLine("Anak ayam turunlah 1, mati satu tinggallah induknya"); }
                }
            }
        }
    }
}
