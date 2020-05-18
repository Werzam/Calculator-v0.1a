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
            Console.WriteLine("Press key to continue");
            Console.Read();
            Console.Clear();

            int x = 0;//Cursor cordinates X axis
            int y = 0;//Cursor cordinates Y axis
            string TextLine = "";
            char Action='1';
            int result;





        start:
            //
            //Console graphics
            //

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
            Console.SetCursorPosition(106, y +=2);
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
            Console.SetCursorPosition(80, y + 1 );
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

            //Buttons
            //

            //1
            Button one = new Button();
            one.xcord = 15;
            one.ycord = 10;
            one.symb = ('1');
            one.CalcButton();
            //2
            Button two = new Button();
            two.xcord = 22;
            two.ycord = 10;
            two.symb = ('2');
            two.CalcButton();
            //3
            Button three = new Button();
            three.xcord = 29;
            three.ycord = 10;
            three.symb = ('3');
            three.CalcButton();
            //4
            Button four = new Button();
            four.xcord = 15;
            four.ycord = 14;
            four.symb = ('4');
            four.CalcButton();
            //5
            Button five = new Button();
            five.xcord = 22;
            five.ycord = 14;
            five.symb = ('5');
            five.CalcButton();
            //6
            Button six = new Button();
            six.xcord = 29;
            six.ycord = 14;
            six.symb = ('6');
            six.CalcButton();
            //7
            Button seven = new Button();
            seven.xcord = 15;
            seven.ycord = 18;
            seven.symb = ('7');
            seven.CalcButton();
            //8
            Button eight = new Button();
            eight.xcord = 22;
            eight.ycord = 18;
            eight.symb = ('8');
            eight.CalcButton();
            //9
            Button nine = new Button();
            nine.xcord = 29;
            nine.ycord = 18;
            nine.symb = ('9');
            nine.CalcButton();

            //

            //C
            Button c = new Button();
            c.xcord = 36;
            c.ycord = 10;
            c.symb = ('C');
            c.CalcButton();
            //=
            Button equal = new Button();
            equal.xcord = 36;
            equal.ycord = 14;
            equal.symb = ('=');
            equal.CalcButton();
            //0
            Button zero = new Button();
            zero.xcord = 36;
            zero.ycord = 18;
            zero.symb = ('0');
            zero.CalcButton();

            //

            //summ
            Button summ = new Button();
            summ.xcord = 43;
            summ.ycord = 10;
            summ.symb = ('+');
            summ.CalcButton();
            //minus
            Button min = new Button();
            min.xcord = 43;
            min.ycord = 14;
            min.symb = ('-');
            min.CalcButton();
            //multiply
            Button mult = new Button();
            mult.xcord = 50;
            mult.ycord = 10;
            mult.symb = ('*');
            mult.CalcButton();
            //divide
            Button div = new Button();
            div.xcord = 50;
            div.ycord = 14;
            div.symb = ('/');
            div.CalcButton();

            //Calc logo
            Logo lg = new Logo();
            lg.Pic();

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
                            default:
                                Console.Clear();
                                Console.WriteLine("Use only arrows and Enter please");
                                Console.ReadKey();
                                Console.Clear();
                                goto start;


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
                    string[] numbers = TextLine.Split(new char[] { '+', '-', '*', '/', }, StringSplitOptions.RemoveEmptyEntries);//TextLine numbers array
                    int FirstNumber = int.Parse(numbers[0]);
                    int SecondNumber = int.Parse(numbers[1]);

                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "=");

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

                    }
                    

                    Console.SetCursorPosition(38, 15);



                }
                
                else if (Console.CursorTop == 11 & Console.CursorLeft == 45)
                {
                    
                   Action = '+';
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "+");
                    Console.SetCursorPosition(45, 11);

                }
                else if (Console.CursorTop == 11 & Console.CursorLeft == 52)
                {
                    
                   Action = '*';
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "*");
                    Console.SetCursorPosition(52, 11);

                }
                else if (Console.CursorTop == 15 & Console.CursorLeft == 45)
                {
                    
                    Action = '-';
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "-");
                    Console.SetCursorPosition(45, 15);

                }
                else if (Console.CursorTop == 15 & Console.CursorLeft == 52)
                {
                   
                    Action = '-';
                    Console.SetCursorPosition(12, 4);
                    Console.WriteLine(TextLine += "/");
                    Console.SetCursorPosition(52, 15);

                }
                else if (Console.CursorTop == 11 & Console.CursorLeft == 38)
                {

                    Console.SetCursorPosition(12, 4);
                    try
                    {
                        TextLine = TextLine.Remove(0);
                        for (int i = 0; i < 67; i++)
                        {
                            Console.Write("░");
                        }
                        Console.WriteLine(TextLine);
                        Console.SetCursorPosition(38, 11);
                    }
                    catch(System.ArgumentOutOfRangeException)
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
