using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamestnanciSestavy
{
    internal class Zamestnanec
    {
        private string jmeno;
        private string prijmeni;
        private int pocetHodin;
        private bool jeVedouci;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="pocetHodin"></param>
        /// <param name="jeVedouci"></param>
        public Zamestnanec(string jmeno, string prijmeni, int pocetHodin, bool jeVedouci)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            PocetHodin = pocetHodin;
            JeVedouci = jeVedouci;
        }

        public string Jmeno { get => jmeno;         set { jmeno = value; } }
        public string Prijmeni { get => prijmeni;   set { prijmeni = value; } }
        public int PocetHodin { get => pocetHodin;  set { pocetHodin = Math.Max(0, value); } }
        public bool JeVedouci { get => jeVedouci;   set { jeVedouci = value; } }

        public override string ToString()
        {
            return $"{jmeno} {prijmeni}, {pocetHodin}h" + (jeVedouci ? $" VEDOUCÍ" : "");
        }
        public string ToCsv()
        {
            return $"{jmeno};{prijmeni};{pocetHodin};{jeVedouci}";
        }
    }
}
