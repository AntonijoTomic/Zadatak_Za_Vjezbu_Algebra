using System;
using System.Collections.Generic;


namespace ZadatakZaVjezbuAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobar dan, dobrodošli na prvi zadatak!");
            Console.WriteLine("Unesite neki tekst: ");
            string uneseniTekst = Console.ReadLine().ToLower();

            bool konzolaOtvorena = true;


            while (konzolaOtvorena)
            {
                if (uneseniTekst.Length > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Odaberite opciju koju želite unošenjem broja ispred opcije: " +
                        "\n1 - Ispis broja riječi" +
                        "\n2 - Ispis broja slova" +
                        "\n3 - Ispis duzine prve rijeci i zadnje" +
                        "\n4 - Zamjeni riječ iz teksta novom riječi" +
                        "\n5 - Pronađi mi najdužu riječ" +
                        "\n6 - Unesite novi tekst"+
                        "\n0- Izadi iz programa");

                    int odabir = Convert.ToInt32(Console.ReadLine());

                    uneseniTekst = uneseniTekst.Trim(); // da bi uklonili mogućnost brojanja razmaka kao riječi
                    string[] tekst = uneseniTekst.Split(' '); // razdvoji recenice na rijeci ' ' 
                    switch (odabir)
                    {
                        case 0:
                            konzolaOtvorena = false;
                            break;
                        case 1:
                            // Console.WriteLine(odabir);                                  
                            Console.WriteLine("Uneseni broj riječi je : " + tekst.Length); // ispis broja
                            Console.ReadKey();
                            break;
                        case 2:
                            uneseniTekst = uneseniTekst.Replace(" ", "");// uklanjam razmak te mi se onda taj dio ne broji kao slovo
                            Console.WriteLine(uneseniTekst.Length);
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Prva riječ je:{0} i njezina duzina je {1}", tekst[0], tekst[0].Length);
                            Console.WriteLine("Zadnja riječ je:{0} i njezina duzina je {1}", tekst[tekst.Length - 1], tekst[tekst.Length - 1].Length);
                            Console.ReadKey();
                            break;
                        case 4:
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
                            Console.ReadKey();
                            break;
                        case 5:
                            int brojcanik = 0;
                            int duzinaNajduzeRijeci = 0;
                            List<string> najduzeRijeci = new List<string>();
                            foreach (string rijec in tekst)
                            {
                                if (rijec.Length > duzinaNajduzeRijeci)
                                {
                                    duzinaNajduzeRijeci = rijec.Length;
                                    najduzeRijeci.Clear(); //ovim putem brisemo sve iz liste ranije, zato jer je dosla nova rijec koja je duza od svih prethodnih
                                    najduzeRijeci.Add(rijec);
                                }
                                else if(rijec.Length == duzinaNajduzeRijeci)
                                {
                                    najduzeRijeci.Add(rijec);
                                }
                                
                            }
                            if (najduzeRijeci.Count > 1)
                                Console.WriteLine("Najduža riječ u ovom tekstu sadrži {1} slova, a njih je ukupno {0}: \n ", najduzeRijeci.Count, duzinaNajduzeRijeci);
                            else
                                Console.WriteLine("Najduza riječ sadrži {0} slova, a to je: ", duzinaNajduzeRijeci);

                            do
                            {
                                Console.WriteLine(najduzeRijeci[brojcanik]);
                                brojcanik++;
                            }
                            while (brojcanik < najduzeRijeci.Count);
                            Console.ReadKey();
                            break;
                        case 6:
                            Console.WriteLine("Unesite novi tekst: ");
                            uneseniTekst = Console.ReadLine().ToLower();
                            break;

                        default:
                            Console.WriteLine("Vaš odabir nije ponuden");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Niste unijeli tekst");
                    konzolaOtvorena = false;
                }
            }
            Console.ReadKey();
        }
    }
}
