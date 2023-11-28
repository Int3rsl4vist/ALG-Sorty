using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = {-5,8,-2,3,-7,6,0,-9,4,1};
            Console.WriteLine("Neseřazené pole:");
            foreach (int cislo in pole)
            {
                Console.Write(cislo + "|");
            }

            BubbleSort(pole);
            Console.WriteLine("\n \nSeřazené pole:");
            foreach(int cislo in pole)
            {
                Console.Write(cislo + "|");
            }
            Console.WriteLine("\n");
        }

        static void BubbleSort(int[] pole)
        {
            for(int i = 0; i< pole.Length - 1; i++)
            {
                if (pole[i] > pole[i+1])
                {
                    int prozatimni = pole[i];
                    pole[i] = pole[i+1];
                    pole[i+1] = prozatimni;
                }
            }
        }
    }
}
