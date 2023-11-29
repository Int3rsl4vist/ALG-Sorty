using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Zadejte délku pole:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int delkaPole = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            int[] pole = new int[delkaPole];
            for (int i = 0; i < delkaPole - 1; i++)
            {
                pole[i] = random.Next(-100, 101);
            }
            Console.WriteLine("Neseřazené pole:");
            foreach (int cislo in pole)
            {
                Console.Write(cislo + "|");
            }
            Console.WriteLine("");
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
            for (int i = 0; i < pole.Length; i++)
            {
                int index = pole[i];
                int j;

                for (j = i - 1; j >= 0 && pole[j] > index; j--)
                {
                    pole[j + 1] = pole[j];
                }
                pole[j + 1] = index;
                Console.Write("\n");
                foreach (int cislo in pole)
                {
                    Console.Write(cislo + "|");
                }
            }
        }
    }
}
