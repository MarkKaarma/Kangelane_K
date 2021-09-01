using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelane_K
{

    class SuperKangelane : Kangelane
    {
        private double _db;
        private readonly Random _rnd = new Random() ;
        public SuperKangelane(string nimi, string asukoht) : base(nimi, asukoht)
        {
            _db = _rnd.NextDouble() * (5 - 1) + 1;
        }
        public override int Päästa(int ohustatuid)
        {
            return Convert.ToInt32(ohustatuid * (95 + _db) / 100);

        }
        public override string ToString()
        {
            return base.ToString() + $"\nLisaks on ta {_db:N2}% võimekam kui tavakangelane.";
        }
    }
}
