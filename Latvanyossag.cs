using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turisztikai_látványosság
{
    internal abstract class Latvanyossag
    {
        protected Latvanyossag() { }
        protected Latvanyossag(string id,string orszag, string varos, string megnevezes, int nyitvaKezdet, int nyitvaVege)
        {
            Id = id;
            Orszag = orszag;
            Varos = varos;
            Megnevezes = megnevezes;
            NyitvaKezdet = nyitvaKezdet;
            NyitvaVege = nyitvaVege;
        }

        protected Latvanyossag(string orszag, string varos, string megnevezes)
        {
            Orszag = orszag;
            Varos = varos;
            Megnevezes = megnevezes;
            NyitvaKezdet = 0;
            NyitvaVege = 24;
        }

        public string Id {get; set; }
        public string Orszag { get; set; }
        public string Varos { get; set; }
        public string Megnevezes { get; set; }
        public int NyitvaKezdet { get; set; }
        public int NyitvaVege { get; set; }
    }
}
