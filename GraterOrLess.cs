using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class GraterOrLess
    {
        internal void GraterOrLessThen()
        {
            Console.WriteLine("Enter x1,x2,y1,y2 :");

            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a1,a2,b1,b2:=");

            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());


            double L_XY = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of 1st Line :" + L_XY);

            Console.WriteLine();
            double L_AB = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Length of 1st Line :" + L_AB);

            //if (L_XY == L_AB)
            //{
            //   Console.WriteLine("Equeals are two line");                
            // }
            //else
            //{
            //Console.WriteLine("Two Lines Are not Equals");
            //}

            if (L_XY > L_AB)
            {
                Console.WriteLine("1st Line is Gratet to 2nd Line");
            }
            else
            {
                Console.WriteLine("2nd line is grater to 1st line");
            }

        }

    }
}