using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_Za_Vjezbu_Algebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobar dan, dobrodošli na prvi zadatak!");
            Console.WriteLine("Unesite neki tekst: ");
            string uneseniTekst= Console.ReadLine().ToLower();


            if (uneseniTekst.Length > 0)
            {
                Console.Clear();
                Console.WriteLine("Sada nakon što ste unijeli tekst, odaberite opciju koju želite unošenjem broja ispred opcije: \n1-Ispis broja riječi\n2-Ispis broja slova" +
                    "\n3-Ispis duzine prve rijeci i zadnje\n4-Zamjeni riječ iz teksta novom riječi");

                int odabir = Convert.ToInt32(Console.ReadLine());
                uneseniTekst = uneseniTekst.Trim(); // da bi uklonili mogućnost brojanja razmaka kao riječi
                string[] tekst = uneseniTekst.Split(' '); // razdvoji recenice na rijeci ' ' 
                switch (odabir)
                {
                    case 1:
                        // Console.WriteLine(odabir);                                  
                        Console.WriteLine("Uneseni broj riječi je - " + tekst.Length); // ispis broja
                        break;
                    case 2:
                        uneseniTekst = uneseniTekst.Replace(" ", "");// uklanjam razmak te mi se onda taj dio ne broji kao slovo
                        Console.WriteLine(uneseniTekst.Length);
                        break;
                    case 3:
                        Console.WriteLine("Prva riječ je:{0} i njezina duzina je {1}", tekst[0], tekst[0].Length);
                        Console.WriteLine("Zadnja riječ je:{0} i njezina duzina je {1}", tekst[tekst.Length - 1], tekst[tekst.Length - 1].Length);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ovo je vaš tekst: " + uneseniTekst);
                        Console.WriteLine("Unesite poziciju riječi koju želite zamjeniti (pr. 1, 2, 3, 4 ...) ");
                        int rijecZaMjenjat = Int32.Parse(Console.ReadLine());

                        if (rijecZaMjenjat >= 1 && rijecZaMjenjat <= tekst.Length)
                        {
                            Console.WriteLine("Sada unesite novu riječ");
                            string novaRijec = Console.ReadLine();

                            // Zamjenjuje odabranu rijec novom rijecju, smanjujem poziciju jer se broji od 0
                            tekst[rijecZaMjenjat - 1] = novaRijec;

                            //Vraćam tekst u prvobitno stanje
                            uneseniTekst = string.Join(" ", tekst);
                            Console.WriteLine("Tekst nakon zamjene riječi: " + uneseniTekst);
                        }
                        else
                        {
                            Console.WriteLine("Pogrešna pozicija. Molimo unesite valjanu poziciju riječi.");
                        }
                        break;
                    default:
                        Console.WriteLine("Vaš odabir nije ponuden");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Niste unijeli tekst");
            }
            Console.ReadKey();
        }
    }
}
