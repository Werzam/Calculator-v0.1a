using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class DrawButtons
    {

        public void Draw()
        {
            //1
            Button one = new Button();
            one.xcord = 15;
            one.ycord = 10;
            one.symb = ('1');
            one.DrawButton();
            //2
            Button two = new Button();
            two.xcord = 22;
            two.ycord = 10;
            two.symb = ('2');
            two.DrawButton();
            //3
            Button three = new Button();
            three.xcord = 29;
            three.ycord = 10;
            three.symb = ('3');
            three.DrawButton();
            //4
            Button four = new Button();
            four.xcord = 15;
            four.ycord = 14;
            four.symb = ('4');
            four.DrawButton();
            //5
            Button five = new Button();
            five.xcord = 22;
            five.ycord = 14;
            five.symb = ('5');
            five.DrawButton();
            //6
            Button six = new Button();
            six.xcord = 29;
            six.ycord = 14;
            six.symb = ('6');
            six.DrawButton();
            //7
            Button seven = new Button();
            seven.xcord = 15;
            seven.ycord = 18;
            seven.symb = ('7');
            seven.DrawButton();
            //8
            Button eight = new Button();
            eight.xcord = 22;
            eight.ycord = 18;
            eight.symb = ('8');
            eight.DrawButton();
            //9
            Button nine = new Button();
            nine.xcord = 29;
            nine.ycord = 18;
            nine.symb = ('9');
            nine.DrawButton();

            //

            //C
            Button c = new Button();
            c.xcord = 36;
            c.ycord = 10;
            c.symb = ('C');
            c.DrawButton();
            //=
            Button equal = new Button();
            equal.xcord = 36;
            equal.ycord = 14;
            equal.symb = ('=');
            equal.DrawButton();
            //0
            Button zero = new Button();
            zero.xcord = 36;
            zero.ycord = 18;
            zero.symb = ('0');
            zero.DrawButton();
            //sqrt
            Button sqrt = new Button();
            sqrt.xcord = 43;
            sqrt.ycord = 18;
            sqrt.symb = ('√');
            sqrt.DrawButton();

            //

            //summ
            Button summ = new Button();
            summ.xcord = 43;
            summ.ycord = 10;
            summ.symb = ('+');
            summ.DrawButton();
            //minus
            Button min = new Button();
            min.xcord = 43;
            min.ycord = 14;
            min.symb = ('-');
            min.DrawButton();
            //multiply
            Button mult = new Button();
            mult.xcord = 50;
            mult.ycord = 10;
            mult.symb = ('*');
            mult.DrawButton();
            //divide
            Button div = new Button();
            div.xcord = 50;
            div.ycord = 14;
            div.symb = ('/');
            div.DrawButton();
            //power
            Button pow = new Button();
            pow.xcord = 50;
            pow.ycord = 18;
            pow.symb = ('^');
            pow.DrawButton();
            //dot
            Button dot = new Button();
            pow.xcord = 57;
            pow.ycord = 18;
            pow.symb = (',');
            pow.DrawButton();

        }

    }
}
