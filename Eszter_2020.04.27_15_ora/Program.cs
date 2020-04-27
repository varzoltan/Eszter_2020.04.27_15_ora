using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._04._27_15_ora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Karakterek kezelése:
            char c;
            char a = 'd'; 
            c = 'b'; //Csak egyetlen karakter adaható meg!
            Console.Write("A megadott \"karakter:\" " + c+ "\n"); //Egyik fajta kiírás
            Console.Write("\t{0}{1}", c,a);
            Console.WriteLine("\n"+'\u0065');
            //Kód kiírása decimálisan
            int e = 'e';
            Console.WriteLine("Az e-betű decimális alkaja: {0}", e);

            //string karaktersorozatok
            string s = "alma";
            string n = "alma" + "barack";//kiír: almabarack
            s += "fa"; //almafa
            s = s + "fa"; //Teljesen ekvivalens az előző sor értékével!

            //Példa tömbre
            for (int i = 1; i <= 10; i++)//Számlálós (növekményes, csökkenős) ciklus
            {
                Console.WriteLine("Kiírom 10-szer");
            }

            string szoveg = "Szeretek tanulni!";
            char z = szoveg[9];
            Console.WriteLine(z);
            string k = szoveg[9].ToString();
            Console.WriteLine(k);

            int szam1 = 5;
            int szam2 = 10;

            //elágazás
            if (szam1.CompareTo(szam2) > 0)
            {
                Console.WriteLine("A {0} nagyobb min {1}", szam1, szam2);
            }
            /*else //különben ág
            {
                Console.WriteLine("A {0} nagyobb min {1}", szam2, szam1);
            }*/

            string egy = "egy";
            string ketto = "egy";
            if (egy.Equals(ketto))
            {
                Console.WriteLine("Egyenlő a két szöveg!");
            }
            else
            {
                Console.WriteLine("Nem egyenlő a két szöveg!");
            }
            Console.ReadKey();
        }
    }
}
