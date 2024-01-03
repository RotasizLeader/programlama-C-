using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programlama_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci Sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinici Sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Girilen sayıların toplamı: ");
            Console.WriteLine(sayi1 + sayi2);
            Console.Write("Girilen sayıların farkı: ");
            Console.WriteLine(sayi1 - sayi2);
            Console.Write("Girilen sayıların çarpımı: ");
            Console.WriteLine(sayi1 * sayi2);
            Console.Write("Girilen sayıların bölümü: ");
            Console.WriteLine(sayi1 / sayi2);
            Console.ReadKey();
        }
    }
}
