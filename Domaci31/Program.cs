using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------Artikli-----------");
            Console.WriteLine("--------------------------");
            List<int> ArtikliSifra = new List<int>();
            List<string> ArtikliNaziv = new List<string>();
            List<float> ArtikliCena = new List<float>();
            List<int> ArtikalKolicina = new List<int>();

            while (true)
            {
                Console.WriteLine("MENI: 1. Dodaj novi artikal, 2. Izlistaj postojece artikle, 3. Izmeni artikal, 4. Izadji iz aplikacije.");
                String unos = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine("");
                switch (unos)
                {
                    case "1":
                        while (true)
                        {
                            Console.Write("Unesite sifru artikla (Sifra moze biti SAMO celobrojna vrednost): ");
                            int sifraa = int.Parse(Console.ReadLine());
                            bool proveraa = false;
                            for (var i = 0; i < ArtikliSifra.Count; i++)
                                if (ArtikliSifra[i] == sifraa)
                                {
                                    Console.WriteLine("Uneta sifra se uklapa sa vec postojecom sifrom!");
                                    proveraa = true;
                                }
                            if (proveraa)
                                continue;
                            ArtikliSifra.Add(sifraa);
                            Console.Write("Unesite naziv artikala: ");
                            String naziv = Console.ReadLine();
                            if(naziv.Length == 0)
                            {
                                Console.WriteLine("Niste ispravno uneli naziv artikla!");
                                continue;
                            }
                            ArtikliNaziv.Add(naziv);
                            Console.Write("Unesite cenu artikla: ");
                            ArtikliCena.Add(float.Parse(Console.ReadLine()));
                            Console.Write("Unesite kolicinu artikla: ");
                            ArtikalKolicina.Add(int.Parse(Console.ReadLine()));
                            Console.WriteLine("USPESNO STE DODALI ARTIKAL!");
                            break;
                        }

                        break;
                    case "2":
                        Console.WriteLine("------------LISTA ARTIKALA------------");
                        if (ArtikliSifra.Count == 0)
                        {
                            Console.WriteLine("Nije dodat niti jedan artikal!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sifra artikla, Naziv, Cena, Kolicina");
                            for (int i = 0; i < ArtikliSifra.Count; i++)
                                Console.WriteLine($"{ArtikliSifra[i]}, {ArtikliNaziv[i]}, {ArtikliCena[i]}, {ArtikalKolicina[i]}");
                            break;
                        }
                    case "3":
                        Console.WriteLine("----------------IZMENITE ARTIKAL-----------------");
                        bool proveraaa = false;
                        int sifra =0;
                        int index =0;
                        int brojac =0;
                        int sifraaa = 0;
                        while (true)
                        {
                            if (ArtikliSifra.Count == 0)
                            {
                                Console.WriteLine("Nije dodat niti jedan artikal!");
                                break;
                            }
                            Console.WriteLine(" ");

                            if (!proveraaa)
                            {
                                Console.Write("Unesite sifru artikla: ");
                                sifra = int.Parse(Console.ReadLine());

                            }
                            else
                            {
                                sifra = sifraaa;
                                brojac = 0;

                            }
                                

                            for (int i = 0; i < ArtikliSifra.Count; i++)
                                if (sifra == ArtikliSifra[i])
                                {
                                    brojac++;
                                    index = i;
                                    sifraaa = sifra;
                                }
                            if (brojac == 1)
                            {
                                Console.WriteLine("Sifra artikla, Naziv, Cena, Kolicina");
                                Console.WriteLine($"{ArtikliSifra[index]}, {ArtikliNaziv[index]}, {ArtikliCena[index]}, {ArtikalKolicina[index]}");
                                Console.WriteLine("Odaberite opciju 1. Izmenite sifru, 2. Izmenite naziv, 3. Izmenite cenu, 4. Izmenite kolicinu, 5. Obrisi artikal, 6. Vrati se na pocetni meni");
                                string unoss = Console.ReadKey().KeyChar.ToString();
                                Console.WriteLine(" ");
                                switch (unoss)
                                {
                                    case "1":
                                        {
                                            while (true)
                                            {
                                                Console.Write("Unesite novu sifru artikla: ");
                                                int sifraa = int.Parse(Console.ReadLine());
                                                bool provera = false;
                                                for (var i = 0; i < ArtikliSifra.Count; i++)
                                                    if (ArtikliSifra[i] == sifraa)
                                                    {
                                                        Console.WriteLine("NIJE MOGUCE DODELITI UNETU SIFRU JER JE VEC DODELJENA NEKOM ARTIKLU!");
                                                        provera = true;
                                                    }
                                                if (provera)
                                                    continue;
                                                ArtikliSifra[index] = sifraa;
                                                sifraaa = sifraa;
                                                Console.WriteLine("USPESNO JE IZMENJENA SIFRA ARTIKLA!");
                                                break;
                                            }

                                            break;
                                        }
                                    case "2":
                                        {
                                            Console.Write("Unesite novi naziv artikla: ");
                                            ArtikliNaziv[index] = Console.ReadLine();
                                            Console.WriteLine("USPESNO JE IZMENJEN NAZIV ARTIKLA!");
                                            break;
                                        }
                                    case "3":
                                        {
                                            Console.Write("Unesite novu cenu artikla: ");
                                            ArtikliCena[index] = int.Parse(Console.ReadLine());
                                            Console.WriteLine("USPESNO JE IZMENJENA CENA ARTIKLA!");
                                            break;
                                        }
                                    case "4":
                                        {
                                            Console.Write("Unesite novo stanje kolicine datog artikla: ");
                                            ArtikalKolicina[index] = int.Parse(Console.ReadLine());
                                            Console.WriteLine("USPESNO STE IZMENILI KOLICINU ARTIKLA!");
                                            break;

                                        }
                                    case "5":
                                        {
                                            Console.Write("Da li ste sigurni da zelite da obrisete artikal? 1. DA, 2. NE: ");
                                            String izbor = Console.ReadKey().KeyChar.ToString();
                                            switch (izbor)
                                            {
                                                case "1":
                                                    {
                                                        ArtikliSifra.RemoveAt(index);
                                                        ArtikliNaziv.RemoveAt(index);
                                                        ArtikliCena.RemoveAt(index);
                                                        ArtikalKolicina.RemoveAt(index);
                                                        Console.WriteLine("Uspesno ste obrisali artikal!");
                                                        break;
                                                    }
                                                case "2":
                                                    break;
                                            }

                                            break;
                                        }
                                    case "6":
                                        break;
                                    default:
                                        break;
                                }
                                if (unoss == "6")
                                    break;
                                Console.Write("Da li zelite da nastavite sa izmenom artikla? 1. DA, 2. NE (Vrati se na pocetni meni)");
                                Console.WriteLine(" ");
                                String izborr = Console.ReadKey().KeyChar.ToString();
                                if (izborr == "1")
                                {
                                    proveraaa = true;
                                    continue;
                                }
                                    
                                else
                                {
                                    break;
                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("Uneta sifra artikla se ne poklapa sa siframa u magacinu!");
                                continue;
                            }
                        }
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
                if (unos == "4")
                    break;

            }

        }
    }
}
