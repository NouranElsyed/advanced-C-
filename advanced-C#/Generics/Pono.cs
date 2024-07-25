using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_C_.Generics
{
    internal class Pono : IComparable<Pono>
    {
        public int X {  get; set; } 

        public int Y { get; set; }
        public Pono(int x, int y) 
        {
        X = x;
        Y = y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        public int CompareTo(Pono? other)
        {
            if (other is null)
                return 1;
            if (X == other.X)
                return Y.CompareTo(other.Y);
            else
                return X.CompareTo(other.X);
        }
    }
}
