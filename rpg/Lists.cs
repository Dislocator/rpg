using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    static class Lists
    {        
        public static List<Items> playerInventory = new List<Items>();
        public static List<Items> items = new List<Items>();
        public static List<Items> questItems = new List<Items>();
        public static List<Items> clothes = new List<Items>();
        public static List<Ability> abilities = new List<Ability>();
        public static List<Nps> nps = new List<Nps>();
        public static List<Enemy> enemies = new List<Enemy>();
        public static List<Enemy> weaknesses = new List<Enemy>();
        public static List<Ability> allAbilities = new List<Ability>();
        public static List<Ability> Resistance = new List<Ability>();
        public static List<string> BattlecryPhrases = new List<string>();
        public static List<string> DeathrattlePhrases = new List<string>();
        public static List<string> Dodge = new List<string>();
        public static List<Ability> YarikAbility = new List<Ability>();
    }
}
