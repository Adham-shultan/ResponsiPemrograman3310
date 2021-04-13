using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3310
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No Nik - Nama                   Gaji Bulanan");
            Console.WriteLine("------------------------------------------");
            Karyawan karyawan1 = new Karyawan(1, 190302123, "Adham     ", 3000000);
            karyawan1.Cetak();
            Karyawan karyawan2 = new Karyawan(2, 190302124, "Shultan   ", 2000000);
            karyawan2.Cetak();

            Console.WriteLine("");
            Console.WriteLine("Alhamdulillah dapat Kenaikan Gaji 10%!!!");
            Console.WriteLine("");

            Console.WriteLine("No Nik - Nama                   Gaji Bulanan");
            Console.WriteLine("------------------------------------------");
            Karyawan Naik1 = new Karyawan(1, 190302123, "Adham     ", 3000000);
            Naik1.CetakNaik();
            Karyawan Naik2 = new Karyawan(2, 190302124, "Shultan   ", 2000000);
            Naik2.CetakNaik();
            Console.ReadKey(true);
        }
    }
}
