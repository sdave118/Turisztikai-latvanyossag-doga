using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turisztikai_látványosság
{
    internal class Strand : Latvanyossag
    {
        public bool Zart { get; set; }
        public List<string> CsuzdaList { get; set; }
        public int AraOrankent { get; set; }

        public Strand(){}
        public Strand(string id, string orszag, string varos, string megnevezes, int nyitvaKezdet, int nyitvaVege,bool zart, int araOrankent) : base(id, orszag, varos, megnevezes, nyitvaKezdet, nyitvaVege)
        {
            Zart = zart;
            CsuzdaList = new List<string>();
            AraOrankent = araOrankent;
        }

        public void csuszdaHozzaad(string leiras)
        {
            CsuzdaList.Add(leiras);
        }

        public void csuszdaHozzaad(List<string> leirasok)
        {
            foreach (var leiras in leirasok)
            {
                CsuzdaList.Add(leiras);
            }
        }
    }
}
