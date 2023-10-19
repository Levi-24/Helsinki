using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Helsinki
{
    internal class Sportag
    {
        public int Helyezes { get; set; }
        public int SportolokSzama { get; set; }
        public string SportagNeve { get; set; }
        public string VersenyszamNeve { get; set; }

        public Sportag(string sor)
        {
            var darab = sor.Split(' ');
            this.Helyezes = int.Parse(darab[0]);
            this.SportolokSzama = int.Parse(darab[1]);
            this.SportagNeve = darab[2];
            this.VersenyszamNeve = darab[3];
        }
    }
}
