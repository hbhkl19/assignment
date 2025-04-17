using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    internal class Triangle : Shape
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool isValid()
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            else if(a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double Area
        {
            get
            {
                if (!isValid())
                {
                    return 0;
                }
                double s = (a + b + c) / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
        }

        public string Info
        {
            get
            {
                if (!isValid())
                {
                    return "形状无效";
                }
                return "Triangle: a = " + a + ", b = " + b + ", c = " + c;
            }
        }
    }
}
