using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Rectangle : Shape
    {
        public double length{ get; set; }

        public double width { get; set; }

        //构造函数
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Area
        {
            get
            {
                if (!isValid())
                {
                    return 0;
                }
                return length * width;
            }
        }

        public string Info
        {
            get
            {
                if(!isValid())
                {
                    return "形状无效";
                }
                return "Rectangle: length = " + length + ", width = " + width;
            }
        }

        public bool isValid()
        {
            if (length <= 0 || width <= 0)
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
