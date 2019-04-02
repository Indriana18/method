using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        
            static void Main (string [] args )
            {
                //deklarasi variabel
                int hasil;
                Calculator calculator = new Calculator();

                //membuat objek dari Class Calculator
                hasil = calculator.Penjumlahan(10, 2);
                CetakHasil("Hasil Penjumlahan : " + hasil);

                hasil = calculator.Penjumlahan(10, 2, 3);
                CetakHasil("Hasil penjumlahan overload :" + hasil);

                hasil = calculator.Pengurangan(7, 2);
                CetakHasil("Hasil Pengurangan " + hasil);

                hasil = Calculator.Perkalian(5, 2);
                CetakHasil("Hasil perkalian : " + hasil);

                Console.ReadKey();
                


            }
        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
