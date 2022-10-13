using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, birinci = 0, ikinci = 1, yenisayi = 0;
            Console.Write("Fibonacci dizisi için bir sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            while (yenisayi <= sayi)
            {
                yenisayi = birinci + ikinci;
                if (yenisayi > sayi) break;
                birinci = ikinci;
                ikinci = yenisayi;
                Console.WriteLine(yenisayi);
            }
            Console.ReadKey();
        }
    }
}
