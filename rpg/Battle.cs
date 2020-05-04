using NAudio.Wave;
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
        dynamic abil;
        public string battlechoise;
        public Random random = new Random();
        Music music = new Music();
        public void BattleStart(Enemy enemy, Player player, Misc misc)
        {
            Console.Clear();
            if (enemy.type == "гопник")
                //GeneratePhrase(random);
            Console.WriteLine($"Без особых раздумий {enemy.name} с криком {Lists.BattlecryPhrases[GeneratePhrase(random)]} вступает в бой" +$"!\n");
            else
            Console.WriteLine($"Без особых раздумий {enemy.name} с криком {enemy.battlecry} вступает в бой!\n");
            while (player.hp > 0 && enemy.hp > 0)
            {
                try
                {
                    bool SycleVar1 = true;
                    
                    while (SycleVar1)
                    {

                        Console.WriteLine("Твой ход!\n");
                        Console.WriteLine($"Выбирай, чем бить:\n");
                        foreach (var spell in Lists.abilities)
                        {
                            Console.WriteLine((Lists.abilities.IndexOf(spell) + 1 + " " + spell.Name));
                        }
                        //Console.WriteLine("E Открыть инвентарь");
                         abil = Convert.ToInt32(Console.ReadLine());
                        SycleVar1 = false;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Способность {Lists.abilities[abil - 1].Name}\n");
                        Console.ResetColor();


                    }

                    if (player.buffedturns > 0)

                    {
                        if (Lists.abilities[abil - 1].Duration > 0)
                        {
                            if (Lists.abilities[abil - 1].DamageBuff > 0)
                            {
                                if (enemy.name == "Дед Максим" && Lists.abilities[abil - 1].Name == "Шептун")
                                {
                                    
                                    player.buffeddamage = 50;
                                }
                                else
                                    player.buffeddamage = Lists.abilities[abil - 1].DamageBuff;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Бафф обновлён\n");
                            Console.ResetColor();
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
                                    player.buffeddamage = 50;
                                }
                                else
                                    player.buffeddamage = Lists.abilities[abil - 1].DamageBuff;
                            }
                            player.buffedturns = Lists.abilities[abil - 1].Duration + 1;
                            enemy.hp -= (Lists.abilities[abil - 1].Damage) * player.buffeddamage;
                            player.buffedturns -= 1;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"Осталось ходов под баффом: {player.buffedturns -= 1}\n");
                            Console.ResetColor();
                        }
                        else
                            enemy.hp -= Lists.abilities[abil - 1].Damage;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine($"{enemy.name} HP: {enemy.hp}");
                        Console.ResetColor();
                    }
                    player.hp -= enemy.damage;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"Ты нанёс {(Lists.abilities[abil - 1].Damage) * player.buffeddamage} урона\n");
                    
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"{enemy.name} ударил тебя и нанёс {enemy.damage} урона\n");
                    
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"У тебя осталось: {player.hp} HP\n");
                    Console.WriteLine("----------------------------------------------");
                    Console.ResetColor();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Тоби Ass");
                    Console.ResetColor();
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
                Console.WriteLine($"{enemy.name} сказал свои последние слова {enemy.deathrattle} и пал замертво\n\n");
            else
                misc.GameOver();

            Loot loot = new Loot();
            loot.TakeLoot(player, enemy);
            Console.ReadKey();


        }
        public void BossBattle(Enemy enemy, Player player, Misc misc)
        {
            Console.Clear();
            Console.WriteLine($"Без особых раздумий {enemy.name} с криком {enemy.battlecry} вступает в бой!");
            while (player.hp > 0 && enemy.hp > 0)
            {
                //try
                //{
                    bool SycleVar1 = true;

                while (SycleVar1)
                {

                    Console.WriteLine("Твой ход!\n");
                    Console.WriteLine($"Выбирай, чем бить:");
                    foreach (var spell in Lists.abilities)
                    {
                        Console.WriteLine((Lists.abilities.IndexOf(spell) + 1 + " " + spell.Name));
                    }
                    //Console.WriteLine("E Открыть инвентарь");
                    //abil = Console.ReadLine();
                    //abil = Console.ReadLine();
                    //abil = Console.ReadLine();
                    abil = Console.ReadLine();//do not touch under any surcumstances!
                    abil = (int.Parse)(Console.ReadLine());//do not touch under any surcumstances!
                    SycleVar1 = false;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Способность {Lists.abilities[abil - 1].Name}\n");
                    Console.ResetColor();


                }

                if (player.buffedturns > 0)

                    {
                        if (Lists.abilities[abil - 1].Duration > 0)
                        {
                            if (Lists.abilities[abil - 1].DamageBuff > 0)
                            {
                                player.buffeddamage = Lists.abilities[abil - 1].DamageBuff;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Бафф обновлён\n");
                            Console.ResetColor();
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
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"Осталось ходов под баффом: {player.buffedturns -= 1}\n\n\n");
                            Console.ResetColor();
                        }
                        else
                            enemy.hp -= Lists.abilities[abil - 1].Damage * (Lists.Resistance[abil - 1].Resistance);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine($"{enemy.name} HP: {enemy.hp}\n");

                        Console.ResetColor();
                    }
                    player.hp -= enemy.damage;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine($"Ты нанёс {(Lists.abilities[abil - 1].Damage) * player.buffeddamage * (Lists.Resistance[abil - 1].Resistance)} урона\n");

                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine($"{enemy.name} ударил тебя и нанёс {enemy.damage} урона\n");
                    Console.WriteLine("-----------------------------------------------");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"У тебя осталось: {player.hp} HP\n\n\n");
                            Console.ResetColor();
                //}
                //catch
                //{
                //    Console.ForegroundColor = ConsoleColor.Cyan;
                //    Console.WriteLine("\n \n \n Тоби Ass");
                //    Console.ResetColor();
                //    music.StartMusic("Music/coffin.mp3");
                //    DateTime date = new DateTime();

                //    date = DateTime.Now;
                //    Console.ReadKey();
                //    var date1 = DateTime.Now;
                //    if (date.AddSeconds(10) < date1)
                //    {

                //        music.StopMusic();
                //        misc.GameOver();
                //        //player.hp = -22848;

                //    }
                //    music.StopMusic();
                //}
            }

            if (enemy.hp <= 0)
                if (enemy.type == "Гопник")
                    Console.WriteLine($"{enemy.name} сказал свои последние слова {Lists.BattlecryPhrases[GeneratePhrase(random)]} и пал замертво\n");
            else
            Console.WriteLine($"{enemy.name} сказал свои последние слова {enemy.deathrattle} и пал замертво\n\n");
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
        public void BattleYarir(List<Enemy> enemies, Player player, Misc misc, List<Ability> abilities, List<Ability> YarikAbility)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ярик: Ты не знаешь с кем связался, глупец!\n" +
                "тебе меня не одалеть! И кастует ");
            Console.WriteLine("Ярик: Твои жалкие фокусы против меня бесполезны\n");
            Console.ResetColor();
            for (int i = 1; i < 5; i++)
            {
                int yarikAbil = 0;
            Random random = new Random();
            int YarikMove = 0;
            foreach (var yarikSpell in Lists.YarikAbility)
            {
                YarikMove = random.Next(0, YarikAbility.Count);

            }
            bool SycleVar1 = true;
            int abil = 2;
            


                while (SycleVar1)
                {

                    Console.WriteLine("Твой ход!\n");
                    Console.WriteLine($"Выбирай, чем бить:\n");
                    foreach (var spell in Lists.abilities)
                    {
                        Console.WriteLine((Lists.abilities.IndexOf(spell) + 1 + " " + spell.Name));
                    }
                    //Console.WriteLine("E Открыть инвентарь");
                    abil = Convert.ToInt32(Console.ReadLine());
                    SycleVar1 = false;
                    Console.WriteLine($"Способность {Lists.abilities[abil - 1].Name}");



                }
                if (Lists.abilities[abil - 1].Name == "Игры разума")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Время как будто остановились. Голос в голове говорит: сейчас он кастонёт {Lists.YarikAbility[YarikMove].Name}\n");
                    Console.ResetColor();
                    Console.WriteLine($"1. Отразить {Lists.YarikAbility[YarikMove].Name}\n");
                    battlechoise = Console.ReadLine();
                    switch (battlechoise)
                    {
                        case "1":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Что-же, давай сюда свой {Lists.YarikAbility[YarikMove].Name}\n");
                            Console.ResetColor();
                            break;
                        default:
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n\nЯрик: кастую {(Lists.YarikAbility[YarikMove].Name)}");
                    Console.WriteLine("Ярик: ЧТО! НЕВОЗМОЖНО!\n");
                    Console.ResetColor();
                    Console.ReadKey();
                    switch (i)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Чёрт! Получилось! Я отразил его {(Lists.YarikAbility[YarikMove].Name)}\n");
                            Console.ResetColor();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Ха! Видишь мат в 4 хода? А я в 3!\n");
                            Console.ResetColor();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Ещё не поздно здаться, Ярик\n");
                            Console.ResetColor();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("После четвёртой отражённой способности мне оставалось только добить его\n");
                            Console.ResetColor();
                            break;
                        default:
                            break;
                    }


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Даже не почувствовав удара, Ярик наносит ответный удар\n");
                    Console.WriteLine($"Ярик: кастую {(Lists.YarikAbility[YarikMove].Name)}\n");
                    Console.ReadKey();
                    Console.WriteLine($"Ярик росщепил тебя на атомы\n");
                    Console.ResetColor();
                    Console.ReadKey();
                    misc.GameOver();
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Издав предсмертных хрип Ты всё равно не сдашь курсач без меня Ярик пал замертво\n\n\n");
            Console.ResetColor();
            Console.WriteLine("---------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ИСТИННАЯ КОНЦОВКА ПОЛУЧЕНА");
            Console.ResetColor();
            misc.GameOver();
        }
    }
    
}
