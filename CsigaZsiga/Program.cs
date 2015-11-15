using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;



namespace CsigaZsiga
{
    class Program
    {


  
        private static void Jatek() {
            //A játék inicializálása
            Alma a = new Alma();
            Testresz t = new Testresz();

            //A játék motorja
            do
            {
                Console.Clear();
                Rajzol();
                a.Mozog();
                t.Mozog();
                Thread.Sleep(10);
            } while (!JatekVege(a, t));

        }

        private static bool JatekVege(Alma a, Testresz t)
        {
            if (t.X == a.X)
            {
                return true;
            }
            else if (t.Y < 0) return true;
            else if (t.Y > 19) return true;
            else if (t.X < 0) return true;
            else if (t.X > 99) return true;

            else return false;
        }


        static void Rajzol() {
            for (int i = 0; i < 20; i++) {
                for (int j = 0; j < 100; j++) {
                    if (i == 0) Console.Write("X");
                    else if (i == 19) Console.Write("X");
                    else if (j == 0) Console.Write("X");
                    else if (j == 99) Console.Write("X");
                    else Console.Write("\0");
                }
                Console.Write("\n");
            }
            


        }

        static void Main(string[] args)
        {


            //A játék motorja
            Jatek();

            //Eredmény hirdetés
            Console.Clear();
            Console.WriteLine("A játéknak vége!");
            Console.Read();

        }

       
    }
}
