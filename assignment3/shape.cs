using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public interface Shape
    {
        double Area { get; }

        string Info { get; }

        bool isValid();
    }
}
