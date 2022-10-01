using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1214081
{
    internal class P2_2_1214081
    {
        static void Main(string[] args)
        {
            //Menuliskan gaji pokok secara manual
            Console.WriteLine("Silahkan Masukkan Gaji Pokok Anda");
            int gajiPokok = int.Parse(Console.ReadLine());

            //matematika yang dipakai
            double hasilTunjangan = 20.0 / 100.0 * gajiPokok;
            double hasilBonus = 15.0 / 100.0 * gajiPokok;
            double hasilPPH = 3.5 / 100.0 * gajiPokok;
            double totalGaji = gajiPokok + hasilTunjangan + hasilBonus;
            double gajiBersih = totalGaji - hasilPPH;

            Console.WriteLine(" ");

            //Menampilkan Gaji Pokok
            Console.WriteLine("Gaji Pokok   = " + gajiPokok);
            //Menampilkan Tunjangan
            Console.WriteLine("Tunjangan    = " + hasilTunjangan);
            //Menampilkan Bonus
            Console.WriteLine("Bonus        = " + hasilBonus);
            //Menampilkan PPH
            Console.WriteLine("PPH          = " + hasilPPH);
            //Menampilkan Total Gaji
            Console.Write("Total Gaji   = ");
            Console.WriteLine(totalGaji);
            //Menampilkan Gaji Bersih
            Console.Write("Gaji Bersih  = ");
            Console.WriteLine(gajiBersih);
        }
    }
}
