using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok_gyakorlasa
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Feladat: Írj programot, mely beolvas egy pozitív egész
            számot, és kiírja az osztóit!

            // Változók
            int szam;

            Console.Write("Kérek egy egész számot: ");
            szam = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"A szám osztói {szam}: ");

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            /* 2. Feladat: Írj programot, mely beolvas egy pozitív egész számot, és
            // kiírja az osztóinak az összegét!

            // Változók
            int szam;
            int osszeg = 0;

            Console.Write("Kérek egy egész számot: ");
            szam = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    osszeg += i;
                }
            }

            Console.WriteLine($"A szám osztóinak összege: {osszeg}");
            */

            /* 3. Feladat: Írj programot, mely beolvas egy pozitív egész
            // számot, és megmondja, hogy tökéletes szám-e!

            // Változók
            int szam;
            int osszeg = 0;

            Console.Write("Kérek egy egész számot: ");
            szam = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    osszeg += i;
                }
            }

            if (osszeg == 2 * szam)
            {
                Console.WriteLine($"A szám: {szam} tökéletes.");
            }
            else
            {
                Console.WriteLine($"A szám: {szam} nem tökéletes.");
                Console.WriteLine($"Az osztók összege: {osszeg}");
            }

            */

            /* 4. Feladat: Írassuk ki 1000-ig az összes tökéletes számot!

            for (int index = 1; index < 100001; index++)
            {
                int osszeg = 0;

                for (int i = 1; i <= index; i++)
                {
                    if (index % i == 0)
                    {
                        osszeg += i;
                    }
                }

                if (osszeg == 2 * index)
                {
                    Console.WriteLine($"A szám: {index} tökéletes.");
                }
            }
            */

            /* 5. feladat: Írj programot, mely beolvassa egy kör átmérőjét, és kiírja a kör kerületét és
            // területét! A pi értékének meghatározásához használd a Math.PI értéket!
            // Változók
            int atmero = 0;
            double kerulet = 0.0d;
            double terulet = 0.0d;

            Console.Write("Kérem az átmérőt: ");
            atmero = Int32.Parse(Console.ReadLine());

            kerulet = atmero * Math.PI;
            terulet = atmero * atmero * Math.PI / 4;

            Console.WriteLine($"Kerület: {kerulet:F2}, terület: {terulet:F2}");
            */

            /* 6. feladat: Írj programot, mely beolvassa a másodfokú egyenlet együtthatóit, és kiírja, hogy az
            // egyenletnek van-e megoldása! Ha van írassuk ki!
            // Változók
            int aEgy = 0;
            int bEgy = 0;
            int cEgy = 0;
            double diszk = 0.0d;
            double elso = 0.0d;
            double masodik = 0.0d;

            Console.Write("Kérem az első együtthatót: ");
            aEgy = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a második együtthatót: ");
            bEgy = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a harmadik együtthatót: ");
            cEgy = Int32.Parse(Console.ReadLine());

            diszk = bEgy * bEgy - 4 * aEgy * cEgy;

            if (diszk < 0)
            {
                Console.WriteLine("Nincs megoldás!");
            }
            else if (diszk == 0)
            {
                elso = ((-1) * bEgy + Math.Sqrt(diszk)) / (2 * aEgy);
                Console.WriteLine("Létezik megoldás!");
                Console.WriteLine($"A megoldás: {elso}");
            }
            else
            {
                elso = ((-1) * bEgy + Math.Sqrt(diszk)) / (2 * aEgy);
                masodik = ((-1) * bEgy - Math.Sqrt(diszk)) / (2 * aEgy);
                Console.WriteLine("Létezik megoldás!");
                Console.WriteLine($"Az első megoldás: {elso}");
                Console.WriteLine($"A második megoldás: {masodik}");
            }
            */

            // 7. feladat: Írj programot, mely beolvassa egy derékszögű háromszög két befogóját, és megadja
            // az átfogójának a hosszát!Az átfogót 2 tizedesjeggyel add meg!
            // Változók deklarálása
            double aOldal = 0.0d;
            double bOldal = 0.0d;
            double cOldal = 0.0d;

            // Változók definiálása
            Console.Write("A oldal: ");
            aOldal = Double.Parse(Console.ReadLine());
            Console.Write("B oldal: ");
            bOldal = Double.Parse(Console.ReadLine());

            cOldal = Math.Sqrt(Math.Pow(aOldal, 2) + Math.Pow(bOldal,2));
            Console.WriteLine($"A harmadik oldal: {cOldal}");

            Console.ReadKey(true);
        }
    }
}
