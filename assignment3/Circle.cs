using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area
        {
            get
            {
                if (!isValid())
                {
                    return 0;
                }
                return Math.PI * radius * radius;
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
                return "Circle: radius = " + radius;
            }
        }

        public bool isValid()
        {
            if (radius <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
