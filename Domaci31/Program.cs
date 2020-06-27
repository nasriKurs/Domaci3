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
                            bool provera = false;
                            for (var i = 0; i < ArtikliSifra.Count; i++)
                                if (ArtikliSifra[i] == sifraa)
                                {
                                    Console.WriteLine("Uneta sifra se uklapa sa vec postojecom sifrom!");
                                    provera = true;
                                }
                            if (provera)
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
                            Console.WriteLine("Sifra artikla, Naziv , Cena, Kolicina");
                            for (int i = 0; i < ArtikliSifra.Count; i++)
                                Console.WriteLine($"{ArtikliSifra[i]}, {ArtikliNaziv[i]}, {ArtikliCena[i]}, {ArtikalKolicina[i]}");
                            break;
                        }
                    case "3":
                        Console.WriteLine("------------Izmeni Artikal------------");
                        while (true)
                        {
                            Console.Write("Unesite sifru artikla: ");
                            int sifra = int.Parse(Console.ReadLine());
                            int brojac = 0;// brojac je potreban da bi videli da li postoji artikal sa unetom sifrom.
                            int index = 0;// index nam je potreban da bi sacuvao index liste.
                            for (int i = 0; i < ArtikliSifra.Count; i++)
                                if (sifra == ArtikliSifra[i])
                                {
                                    brojac++;
                                    index = i;
                                }
                            if (brojac == 1)
                            {
                                Console.WriteLine($"{ArtikliSifra[index]}, {ArtikliNaziv[index]}, {ArtikliCena[index]}, {ArtikalKolicina[index]}");
                                Console.Write("Unesite novo stanje kolicine datog artikla: ");
                                ArtikalKolicina[index] = int.Parse(Console.ReadLine());
                                Console.WriteLine("USPESNO STE IZMENILI KOLICINU ARTIKLA!");
                                break;
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
