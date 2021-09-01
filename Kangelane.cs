using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelane_K
{
    class Kangelane
    {
        private string _nimi;
        private string _asukoht;

        public Kangelane(string nimi, string asukoht)
        {
            _nimi = nimi;
            _asukoht = asukoht;
        }
        public string GetNimi() { return _nimi; }
        public void SetNimi(string uusNimi) { _nimi = uusNimi; }
        public string GetAsukoht() { return _asukoht; }
        public void SetAsukoht(string uusAsukoht) { _asukoht = uusAsukoht; }

        public virtual int Päästa(int ohustatuid)
        {
            return ohustatuid * 95 / 100;
        }
        public override string ToString()
        {
            return $"{_nimi} kaitseb linn - {_asukoht}!";
        }
    }
}
