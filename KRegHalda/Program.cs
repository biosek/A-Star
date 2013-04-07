using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int n = 35;
            Knihovna.Vrchol[,] pole = new Knihovna.Vrchol[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    pole[i, j] = new Vrchol(i, j);
                }
            }

            int k = 5;
            for (int i = 5; i < n - 1; i++)
            {
                pole[i, k].walkable = false;
                pole[i, k].type = 1;
                pole[i, k+1].walkable = false;
                pole[i, k+1].type = 1;
                pole[i, n-i].walkable = false;
                pole[i, n-i].type = 1;
                pole[i, n - i + 1].walkable = false;
                pole[i, n - i + 1].type = 1;
                k++;
            }

            List<Vrchol> pom = Knihovna.PathFindMriz(pole[0, 0], pole[18, 20], ref pole, n);
            if (pom != null)
                foreach (Vrchol item in pom)
                {
                    item.type = 2;
                }
            else Console.WriteLine("Cesta nenalezena");

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    switch (pole[i, j].type)
                    { 
                        case 0:
                            Console.Write(". ");
                            break;
                        case 1:
                            Console.Write("x ");
                            break;
                        case 2:
                            Console.Write("* ");
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Konec");
            Console.ReadLine();*/
        }
    }
}