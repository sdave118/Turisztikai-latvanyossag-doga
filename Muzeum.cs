using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turisztikai_látványosság
{
    internal class Muzeum : Latvanyossag
    {
        public Muzeum(string id,string orszag, string varos, string megnevezes, int nyitvaKezdet, int nyitvaVege, string tema, bool jogosultIngyenesUtazasra, double belepo) : base(id,orszag, varos, megnevezes, nyitvaKezdet, nyitvaVege)
        {
            Tema = tema;
            JogosultIngyenesUtazasra = jogosultIngyenesUtazasra;
            Belepo = belepo;
        }

        public string Tema { get; set; }
        public bool JogosultIngyenesUtazasra {get; set; }
        public double Belepo {get; set; }

        public double CsoportosKedvezmeny(int letszam)
        {
            double kedvezmeny = 1;

            if (letszam >= 10 && letszam <= 20)
                kedvezmeny = 0.80;
            else if (letszam > 20)
                kedvezmeny = 0.70;

            return letszam * Belepo * kedvezmeny;
        }
    }
}
