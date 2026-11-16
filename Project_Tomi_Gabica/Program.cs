using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tomi_Gabica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Üdvözöllek a játékban!\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Segíts Pityunak hogy átmenjen legalább egy éretségi tantárgyból\n");
            
            Console.ResetColor();
        valaszTant:
            Console.ResetColor(); Console.WriteLine("Válasz egy tantárgyat: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Magyar Irodalom");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Matematika");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Történelem");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Angol Nyelv");
            Console.ResetColor();
            int magypontszam = 0;
            int matpont =0;
            int angpont = 0;
            int torpont = 0;
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Pityu: ");
            string valaszTan = Console.ReadLine();

            if (valaszTan.ToLower() == "magyar irodalom")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Elkezdted a Magyar éretségi feladat sorját");
            maelso:
                Console.WriteLine("\nElső Kérdés: Ki írta a 'Toldi estélye' Című verset?  (a :Arany János | b :Petőfi Sándor | c :Jókai Mór)");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                Console.ResetColor();
                
                string valasztasJobbBal = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                switch (valasztasJobbBal)
                {   
                    
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); magypontszam++; break; 
                   
                    case "b": Console.ResetColor();Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto maketto;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto maketto;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto maelso;
                }
                Console.ResetColor();
                
            maketto:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nMásodik Kérdés: Mikor írta Petőfi Sándor a Nemzeti dalt? (a :1850. | b :1844. | c :1848. ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto maharom;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto maharom;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); magypontszam++; break;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto maketto;
                }
            maharom:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n Kinek írt főként szerelmi verseket Balassi Bálint? (a :Losonczi Anna | b :Kis Júlia | c :Szabó Margit ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); magypontszam++; break;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto manegy;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto manegy;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto maharom;
                }
            manegy:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n A Görög mitológiában hogy hívják a tengerek istenét? (a :Zeusz | b :Poszeidon | c :Artemisz ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnos nem találtad el."); break;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); magypontszam++; break;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnos nem találtad el."); break;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto manegy;
                }

                if (magypontszam == 4)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Hibátlanul átmentél a Magyar Irodalom Vizsgán");
                    goto valaszTant;
                }

                else if (magypontszam == 3)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Átmentél a Magyar Irodalom vizsgán");
                    goto valaszTant;
                }
                else if (magypontszam == 2)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Éppen hogy átmentél jó szível a Magyar Irodalom vizsgán");
                    goto valaszTant;
                }
                else
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnáljuk de nem mentél át a Magyar Irodalom vizsgán");
                    goto valaszTant;
                }

            }
            
            else if (valaszTan.ToLower() == "matematika")
            {
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Elkezdted a Matematika éretségi feladat sorját");
            melso:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nMennyi 3+9?  (a :12 | b :11 | c :13)");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                string valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); matpont++; break;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto mketto;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto mketto;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto melso;
                }

            mketto:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nMennyi 8*(9+1)? (a :92 | b :51 | c :80 ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto mharom;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto mharom;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); matpont++; break;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto mketto;
                }
            mharom:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n Mennyi 6+7*10 (a :76 | b :67 | c :69 ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); matpont++; break;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto mnegy;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto mnegy;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto mharom;
                }
            mnegy:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n Mennyi 3*100+32 (a :350 | b :332 | c :333 ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnos nem találtad el."); break;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); matpont++; break;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnos nem találtad el."); break;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto mnegy;
                }

                if (matpont == 4)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Hibátlanul átmentél a Matematika Vizsgán");
                    goto valaszTant;
                }

                else if (matpont == 3)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Átmentél a Matematika vizsgán");
                    goto valaszTant;
                }
                else if (matpont == 2)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Éppen hogy átmentél jó szível a Matematika vizsgán");
                    goto valaszTant;
                }
                else
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnáljuk de nem mentél át a Matematika vizsgán");
                    goto valaszTant;
                }
            }
            else if (valaszTan.ToLower() == "történelem")
            {
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("Elkezdted a Történelem éretségi feladat sorját");
            telso:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\nElső Kérdés:Mikor kezdődött a honfoglalás?  (a :895. | b :890. | c :980)");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                string valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); torpont++; break;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto tketto;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto tketto;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto telso;
                }

            tketto:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\nMásodik kérdés: Ki volt az árvizi hajós? (a :Kossuth Lajos | b :Szechenyi István | c :Wesselényi Miklós ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto tharom;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto tharom;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); torpont++; break;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto tketto;
                }
            tharom:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n Harmadik kérdés: Mit szavalt el Petőfi Sádor Március 15.-én (a :13 pontot | b :11 pontot | c :12 pontot ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); torpont++; break;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto tnegy;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto tnegy;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto tharom;
                }
            tnegy:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n Ki ötlete volt a Lánc híd megépítése? (a :Hunyadi Mátyás | b :SZéchenyi István | c :Kossuth Lajos ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnos nem találtad el."); break;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); torpont++; break;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnos nem találtad el."); break;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto tnegy;
                }

                if (torpont == 4)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Hibátlanul átmentél a Történelem Vizsgán");
                    goto valaszTant;
                }

                else if (torpont == 3)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Átmentél a Történelem vizsgán");
                    goto valaszTant;
                }
                else if (torpont == 2)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Éppen hogy átmentél jó szível a Történelem vizsgán");
                    goto valaszTant;
                }
                else
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnáljuk de nem mentél át a Történelem vizsgán");
                    goto valaszTant;
                }
            }
            else if (valaszTan.ToLower() == "angol nyelv")
            {
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Elkezdted az Angol Nyelv éretségi feladat sorját");
            aelso:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("\nElső Kérdés:Hogy van 'Vödör' angolul?  (a :Bucket | b :Bed | c :Banana)");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                string valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); angpont++; break;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto aketto;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto aketto;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto aelso;
                }

            aketto:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("\nMásodik kérdés: hogy van az 'óra' angolul? (a :Cat | b :Cloak | c :Clock ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto aharom;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto aharom;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); angpont++; break;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto aketto;
                }
            aharom:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("\n Harmadik kérdés: Mi a 'Skull' magyarul? (a :Koponya | b :Kard | c :Iskola ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); angpont++; break;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto anegy;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nem jó válasz"); goto anegy;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto aharom;
                }
            anegy:
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("\n Negyedik kérdés: Mi a 'Book' magyarul? (a :Bukás | b :Könyv | c :Jár ");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Pityu: ");
                valasztasJobbBal = Console.ReadLine();
                switch (valasztasJobbBal)
                {
                    case "a": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnos nem találtad el."); break;
                    case "b": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gratulálok eltaláltad."); angpont++; break;
                    case "c": Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnos nem találtad el."); break;
                    default: Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto aharom;
                }

                if (angpont == 4)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Hibátlanul átmentél a Angol Nyelv Vizsgán");
                    goto valaszTant;
                }

                else if (angpont == 3)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Átmentél a Angol Nyelv vizsgán");
                    goto valaszTant;
                }
                else if (angpont == 2)
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Éppen hogy átmentél jó szível a Angol Nyelv vizsgán");
                    goto valaszTant;
                }
                else
                {
                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Sajnáljuk de nem mentél át a Angol Nyelv vizsgán");
                    goto valaszTant;
                }
            }
            else 
            {
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nincs ilyen választási lehetöség."); goto valaszTant;
                
            }






            
        }
    }
}
