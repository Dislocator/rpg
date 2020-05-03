using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Street
    {
        string dialogechoise;
        string locationchoise;
        public void Street_Location(Player player, Battle battle, int easteregg, List<Nps> nps, Misc misc, List<Enemy> enemies)
        {
            Console.WriteLine("Как приятно больше не чувствовать зловонья помойки.");
            //if (player.clothes.IndexOf())
            switch (player.clothes[0].Name)
            {
                case "Обоссанные шмотки":
                    Console.WriteLine("Нужно как можно скорее идти домой и переодеться!");
                    Console.WriteLine("Погода была ясная. Сегодня я собирался пойти поиграть в контру с друзьями. \n" +
                       "А что в замен? Весь мокрый, в каких-то чертях.\n" +
                       "Ведь говорил мне вчера Ярик не мешать водку с пивом.\n" +
                       "А я ему Ёрш, Ёрш...\n" +
                       "Точно! Ярик! Он должен помнить что было вчера. Нужно позвонить ему, уверен он пил меньше меня, возможно он проясит ситуацию.\n");
                    Console.WriteLine("Переоденусь и свяжусь с ним!");
                    Console.WriteLine("");
                    Console.ReadKey();
                    RoadHome(player, battle, easteregg, nps, misc, enemies);
                    break;
                case "Порванные вещи":
                    Console.WriteLine("Вещи найденные на помойке пахли отвратно\n");
                    Console.WriteLine("Нужно как можно скорее идти домой и переодеться!");
                    Console.WriteLine("В таком виде я не могу заявиться к Ярику домой .\n");
                    Console.WriteLine("Переоденусь и свяжусь с ним!");
                    Console.WriteLine("");
                    Console.ReadKey();
                    RoadHome(player, battle, easteregg, nps, misc, enemies);
                    break;
                case "Рабочая роба":
                    Console.WriteLine("Что-же раз уж переодеваться мне больше не нужно можно заскочить к Ярику и разузнать у событиях вчерашнего дня. \n" +
               "С другой стороны возможно стоит пойти домой и позвонить ему от-туда?\n" +
               "1. Прийти лично" +
               "2. Позвонить издому");
                    locationchoise = Console.ReadLine();
                    switch (locationchoise)
                    {
                        case "1":
                            RoadYarik(player, battle, easteregg, nps, misc, enemies);
                            break;
                        case "2":
                            RoadHome(player, battle, easteregg, nps, misc, enemies);
                            break;
                        default:
                            Console.WriteLine("Опять за старое?");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Фу читер");
                    break;
            }

        }
        public void RoadHome(Player player, Battle battle, int easteregg, List<Nps> nps, Misc misc, List<Enemy> enemies)
        {
            Console.WriteLine("Денег на маршрутку к сожалению небыло. \n" +
                "Прийдёться идти пешком. \n" +
                "Дорога домой была мне хорошо известна и я напевая песню шёл домой. ");

            /*Добавить гачи песню*/
            Console.WriteLine("К несчастью всё оказалось не так просто и на мой путь переградили знакомые мне  Сева, Васян и Петька, заядлые алкаши и гопники  ");
            Console.WriteLine($"{ enemies[2].name}: Слышь, братишка. Тормозни—ка, базар есть. А чо ты рамсишь—то? Ты чо такой голимый? Это что на тебе {player.clothes[0].Name}?");
            Console.WriteLine($"{ enemies[4].name}:Братишка, постой—ка.Ты откуда такой красивый идешь?");
            Console.WriteLine($"{ enemies[3].name}Дай куртку, пацану холодно.");
            Console.WriteLine("1. Отдать куртку\n" +
                "2. Не отдавать");
            dialogechoise = Console.ReadLine();
            switch (dialogechoise)
            {
                case "1":
                    Console.WriteLine($"Гопота отжала у тебя {player.clothes[0].Name}") ;
                    player.clothes.Clear();
                    Console.ReadKey();
                    break;
                case "2":
                    Gopniks(player, battle, enemies, misc);
                    break;
                default:
                    Console.WriteLine("По классике. Пошёл нах");
                    break;

            }
                
            

        }
        public void RoadYarik(Player player, Battle battle, int easteregg, List<Nps> nps, Misc misc, List<Enemy> enemies)
        {
            //Пошутить про дви грывни
        }
        public void Gopniks(Player player, Battle battle, List<Enemy> enemies, Misc misc)
        {
            Console.WriteLine($"Полный уверенности {enemies[3].name} влетает с ноги");
            battle.BattleStart(enemies[2], player, misc);
            Console.WriteLine($"Оттянув рассыпающегося на семки братана, {enemies[3].name} влетает с ноги");
            battle.BattleStart(enemies[3], player, misc);
            Console.WriteLine($"Остался лишь {enemies[3].name}");
            battle.BattleStart(enemies[4], player, misc);
            Console.WriteLine("Гопари повержены");
            Console.ReadKey();
        }
    }
}
