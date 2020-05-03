using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Player
    {
        public string name { get; set; }
        public double hp { get; set; }
        public int coins { get; set; }
        public int damage { get; set; }
        public int armorValue { get; set; }
        public List<Items> Inventory { get; set; }
        public int buffedturns { get; set; }
        public double buffeddamage { get; set; }
        public List<Ability> abilities { get; set; }
        public List<Items> clothes { get; set; }
        public Player(double hp, int coins, int damage, int armorValue, List<Items> Inventory,
            List<Ability> abilities, int buffedturns, double buffeddamage)
        {
            this.hp = hp;
            this.coins = coins;
            this.damage = damage;
            this.armorValue = armorValue;
            this.Inventory = Inventory;
            this.abilities = abilities;
            this.buffedturns = buffedturns;
            this.buffeddamage = buffeddamage;
            
        }
        //public static Player player = new Player(100, 0, 5, 0, 0, Player.player.abilities);
        public void Text(string a)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ResetColor();
            Console.Write($": {a}\n");
            Console.ReadKey();

        }
    }
    
}
