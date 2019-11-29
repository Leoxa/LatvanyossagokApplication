using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Latvanyossagok
    {
        String nev;
        String leir;
        int ar;
        int id;

        public Latvanyossagok(string nev, string leir, int ar, int id)
        {
            this.Nev = nev;
            this.Leir = leir;
            this.Ar = ar;
            this.Id = id;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Leir { get => leir; set => leir = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            if (ar==0)
            {
                return nev + " -  Ingyenes";
            }
            return nev + " - " + ar + " FT";
        }
    }
}
