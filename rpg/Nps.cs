using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Nps: Enemy
    {
        //public string name { get; set; }
        public int carma { get; set; }
        public Nps(string name, int carma)
        {
            this.name = name;
            this.carma = carma;
        }
        
    }
    
}
