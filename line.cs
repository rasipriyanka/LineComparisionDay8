using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    internal class line
    {
        public void LineComparision()
        {

            double Line,Line2;
       
            Console.WriteLine("Welcome To Line Comparision Computation Program");
            double x1, x2,y1,y2;
            Console.Write("Enter first point\t");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second point\t");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third point\t");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter fourth point\t");
            y2 = Convert.ToDouble(Console.ReadLine());

            Line=Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))) ;
            Console.WriteLine(Line);

            Console.Write("Enter first point\t");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second point\t");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third point\t");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter fourth point\t");
            y2 = Convert.ToDouble(Console.ReadLine());

            Line2=Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));
            Console.WriteLine(Line2);

            if (Line>Line2)
            {
                Console.WriteLine("Lines are greater than");
            }
            else if(Line<Line2)
            {
                Console.WriteLine("Lines are lesser");
            }
            else if(Line==Line2)
            {
                Console.WriteLine("lines are equal");

            }
            else
            {
                Console.WriteLine("default");
            }
        }

    }
}
