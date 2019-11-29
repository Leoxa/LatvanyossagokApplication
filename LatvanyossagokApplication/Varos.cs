using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Varos
    {
        string nev;
        int lakossag;
        int id;

        public Varos(string nev, int lakossag, int id)
        {
            this.Nev = nev;
            this.Lakossag = lakossag;
            this.Id = id;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Lakossag { get => lakossag; set => lakossag = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return nev + " - Lakosság: " + lakossag + " fő";
        }
    }
    

}
