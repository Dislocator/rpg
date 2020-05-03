using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
     class Enemy
    {
        public int id;
        public string name;
        public double hp;
        public double damage;
        public string battlecry;
        public string type;
        public string deathrattle;
        
        static public List<Ability> Resistance { get; set; }
        public Enemy(int id, string name, double hp, double damage, string battlecry, string deathrattle)
        {
            this.id = id;
            this.name = name;
            this.hp = hp;
            this.damage = damage;
            this.battlecry = battlecry;
            this.deathrattle = deathrattle;
        }
        public Enemy()
        {

        }
        
        public static Enemy ThisEnemy = new Enemy();
        //public Enemy(int id, string name, double hp, double damage, string battlecry, string deathrattle)
        //{
        //}





        ////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////


    }
}
