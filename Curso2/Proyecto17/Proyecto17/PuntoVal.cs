﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto17
{
    internal struct PuntoVal
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PuntoVal(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}
