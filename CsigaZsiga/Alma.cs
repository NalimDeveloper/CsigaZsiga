using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsigaZsiga
{
    class Alma : IElem
    {
        protected int _x;
        protected int _y;

        public int X { get { return _x; }
                       set { _x = value; }
        }
        public int Y { get { return _y; }
                       set { _y = value; }
        }

        public void Mozog()
        {
            ToString();
        }

        //public bool Utkozik(Testresz a)
        //{

        //    return false;   
        //}

        public void ToString() {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine('*');
            Console.ResetColor();
        }

        public Alma() {
           Random rnd = new Random();

            X = rnd.Next(1, 100);
            Y = 5;
        }
    }

}

