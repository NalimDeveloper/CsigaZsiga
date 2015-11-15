using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CsigaZsiga
{
    class Testresz :IElem
    {
        protected int _x;
        protected int _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public void Mozog()
        {

            X++;
            Y = 5;
            ToString();

        }

        //public bool Utkozik(Alma a)
        //{


        //    if (a.X == X && a.Y == Y)
        //    {
        //        return true;
        //    }
        //    else return false;

        //}

        public void ToString()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine('@');
            Console.ResetColor();
        }

        public Testresz()
        {
            X = 5;
            Y = 5;
        }
    }
}
