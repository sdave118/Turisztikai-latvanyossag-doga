using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turisztikai_látványosság
{
    internal class Beolvasas
    {
        static List<Latvanyossag> latvanyossag = new();

        public Beolvasas(string fileName)
        {
            foreach (var item in File.ReadAllLines(fileName))
            {
                string[] resz = item.Split(";");

                string id = resz[0];
                string orszag = resz[1];
                string varos = resz[2];
                string megnev = resz[3];
                int nyitvaKezd = int.Parse(resz[4]);
                int nyitvaVeg = int.Parse(resz[5]);

                switch (resz[2])
                {
                    case "Múzeum":
                        string tema = resz[6];
                        string jogosultString = resz[7];
                        bool jogosult;
                        if (jogosultString == "igen")
                        {
                             jogosult= true;
                        }
                        else
                        {
                            jogosult = false;
                        }
                        double belepo = double.Parse(resz[8]);
                        Muzeum muzeum = new(id,orszag, varos, megnev, nyitvaKezd, nyitvaVeg, tema, jogosult, belepo);
                        latvanyossag.Add(muzeum);
                        break;
                    case "Strand":
                        string zartString = resz[6];
                        bool zart;
                        if (zartString == "zart")
                        {
                            zart = true;
                        }
                        else
                        {
                            zart = false;
                        }
                        int oraOrankent = int.Parse(resz[7]);
                        Strand strand = new(id, orszag, varos, megnev, nyitvaKezd, nyitvaVeg, zart, oraOrankent);
                        latvanyossag.Add(strand);
                        break;
                    case "Gyógyfürdő":
                        zartString = resz[6];
                        if (zartString == "zart")
                        {
                            zart = true;
                        }
                        else
                        {
                            zart = false;
                        }
                        oraOrankent = int.Parse(resz[7]);
                        int korhatar = int.Parse(resz[8]);
                        string masszasString = resz[9];
                        bool masszazs;
                        if (masszasString == "igen")
                        {
                            masszazs = true;
                        }
                        else
                        {
                            masszazs = false;
                        }
                        Gyogyfurdo gyogyfurdo = new(id, orszag, varos, megnev, nyitvaKezd, nyitvaVeg, zart, oraOrankent,
                            korhatar, masszazs);
                        latvanyossag.Add(gyogyfurdo);
                        break;
                }
            }
        }

    }
}
