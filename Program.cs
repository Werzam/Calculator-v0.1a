using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("! Works only with 2 numbers !");
            Console.WriteLine("Press Enter to continue");
            Console.Read();
            Console.Clear();

            int x = 0;//Cursor cordinates X axis
            int y = 0;//Cursor cordinates Y axis
            string TextLine = "";
            char Action='1';
            double result;





      
            //
            //Console graphics
            //

            DrawBox frame = new DrawBox();
            frame.DrawFrame();

            //Buttons
            //
            DrawButtons buttons = new DrawButtons();
            buttons.Draw();

            //Calc logo
            Logo lg = new Logo();
            lg.DrawLogo();

            //
            //Console graphics end
            //

            Console.SetCursorPosition(17,11); //Reseting cursor position on start
            x = 17;
            y = 11;


            //
            //Cursor movement
            //
            ConsoleKey key;
            while ((key = Console.ReadKey(true).Key) != ConsoleKey.Escape)//Programm works until escape
            {


                while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
                {
                    try
                    {

                        switch (key)
                        {

                            case ConsoleKey.RightArrow:
                                Console.SetCursorPosition(x += 7, y);
                                break;
                            case ConsoleKey.LeftArrow:
                                Console.SetCursorPosition(x -= 7, y);
                                break;
                            case ConsoleKey.UpArrow:
                                Console.SetCursorPosition(x, y -= 4);
                                break;
                            case ConsoleKey.DownArrow:
                                Console.SetCursorPosition(x, y += 4);
                                break;
                            
                        }

                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.SetCursorPosition(x = 17, y = 11);
                    }

                }

                //
                //Cursor movement end
                //


                //
                //Data entry
                //

                if (Console.CursorTop == 11 & Console.CursorLeft == 17)//enters 1 into the calc textline
                {
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "1");
                    Console.SetCursorPosition(17, 11);
                }
                else if (Console.CursorTop == 11 & Console.CursorLeft == 24)//enters 2 into the calc textline
                {
                    
                    
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "2");
                    Console.SetCursorPosition(24, 11);

                    
                }
                else if (Console.CursorTop == 11 & Console.CursorLeft == 31)
                {

                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "3");
                    Console.SetCursorPosition(31, 11);

                }
                else if (Console.CursorTop == 15 & Console.CursorLeft == 17)
                {
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "4");
                    Console.SetCursorPosition(17, 15);
                }
                else if (Console.CursorTop == 15 & Console.CursorLeft == 24)
                {

                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "5");
                    Console.SetCursorPosition(24, 15);

                }
                else if (Console.CursorTop == 15 & Console.CursorLeft == 31)
                {

                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "6");
                    Console.SetCursorPosition(31, 15);

                }
                else if (Console.CursorTop == 19 & Console.CursorLeft == 17)
                {
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "7");
                    Console.SetCursorPosition(17, 19);
                }
                else if (Console.CursorTop == 19 & Console.CursorLeft == 24)
                {

                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "8");
                    Console.SetCursorPosition(24, 19);

                }
                else if (Console.CursorTop == 19 & Console.CursorLeft == 31)
                {

                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "9");
                    Console.SetCursorPosition(31, 19);

                }
                else if (Console.CursorTop == 19 & Console.CursorLeft == 38)
                {

                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "0");
                    Console.SetCursorPosition(38, 19);

                }
                else if (Console.CursorTop == 15 & Console.CursorLeft == 38)//enters  = in calc textline and calculates
                {
                    string[] numbers = TextLine.Split(new char[] { '+', '-', '*', '/', '√','^' }, StringSplitOptions.RemoveEmptyEntries);//TextLine numbers array
                    double FirstNumber = double.Parse(numbers[0]);
                    double SecondNumber = double.Parse(numbers[1]);


                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += " = ");


                    switch (Action)
                    {
                        case '-':
                            result = FirstNumber - SecondNumber;
                            Console.SetCursorPosition(12, 4);
                            Console.Write(TextLine += result);
                            break;
                        case '+':
                            result = FirstNumber + SecondNumber;
                            Console.SetCursorPosition(12, 4);
                            Console.Write(TextLine += result);
                            break;
                        case '*':
                            result = FirstNumber * SecondNumber;
                            Console.SetCursorPosition(12, 4);
                            Console.Write(TextLine += result);
                            break;
                        case '/':
                            result = FirstNumber / SecondNumber;
                            Console.SetCursorPosition(12, 4);
                            Console.Write(TextLine += result);
                            break;
                        case '^':
                            result = Math.Pow(FirstNumber,SecondNumber);
                            Console.SetCursorPosition(12, 4);
                            Console.Write(TextLine += result);
                            break;

                    }


                    Console.SetCursorPosition(38, 15);



                }
                else if (Console.CursorTop == 19 & Console.CursorLeft == 59)
                {

                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += ",");
                    Console.SetCursorPosition(59, 19);

                }

                else if (Console.CursorTop == 11 & Console.CursorLeft == 45)
                {
                    
                   Action = '+';
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += " + ");
                    Console.SetCursorPosition(45, 11);

                }
                else if (Console.CursorTop == 11 & Console.CursorLeft == 52)
                {
                    
                   Action = '*';
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += " * ");
                    Console.SetCursorPosition(52, 11);

                }
                else if (Console.CursorTop == 15 & Console.CursorLeft == 45)
                {
                    
                    Action = '-';
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += " - ");
                    Console.SetCursorPosition(45, 15);

                }
                else if (Console.CursorTop == 15 & Console.CursorLeft == 52)
                {
                   
                    Action = '/';
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += " / ");
                    Console.SetCursorPosition(52, 15);

                }
                else if (Console.CursorTop == 19 & Console.CursorLeft == 45)
                {
                    string[] numbers = TextLine.Split(new char[] { '+', '-', '*', '/', '√' }, StringSplitOptions.RemoveEmptyEntries);//TextLine numbers array
                    double FirstNumber = double.Parse(numbers[0]);

                    Console.SetCursorPosition(12, 4);
                    result = Math.Sqrt(FirstNumber);
                    Console.WriteLine(TextLine = ""+result);
                    Console.SetCursorPosition(45, 19);
                
                }
                else if (Console.CursorTop == 19 & Console.CursorLeft == 52)
                {

                    Action = '^';
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "^");
                    Console.SetCursorPosition(52, 19);

                }
                else if (Console.CursorTop == 11 & Console.CursorLeft == 38)
                {

                    Console.SetCursorPosition(12, 4);
                    try
                    {
                        TextLine = "";
                        for (int i = 0; i < 66; i++)
                        {
                            Console.Write("░");
                        }
                        Console.WriteLine(TextLine);
                        Console.SetCursorPosition(38, 11);
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        Console.SetCursorPosition(38, 11);
                    }
                    
                }
               

                //
                //Data entry end
                //


            }
            Console.Clear();
            Console.WriteLine("Exit");
            Console.Read();
           
        }
    }
}
