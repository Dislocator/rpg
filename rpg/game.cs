using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg
{
    
    class Game
    {
        
        Street street = new Street();
        Misc misc = new Misc();
        Nps betonman = new Nps("Рабочий", 0);
        Player player = new Player(1000, 0, 5, 0, Lists.playerInventory, Lists.abilities, 0, 1);
        public static int easteregg = 0;
        public void Start()
        {
            ///////////////////////
            Lists.BattlecryPhrases.Add("Крысиный писк");
            ///////////////////////
            Lists.BattlecryPhrases.Add("О, а я этого парня знаю. В Химках деревянными членами торгует!");
            ///////////////////////
            
            
            Lists.BattlecryPhrases.Add("*Пятки отрываешь - пацанов не уважаешь*");
            Lists.BattlecryPhrases.Add("*Слышь бл*!*");
            Lists.BattlecryPhrases.Add("*Эй ты, чорт! А чо ты такой волосатый как девка?*");
            Lists.BattlecryPhrases.Add("Слышь, брателло, ты какой масти?");
            Lists.BattlecryPhrases.Add("Опа. Ты чо, предъявить мне хочешь, брателло?");
            Lists.BattlecryPhrases.Add("Слышь ты, ты обоснуй свои слова, чтобы потом о здоровье не пожалеть.");
            Lists.BattlecryPhrases.Add("Ты, да ты чертила мутный, иди сюда, с*ка!");
            ///////////////////////
            Lists.DeathrattlePhrases.Add("*Печальный крысиный писк*");
            ///////////////////////
            Lists.DeathrattlePhrases.Add("*Не бейте, лучше обоссыте!*");
            ///////////////////////
            Lists.DeathrattlePhrases.Add("*Мля я маслину поймал*");
            Lists.DeathrattlePhrases.Add("*Попадос!*");
            Lists.DeathrattlePhrases.Add("Слышь ты, ты ваще не прав, ты осознай это");
            Lists.DeathrattlePhrases.Add("Стрела в восемь? Я приду по—любому."); 
            Lists.DeathrattlePhrases.Add("Опа! Опаньки! Опа, них* я себе вштырило!");
            Lists.DeathrattlePhrases.Add("Валим отсюда, пацаны. Здесь ваще голимо."); 
            ///////////////////////
            Lists.nps.Add(betonman);
            ///////////////////////
            List<Items> clothes = new List<Items>();
            player.clothes = clothes;
            ///////////////////////
            Enemy Rat = new Enemy(1, "Крыса", 20, 3, "*Крысиный писк*", "*Печальный крысиный писк*");
            Lists.enemies.Add(Rat);
            Enemy Maksim = new Enemy(2, "Дед Максим", 500, 40,"О, а я этого парня знаю. В Химках деревянными членами торгует!", "*Не бейте, лучше обоссыте!*");
            
            Ability RageResist = new Ability("Покричать", 1);
            Ability StronHitResist = new Ability("Ударить в печень", 0.1);
            Ability UltimateResist = new Ability("Левая кнопка мыши", 0.5);
            Ability perdejResist = new Ability("Шептун", 50);
            Lists.enemies.Add(Maksim);
            Lists.Resistance.Add(RageResist);
            Lists.Resistance.Add(StronHitResist);
            Lists.Resistance.Add(UltimateResist);
            Lists.Resistance.Add(perdejResist);

            Enemy Seva = new Enemy(3, "Сева", 60, 10, "*Пятки отрываешь - пацанов не уважаешь*", "*Мля я маслину поймал*");
            Lists.enemies.Add(Seva);
            Seva.type = "гопник";
            Enemy Vasua = new Enemy(4, "Васян", 40, 20, "*Слышь бл*!*", "*Попадос!*");
            Lists.enemies.Add(Vasua);
            Vasua.type = "гопник";
            Enemy Petya = new Enemy(3, "Петька", 40, 20, "*Эй ты, чорт! А чо ты такой волосатый как девка?*", "*Попадос!*");
            Lists.enemies.Add(Petya);
            Petya.type = "гопник";
            ///////////////////////    
            Ability Rage = new Ability(1, "Покричать", 0, 5, 1.20);
            Ability StronHit = new Ability(2, "Ударить в печень", 10.0, 0, 0);
            Ability Ultimate = new Ability(3, "Левая кнопка мыши", 20.0, 0, 0);
            Ability perdej = new Ability(4, "Шептун", 3, 0, 2);
            Lists.abilities.Add(Rage);
            Lists.abilities.Add(StronHit);
            Lists.abilities.Add(Ultimate);
            Lists.allAbilities.Add(Rage);
            Lists.allAbilities.Add(StronHit);
            Lists.allAbilities.Add(Ultimate);
            Lists.allAbilities.Add(perdej);
            ///////////////////////
            Items Key_Gutter = new Items(1, "Ржавый ключ");
            Lists.questItems.Add(Key_Gutter);
            Items Key_Basement = new Items(2, "Деревянный член");
            Lists.questItems.Add(Key_Basement);
            ///////////////////////
            Items jacket_pissed = new Items(7, "Обоссанные шмотки");
            Lists.clothes.Add(jacket_pissed);
            Items jacket_ribbed = new Items(6, "Порванные вещи");
            Lists.clothes.Add(jacket_ribbed);
            
            Items jacket_worker = new Items(8, "Рабочая роба");
            Lists.clothes.Add(jacket_worker);
            for (int i = 0; i < 20; i++)
            {
                Items PotionHeal = new Items(1, "Пиво Жигулёвское", 100, 1);// 20
                Lists.items.Add(PotionHeal);

            }
            for (int i = 0; i < 10; i++)
            {
                Items PotionDex = new Items(2, "Водка столичная", 35, 5);//Шанс уворота 10
                Lists.items.Add(PotionDex);

            }
            for (int i = 0; i < 5; i++)
            {
                Items PotionLuck = new Items(3, "Пять копеек", 30, 5);// 5
                Lists.items.Add(PotionLuck);

            }
            for (int i = 0; i < 3; i++)
            {
                Items PotionEvade = new Items(4, "Ботинок", 100, 1); //Уход из боя 3
                Lists.items.Add(PotionEvade);

            }
            for (int i = 0; i < 3; i++)
            {
                Items PotionStun = new Items(5, "Футболка \"Зенит\"", 50, 3); //Стан 5
                Lists.items.Add(PotionStun);

            }
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to the StoryQuest");
            
            Console.ResetColor();
            bool ChoseCharacter = true;
            while (ChoseCharacter)
            {
                
                Console.WriteLine("Введи имя:");
                
                player.name = Console.ReadLine();
                switch (player.name)
                {
                    case "":
                        Console.WriteLine("не могу вспомнить...");
                        break;
                    case "Login":
                        
                        Console.Write($"Кажеться я вспоминаю, моё имя - ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{player.name}");
                        Console.ResetColor(); 
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine($"Найдено пасхалок:{++easteregg} ");
                        Console.ResetColor();   
                        ChoseCharacter = false;
                        break;
                    default:
                        Console.WriteLine($"Кажеться в вспоминаю, моё имя - {player.name}");
                        ChoseCharacter = false;
                        break;  
                }

                Console.ReadKey();
            }


            Console.Clear();
            Console.WriteLine($"Стук! \nРезкая боль в животе одолела меня! \nОткрыв глаза от ужаса я увидел стоящего перед собой бородатого мужчину. " +
                $"\nОн посмотрел на меня сверху вниз и промолвил " + "Как допьёшь - бутылочку не выбрасывай. После чего просто ушёл." + " " +
                "\nЯ наконец окончательно проснулся. " +
                "\nКакого чёрта вообще происходит? Где я нахожусь? Кто был этим бородачём? Столько вопросов и никаких ответов!" +
                "\nЛишь одно слово крутиться в голове - Стрелок. А хотя нет, стой, это из другой игры.");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Имя есть. Но что было вчера, раз я ничего не помню? Снова выпил? " +
                "\nКто его знает. В любом случае мне нужно срочно переодеться в сухие вещи. \n" +
                "К несчастью то место, где мне посчастливилось очнуться по всей видимости залило дождевой водой " +
                "\nI уверен что дома есть сменная одежда\n");
            Items items = new Items();
            
           items = Lists.clothes[0];
            player.clothes.Add(jacket_pissed);
            Console.WriteLine($"На тебе надето: {player.clothes[0].Name}");
            Gutter gutter = new Gutter();
            Battle battle = new Battle();
            gutter.Gutter1(player, battle, easteregg, Lists.nps, misc, Enemy.Resistance);
            Console.WriteLine("-----------------");
            street.Street_Location(player, battle, easteregg, Lists.nps, misc, Lists.enemies);
            
            
        }
        
    }

}
