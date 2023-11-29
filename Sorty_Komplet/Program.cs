using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorty_Komplet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Zadejte délku pole:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int delkaPole = int.Parse(Console.ReadLine());
            Console.ForegroundColor= ConsoleColor.White;
            int[] pole = new int[delkaPole];
            for (int i = 0; i < delkaPole -1; i++)
            {
                pole[i] = random.Next(-100, 101);
            }
            Console.WriteLine("Neseřazené pole:");
            foreach (int cislo in pole)
            {
                Console.Write(cislo + "|");
            }
            while (true)
            {
                Console.WriteLine("\nJaký sort má setřídit pole?");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string vyberSortu = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                switch (vyberSortu)
                {
                    case "BubbleSort":
                        BubbleSort(pole); break;
                    case "SelectSort":
                        SelectSort(pole); break;
                    case "InsertSort":
                        InsertSort(pole); break;
                    default:
                        Console.WriteLine("Blbě :P"); break;
                }
                Console.WriteLine("\n \nSeřazené pole:");
                foreach (int cislo in pole)
                {
                    Console.Write(cislo + "|");
                }
                Console.Write("\n");
            }
        }
        #region BubbleSort
        static void BubbleSort(int[] pole)
        {
            for (int i = 0; i < pole.Length - 1; i++)
            {
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
                foreach (int cislo in pole)
                {
                    Console.Write(cislo + "|");
                }
            }
        }
        #endregion
        #region SelectSort
        static void SelectSort(int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
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
                foreach (int cislo in pole)
                {
                    Console.Write(cislo + "|");
                }
            }
        }
        #endregion
        #region InsertSort
        static void InsertSort(int[] pole)
        {
            
            for (int i = 0; i < pole.Length; i++)
            {
                int index = pole[i];
                int j;

                // Přesunout prvky pole, které jsou větší než key, na jednu pozici dopředu
                for (j = i - 1; j >= 0 && pole[j] > index; j--)
                {
                    pole[j + 1] = pole[j];
                }
                pole[j+1] = index;
                Console.Write("\n");
                foreach (int cislo in pole)
                {
                    Console.Write(cislo + "|");
                }
            }
        }
        #endregion
    }
}
