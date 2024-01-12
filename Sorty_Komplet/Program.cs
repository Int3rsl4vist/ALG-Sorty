using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorty_Komplet
{
    internal class Program
    {
        public List<string> seznamCasu = new List<string>();
        static void Main(string[] args)
        {
            string cesta = "C:/Users/inter/OneDrive/Plocha/ALG/Sorty_Komplet/zápis.txt";
            File.WriteAllText(cesta, String.Empty);
            #region Generování zadaného počtu náhodných hodnot
            Random random = new Random();
            // Dotáže se na délku pole (počet čísel v poli)
            Console.WriteLine("Zadejte délku pole:\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int delkaPole = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.ForegroundColor= ConsoleColor.White;
            // Vytvoří pole o dané délce
            int[] pole = new int[delkaPole];
            // Vloží náhodné hodnoty do pole
            for (int i = 0; i < delkaPole -1; i++)
            {
                pole[i] = random.Next(-100, 101);
            }
            #endregion
            // Vypíše neseřazené pole
            Console.WriteLine("Neseřazené pole:");
            foreach (int cislo in pole)
            {
                Console.Write(cislo + "|");
            }
            Console.WriteLine("");
            while (true)
            {
                // Dotáže se na typ sortu pro řešení, a uloží ho do proměnné
                Console.WriteLine("\nJaký sort má setřídit pole?");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string inputSortu = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                // Zaručí, aby mohl vstup být napsán jakkoliv
                string vyberSortu = inputSortu.ToLower();
                // Podle vstupu rozhodne, jaký sort použít
                switch (vyberSortu)
                {
                    case "bubblesort": 
                    case "bubble":
                        BubbleSort(pole); break;
                    case "selectsort":
                    case "select":
                        SelectSort(pole); break;
                    case "insertsort":
                    case "insert":
                        InsertSort(pole); break;
                    // Pokud vstup neodpovídá žádnému sortu, dotáže se znovu
                    default:
                        Console.WriteLine("Nope :P"); break;
                }
            }
        }
        #region BubbleSort
        public static void BubbleSort(int[] pole)
        { 
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int krok = 0;
            for (int i = 0; i < pole.Length - 1; i++)
            {
                krok++;
                for (int j = 0; j < pole.Length - 1 - i; j++)
                {
                    if (pole[j] > pole[j + 1])
                    {
                        int prozatimni = pole[j];
                        pole[j] = pole[j + 1];
                        pole[j + 1] = prozatimni;
                    }
                }
                Console.Write("\n");
                Console.WriteLine("Krok " + krok + ":\n");
                foreach (int cislo in pole)
                {
                    Console.Write(cislo + "|");
                }
                Console.WriteLine("");
            }
            sw.Stop();
            // Vypíše seřazené pole
            Console.WriteLine("\n \nSeřazené pole:");
            foreach (int cislo in pole)
            {
                Console.Write(cislo + "|");
            }
            Console.Write("\n");
            
            Console.WriteLine("\nSort trval: " + sw.ElapsedMilliseconds + " milisekund.");

            string cesta = "C:/Users/inter/OneDrive/Plocha/ALG/Sorty_Komplet/zápis.txt";
            File.AppendAllText(cesta, "BubbleSort srovnal pole za " + sw.ElapsedMilliseconds + " milisekund\n");
        }
        #endregion
        #region SelectSort
        public static void SelectSort(int[] pole)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int krok = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                krok++;
                for (int j = 0; j < pole.Length - 1 - i; j++)
                {
                    if (pole[j] < pole[j + 1])
                    {
                        int prozatimni = pole[j];
                        pole[j] = pole[j + 1];
                        pole[j + 1] = prozatimni;
                    }
                }
                Console.Write("\n");
                Console.WriteLine("Krok " + krok + ":\n");
                foreach (int cislo in pole)
                {
                    Console.Write(cislo + "|");
                }
                Console.WriteLine("");
            }
            sw.Stop();
            // Vypíše seřazené pole
            Console.WriteLine("\n \nSeřazené pole:");
            foreach (int cislo in pole)
            {
                Console.Write(cislo + "|");
            }
            Console.Write("\n");

            Console.WriteLine("\nSort trval: " + sw.ElapsedMilliseconds + " milisekund.");
            
            string cesta = "C:/Users/inter/OneDrive/Plocha/ALG/Sorty_Komplet/zápis.txt";
            File.AppendAllText(cesta, "SelectSort srovnal pole za " + sw.ElapsedMilliseconds + " milisekund\n");
        }
        #endregion
        #region InsertSort
        public static void InsertSort(int[] pole)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int krok = 0;
            // Prochází pole po jednotlivých indexech
            for (int i = 0; i < pole.Length; i++)
            {
                int index = pole[i];
                int j;
                krok++;
                // Prohazuje na pozici "x + 1" s číslem na pozici "x"
                for (j = i - 1; j >= 0 && pole[j] > index; j--)
                {
                    pole[j + 1] = pole[j];
                }
                pole[j+1] = index;
                Console.Write("\n");
                // Výpis kroku
                Console.WriteLine("Krok " + krok + ":\n");
                // Postupný výpis celého pole
                foreach (int cislo in pole)
                {
                    Console.Write(cislo + "|");
                }
                Console.WriteLine("");
            }
            sw.Stop();
            // Vypíše seřazené pole
            Console.WriteLine("\n \nSeřazené pole:");
            foreach (int cislo in pole)
            {
                Console.Write(cislo + "|");
            }
            Console.Write("\n");
            Console.WriteLine("\nSort trval: " + sw.ElapsedMilliseconds + " milisekund.");
            string cesta = "C:/Users/inter/OneDrive/Plocha/ALG/Sorty_Komplet/zápis.txt";
            File.AppendAllText(cesta, "InsertSort srovnal pole za " + sw.ElapsedMilliseconds + " milisekund\n");
        }
        #endregion
    }
}
