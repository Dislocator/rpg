using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Ability
    {
        public int AbbilityId { get; set; }
        public string Name { get; set; }
        public double Damage { get; set; }
        public int Duration { get; set; }
        public int Stun { get; set; }
        public double Resistance { get; set; }
        public int LongTurmEffect { get; set; }
        public double ManaCost { get; set; }
        public double DamageBuff { get; set; }
        public Ability(int AbbilityId, string Name, double Damage, int Duration, double DamageBuff)
        {
            this.AbbilityId = AbbilityId;
            this.Name = Name;
            this.Damage = Damage;
            this.Duration = Duration;
            this.DamageBuff = DamageBuff;
        }
        
        

        public Ability()
        {

        }
        public Ability(string Name, double Resistance)
        {
            this.Name = Name;
            this.Resistance = Resistance;
        }
    }
    
}
