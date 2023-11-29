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
            int[] pole = { -5, 8, -2, 3, -7, 6, 0, -9, 4, 1, 12, 19, -8, -23, 14};
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
