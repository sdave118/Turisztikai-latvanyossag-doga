using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turisztikai_látványosság
{
    internal class Gyogyfurdo : Strand
    {
       public int Korhatar { get; set; }
       public bool Masszazs { get; set; }

       public Gyogyfurdo(string id,string orszag, string varos, string megnevezes, int nyitvaKezdet, int nyitvaVege, bool zart, int araOrankent, int korhatar, bool masszazs) : base(id,orszag, varos, megnevezes, nyitvaKezdet, nyitvaVege, zart, araOrankent)
       {
           Korhatar = korhatar;
           CsuzdaList = null;
           Masszazs = masszazs;
       }
    }
}
