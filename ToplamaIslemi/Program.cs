using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaIslemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*convert işlemi (dönüştürmek anlamına gelir) verilen deger üzerinde aritmetik işlem yapılacağını programa ,
            //*bildirmek için kulanılan yapıdır. int32 en çok kulanılan dönüştüştürme metodudur.int32"sayı degeri" (-2,147,483,648  +2,147,483,648)' dir
            int sayı1, sayı2, toplam;
            Console.WriteLine("*** toplama işlemi***");

            Console.WriteLine("Birinci sayıyı giriniz");
            sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayıyı giriniz");
            sayı2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayı1 + sayı2;
            Console.WriteLine("toplam = " + toplam);
            Console.ReadKey();
        }
    }
}
