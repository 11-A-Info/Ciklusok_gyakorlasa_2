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

            // 5. feladat: Írj programot, mely beolvassa egy kör átmérőjét, és kiírja a kör kerületét és
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

            Console.ReadKey(true);
        }
    }
}
