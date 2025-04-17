using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Square : Shape
    {
        double sideLength { get; set; }

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public bool isValid()
        {
            if (sideLength <= 0)
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
                if(!isValid())
                {
                    return 0;
                }
                return sideLength * sideLength;
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
                return "Square: sideLength = " + sideLength;
            }
        }
    }
}
