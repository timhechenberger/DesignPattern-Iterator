using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Iterator
{
    internal interface Iterator
    {
        string? next();
        bool hasNext();
    }
}
