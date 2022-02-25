using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class CartesianSystem
    {
        public void Length()
        {

            Console.WriteLine("Enter x1,x2,y1,y2 :");

            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter x,y of 2nd line");


            double L_xy = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of 1st Line :" + L_xy);

            Console.WriteLine();
            //double L_sr = Math.Sqrt(Math.Pow((s2 - s1), 2) + Math.Pow((r2 - r1), 2));
            // Console.WriteLine("Length of 1st Line :" + L_sr);
        }

    }

}