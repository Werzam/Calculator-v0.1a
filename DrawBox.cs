using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class DrawBox
    {
       public int x = 0;//Cursor cordinates X axis
       public int y = 0;//Cursor cordinates Y axis
        public void DrawFrame()
        {
          

        //Main field
        //

        //Upper line
        Console.SetCursorPosition(5, 1);
            Console.Write("╔");
            Console.SetCursorPosition(6, 1);
            for (int StringUp = 0; StringUp <= 100; StringUp++)
            {
                Console.Write("═");
            }
            Console.SetCursorPosition(106, 1);
            Console.Write("╗");


            //Lower line
            Console.SetCursorPosition(5, 27);
            for (int StringDown = 0; StringDown <= 100; StringDown++)
            {
                Console.Write("═");
            }


            //Right line
            Console.SetCursorPosition(106, y += 2);
            for (int VertRight = 0; VertRight <= 24; VertRight++)
            {
                Console.WriteLine("║");
                Console.SetCursorPosition(106, y += 1);
            }
            Console.SetCursorPosition(106, 27);
            Console.Write("╝");

            y = 0;
            //Left line
            Console.SetCursorPosition(5, y += 2);
            for (int VertLeft = 0; VertLeft <= 25; VertLeft++)
            {
                Console.WriteLine("║");
                Console.SetCursorPosition(5, y += 1);
            }
            Console.SetCursorPosition(5, 27);
            Console.Write("╚");

            //Entry field
            //

            //Upper line
            Console.SetCursorPosition(10, 3);
            for (int StringUp = 0; StringUp <= 70; StringUp++)
            {
                Console.Write("═");
            }
            //Lower line
            Console.SetCursorPosition(10, 5);
            for (int StringUp = 0; StringUp <= 70; StringUp++)
            {
                Console.Write("═");
            }
            //Right line
            y = 0;
            Console.SetCursorPosition(80, y += 3);
            Console.Write("╗");
            Console.SetCursorPosition(80, y += 1);
            Console.WriteLine("║");
            Console.SetCursorPosition(80, y + 1);
            Console.WriteLine("╝");
            //Left line
            y = 0;
            Console.SetCursorPosition(10, y += 3);
            Console.Write("╔");
            Console.SetCursorPosition(10, y += 1);
            Console.WriteLine("║");
            Console.SetCursorPosition(10, y + 1);
            Console.WriteLine("╚");
            //Inline
            Console.SetCursorPosition(12, 4);
            for (int StringUp = 0; StringUp <= 66; StringUp++)
            {
                Console.Write("░");
            }
        }
    }
}
