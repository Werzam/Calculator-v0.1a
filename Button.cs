using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Button
    {
        public int xcord, ycord;
        public char symb;
        public void DrawButton()
        {
            
            Console.SetCursorPosition(xcord, ycord);
            Console.WriteLine("╔═══╗");
            Console.SetCursorPosition(xcord, ycord += 1);
            Console.WriteLine("║ " + symb + " ║");
            Console.SetCursorPosition(xcord, ycord += 1);
            Console.WriteLine("╚═══╝");

        }
    }
}
