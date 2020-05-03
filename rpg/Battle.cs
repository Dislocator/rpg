using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Battle
    {
        public Random random = new Random();
        Music music = new Music();
        public void BattleStart(Enemy enemy, Player player, Misc misc)
        {
            if (enemy.type == "гопник")
                //GeneratePhrase(random);
            Console.WriteLine($"Без особых раздумий {enemy.name} с криком {Lists.BattlecryPhrases[GeneratePhrase(random)]} вступает в бой" +$"!");
            else
            Console.WriteLine($"Без особых раздумий {enemy.name} с криком {enemy.battlecry} вступает в бой" +
                $"!");
            while (player.hp > 0 && enemy.hp > 0)
            {
                try
                {
                    bool SycleVar1 = true;
                    int abil = 2;
                    while (SycleVar1)
                    {

                        Console.WriteLine("Твой ход!");
                        Console.WriteLine($"Выбирай, чем бить:");
                        foreach (var spell in Lists.abilities)
                        {
                            Console.WriteLine((Lists.abilities.IndexOf(spell) + 1 + " " + spell.Name));
                        }
                        //Console.WriteLine("E Открыть инвентарь");
                        abil = Convert.ToInt32(Console.ReadLine());
                        SycleVar1 = false;
                        Console.WriteLine($"Способность {Lists.abilities[abil - 1].Name}");



                    }

                    if (player.buffedturns > 0)

                    {
                        if (Lists.abilities[abil - 1].Duration > 0)
                        {
                            if (Lists.abilities[abil - 1].DamageBuff > 0)
                            {
                                if (enemy.name == "Дед Максим" && Lists.abilities[abil - 1].Name == "Шептун")
                                {
                                    Console.WriteLine("---------------------------");
                                    player.buffeddamage = 50;
                                }
                                else
                                    player.buffeddamage = Lists.abilities[abil - 1].DamageBuff;
                            }
                            Console.WriteLine("Бафф обновлён");
                            player.buffedturns -= 1;
                        }
                        else
                        {
                            enemy.hp -= (Lists.abilities[abil - 1].Damage) * player.buffeddamage;
                            player.buffedturns -= 1;
                        }
                    }
                    else
                    {
                        if (Lists.abilities[abil - 1].Duration > 0)
                        {
                            if (Lists.abilities[abil - 1].DamageBuff > 0)
                            {
                                if (enemy.name == "Дед Максим" && Lists.abilities[abil - 1].Name == "Шептун")
                                {
                                    Console.WriteLine("---------------------------");
                                    player.buffeddamage = 50;
                                }
                                else
                                    player.buffeddamage = Lists.abilities[abil - 1].DamageBuff;
                            }
                            player.buffedturns = Lists.abilities[abil - 1].Duration + 1;
                            enemy.hp -= (Lists.abilities[abil - 1].Damage) * player.buffeddamage;
                            player.buffedturns -= 1;
                            Console.WriteLine($"Осталось ходов под баффом: {player.buffedturns -= 1}");
                        }
                        else
                            enemy.hp -= Lists.abilities[abil - 1].Damage;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{enemy.name} HP: {enemy.hp}");
                        Console.ResetColor();
                    }
                    player.hp -= enemy.damage;
                    Console.WriteLine($"Ты нанёс {(Lists.abilities[abil - 1].Damage) * player.buffeddamage} урона");
                    Console.WriteLine($"{enemy.name} ударил тебя и нанёс {enemy.damage}");
                    Console.WriteLine($"У тебя осталось: {player.hp} HP");
                }
                catch
                {
                    Console.WriteLine("Тоби Ass");
                    music.StartMusic("Music/coffin.mp3");
                    DateTime date = new DateTime();

                    date = DateTime.Now;
                    Console.ReadKey();
                    var date1 = DateTime.Now;
                    if (date.AddSeconds(10) < date1)
                    {

                        music.StopMusic();
                        misc.GameOver();
                        //player.hp = -22848;

                    }
                    music.StopMusic();
                }

            }
            if (enemy.hp <= 0)
                Console.WriteLine($"{enemy.name} сказал свои последние слова {enemy.deathrattle} и пал замертво");
            else
                misc.GameOver();

            Loot loot = new Loot();
            loot.TakeLoot(player, enemy);
            Console.ReadKey();


        }
        public void BossBattle(Enemy enemy, Player player, Misc misc, List<Ability> abilities)
        {

            Console.WriteLine($"Без особых раздумий {enemy.name} с криком {enemy.battlecry} вступает в бой" +
                    $"!");
            while (player.hp > 0 && enemy.hp > 0)
            {
                try
                {
                    bool SycleVar1 = true;
                int abil = 2;
                while (SycleVar1)
                {
                    
                        Console.WriteLine("Твой ход!");
                        Console.WriteLine($"Выбирай, чем бить:");
                        foreach (var spell in Lists.abilities)
                        {
                            Console.WriteLine((Lists.abilities.IndexOf(spell) + 1 + " " + spell.Name));
                        }
                        //Console.WriteLine("E Открыть инвентарь");
                        abil = Convert.ToInt32(Console.ReadLine());
                        SycleVar1 = false;
                        Console.WriteLine($"Способность {Lists.abilities[abil - 1].Name}");

                    
                    

                }

                if (player.buffedturns > 0)

                {
                    if (Lists.abilities[abil - 1].Duration > 0)
                    {
                        if (Lists.abilities[abil - 1].DamageBuff > 0)
                        {
                            player.buffeddamage = Lists.abilities[abil - 1].DamageBuff;
                        }
                        Console.WriteLine("Бафф обновлён");
                        player.buffedturns -= 1;
                    }
                    else
                    {
                        enemy.hp -= (Lists.abilities[abil - 1].Damage) * player.buffeddamage * (Lists.Resistance[abil - 1].Resistance);
                        player.buffedturns -= 1;
                    }
                }
                else
                {
                    if (Lists.abilities[abil - 1].Duration > 0)
                    {
                        if (Lists.abilities[abil - 1].DamageBuff > 0)
                        {
                            player.buffeddamage = Lists.abilities[abil - 1].DamageBuff;
                        }
                        player.buffedturns = Lists.abilities[abil - 1].Duration + 1;
                        enemy.hp -= (Lists.abilities[abil - 1].Damage) * player.buffeddamage * (Lists.Resistance[abil - 1].Resistance);
                        player.buffedturns -= 1;
                        Console.WriteLine($"Осталось ходов под баффом: {player.buffedturns -= 1}");
                    }
                    else
                        enemy.hp -= Lists.abilities[abil - 1].Damage * (Lists.Resistance[abil - 1].Resistance);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{enemy.name} HP: {enemy.hp}");
                    Console.ResetColor();
                }
                player.hp -= enemy.damage;
                Console.WriteLine($"Ты нанёс {(Lists.abilities[abil - 1].Damage) * player.buffeddamage * (Lists.Resistance[abil - 1].Resistance)} урона");
                Console.WriteLine($"{enemy.name} ударил тебя и нанёс {enemy.damage}");
                Console.WriteLine($"У тебя осталось: {player.hp} HP");
            }
                catch
                {
                    Console.WriteLine("Тоби Ass");
                    music.StartMusic("Music/coffin.mp3");
                    DateTime date = new DateTime();

                    date = DateTime.Now;
                    Console.ReadKey();
                    var date1 = DateTime.Now;
                    if (date.AddSeconds(10) < date1)
                    {

                        music.StopMusic();
                        misc.GameOver();
                        //player.hp = -22848;

                    }
                    music.StopMusic();
                }
            }

            if (enemy.hp <= 0)
                if (enemy.type == "Гопник")
                    Console.WriteLine($"{enemy.name} сказал свои последние слова {Lists.DeathrattlePhrases[GeneratePhrase(random)]} и пал замертво");
            else
            Console.WriteLine($"{enemy.name} сказал свои последние слова {enemy.deathrattle} и пал замертво");
            else
                misc.GameOver();

            Loot loot = new Loot();
            loot.TakeLoot(player, enemy);
            Console.ReadKey();
        }
        public int GeneratePhrase(Random random)
        {
            int GopnikPhrase = random.Next(0, Lists.BattlecryPhrases.Count);
            return GopnikPhrase;
        }
        public int GeneratePhraseDead(Random random)
        {
            int GopnikPhrase = random.Next(0, Lists.DeathrattlePhrases.Count);
            return GopnikPhrase;
        }
    }
    
}
