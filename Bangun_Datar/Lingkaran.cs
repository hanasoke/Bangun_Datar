using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bangun_Datar
{
    internal class Lingkaran
    {
        public double keliling(double r)
        {
            return 2 * Math.PI * r;
        }

        public double luas(double r)
        {
            return Math.PI * r * r;
        }

    }
}
