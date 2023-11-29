using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SelectSort
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
            Console.Write("\n");
            Sort(pole);
            Console.WriteLine("\n \nSeřazené pole:");
            foreach (int cislo in pole)
            {
                Console.Write(cislo + "|");
            }
            Console.Write("\n");
        }

        static void Sort(int[] pole)
        {
            for(int i = 0; i < pole.Length; i++)
            {
                for (int j = 0; j < pole.Length - 1 - i; j++) 
                {
                    if (pole[j] < pole[j+1])
                    {
                        int prozatimni = pole[j];
                        pole[j] = pole[j+1];
                        pole[j+1] = prozatimni;
                    }
                }
                Console.Write("\n");
                foreach(int cislo in pole)
                {
                    Console.Write(cislo + "|");
                }
            }
        }
    }
}
