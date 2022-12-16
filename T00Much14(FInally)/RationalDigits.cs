using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much14_FInally_
{
    [DeveloperInfoAttribute("Азат", "Дек 16, 2022")]
    public class RationalDigits
    {
        public int Chislitel { get; set; }
        public int Znamenatel { get; set; }
        public RationalDigits(int n, int m)
        {
            Chislitel = n;
            Znamenatel = m;
        }
        public RationalDigits() { }
        public static bool operator ==(RationalDigits d1, RationalDigits d2)
        {
            return d1.Chislitel == d2.Chislitel && d1.Znamenatel == d2.Znamenatel;
        }
        public static bool operator !=(RationalDigits d1, RationalDigits d2)
        {
            return d1.Chislitel != d2.Chislitel || d1.Znamenatel != d2.Znamenatel;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is RationalDigits d1)
                return Chislitel == d1.Chislitel && Znamenatel == d1.Znamenatel;
            return false;
        }
        public static bool operator >(RationalDigits d1, RationalDigits d2)
        {
            return d1.Chislitel * d2.Znamenatel > d2.Chislitel * d1.Znamenatel;
        }
        public static bool operator <(RationalDigits d1, RationalDigits d2)
        {
            return d1.Chislitel * d2.Znamenatel < d2.Chislitel * d1.Znamenatel;
        }
        public static bool operator <=(RationalDigits d1, RationalDigits d2)
        {
            return d1.Chislitel / d1.Znamenatel <= d2.Chislitel / d2.Znamenatel;
        }
        public static bool operator >=(RationalDigits d1, RationalDigits d2)
        {
            return d1.Chislitel / d1.Znamenatel >= d2.Chislitel / d2.Znamenatel;
        }
        public static RationalDigits operator +(RationalDigits d1, RationalDigits d2)
        {
            return new RationalDigits()
            {
                Chislitel = (d1.Chislitel * d2.Znamenatel + d2.Chislitel * d1.Znamenatel),
                Znamenatel = (d1.Znamenatel * d2.Znamenatel)
            };
        }
        public static RationalDigits operator -(RationalDigits d1, RationalDigits d2)
        {
            return new RationalDigits()
            {
                Chislitel = (d1.Chislitel * d2.Znamenatel - d2.Chislitel * d1.Znamenatel),
                Znamenatel = (d1.Znamenatel * d2.Znamenatel)
            };
        }
        public static RationalDigits operator ++(RationalDigits d1)
        {
            return new RationalDigits() { Chislitel = d1.Chislitel += d1.Znamenatel, Znamenatel = d1.Znamenatel };
        }
        public static RationalDigits operator --(RationalDigits d1)
        {

            return new RationalDigits() { Chislitel = d1.Chislitel -= d1.Znamenatel, Znamenatel = d1.Znamenatel };
        }
        public override string ToString()
        {
            string t = $"{Chislitel} / {Znamenatel}";
            return t;
        }
    }
}
