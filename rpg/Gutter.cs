using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;  
namespace rpg
{
    class Gutter
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public string location = "";
        public dynamic Gutter1_1Var = true;
        public dynamic Gutter1_2Var = true;
        public dynamic Gutter1_Gachi = true;
        string dialogechoise;
        string locationchoise;
        Music music = new Music();
        public void Gutter1(Player player, Battle battle, int easteregg, List<Nps> nps, Misc misc, List<Ability> abilities)
        {
            synth.SetOutputToDefaultAudioDevice();
            var LocationBug = false;
            
                Console.WriteLine("Встав и осмотрев окрестности, я понял где нахожусь. \n" +
                    "Горы мусора, старая техника. \n" +
                    "Я на помойке. " +
                    "\nМне не очень хотелось оставаться здесь. Нужно поскорее выбираться и идти домой, переодеться. \n" +
                    "Хотя с другой стороны возможно стоит порыскать здесь в поисках сменных вещей\n");
                

                Console.WriteLine("");
                Console.WriteLine("1. Уйти из помойки\n");
                if(Gutter1_2Var == true)
                Console.WriteLine("2. Осмотреться");
                
                locationchoise = Console.ReadLine();
                
                switch (locationchoise)
                {
                    case "1":
                        location = "street1";
                        break;
                    case "2":
                        location = "gutter1_2";
                        Console.WriteLine("На помойке небыло ни души, лишь время от времени пролетали птицы\n " +
                            "Где-то вдали был слышен машинный гул и возмущённые голоса. \n" +
                            "Возможно мне стоит попросить у них сменную одежду? \n" +
                            "Но за кого меня примут... весь в грязи и ещё голова расскалываеться. \n");
                            
                        if (Gutter1_1Var)
                        {
                            Console.WriteLine("Краем глаза я заметил кучу рваных вещей лежавших неподалёку. \n" +
                            "Хоть не известно какой бомж носил их до этого. \n" +
                            "Гораздо безопаснее будет переодеться в них");
                            Console.WriteLine("1. Надеть разорванные вещи\n" +
                                "2. Попросить вещи у рабочих");
                            locationchoise = Console.ReadLine();
                            switch(locationchoise)
                            {
                                case "1":
                                    Gutter1_1(player, battle, easteregg, nps, Lists.enemies, misc, Enemy.Resistance);
                                    break;
                                case "2":
                                    Gutter1_2(player, battle, easteregg, nps, Lists.enemies, misc, Enemy.Resistance);
                                    
                                    break;
                                default:
                                    Console.WriteLine("Я тебя предупреждал!");
                                    synth.SpeakAsync($"Сенк ю фор камминг. Соу вай а ю гэй?");
                                    //synth.SpeakAsync($"Thank you for comming. so why Are you gay?");
                                    Console.WriteLine("Thank you for comming. SO WHY Are YOU GAY?");
                                    
                                    break;

                            }
                        }
                        else
                        {
                            Gutter1_2(player, battle, easteregg, nps, Lists.enemies, misc, Enemy.Resistance);
                        }
                        
                        
                        break;
                    default:
                        if (Gutter1_1Var)
                        {
                            Gutter1_1(player, battle, easteregg, nps, Lists.enemies, misc, Enemy.Resistance);
                        }
                        else Console.WriteLine("Всё! Хватит! Ты проиграл!");
                        misc.GameOver();
                        break;
                }
           
        }
        public void Gutter1_1(Player player, Battle battle, int easteregg, List<Nps> nps, List<Enemy> enemies, Misc misc, List<Ability> abilities)
        {
            location = "gutter1.1";
            if (player.name == "Login")
            {
                Console.WriteLine($"Хватит ломать мой код! \n" +
                    $"Найдено пасхалок: {++easteregg} \n" +
                    $"Ты остался стоять в нерешительности, \n" +
                    "краем глаза я заметил груду вещей лежащих в углу. \n" +
                    "Возможно стоит напялить их раз уж домой я не спешу?");
            }
            else Console.WriteLine($"Хватит ломать мой код! \n" +
                    $"Ты остался стоять в нерешительности, \n" +
                    "краем глаза я заметил груду вещей лежащих в углу. \n" +
                    "Возможно стоит напялить их раз уж домой я не спешу?");
            Console.WriteLine("Подойдя поближе к вещам, разбросанным по земле, я заметил, как зашевелился правый карман пыльных брюк.. \n" +
                            "Оттолкнув их немного назад, \n" +
                            "я увидел огромную злобную уставшую крысу с маленькими глазами, \n" +
                            "явно не желающую покидать свое убежище. \n" +
                            "Ну, мне придется набить ее крысиный хвост.");
            battle.BattleStart(enemies[0], player, misc);
            Gutter1_1Var = false;
            player.clothes.Clear();
            player.clothes.Add(Lists.clothes[1]);
            Console.WriteLine($"На тебе надето: {player.clothes[0].Name}");
            Console.WriteLine("Надрав жопу крысе и одев новопреобретённые панталоны в кармене я обнаружил ржавый старый ключ");
            player.Inventory.Add(Lists.questItems[0]);
            Console.WriteLine($"Получено {Lists.questItems[0].Name}");
            Console.ReadKey();
            Gutter1(player, battle, easteregg, nps, misc, Enemy.Resistance);
        }
        public void Gutter1_2(Player player, Battle battle, int easteregg, List<Nps> nps, List<Enemy> enemies, Misc misc, List<Ability> abilities)
        {
            Console.WriteLine("Погода была ясная. Сегодня я собирался пойти поиграть в контру с друзьями. \n" +
                "А что в замен? Весь мокрый, в каких-то чертях.\n" +
                "Ведь говорил мне вчера Ярик не мешать водку с пивом.\n" +
                "А я ему Ёрш, Ёрш...\n" +
                "Точно! Ярик! Он должен помнить что было вчера. Нужно позвонить ему, уверен он пил меньше меня, возможно он проясит ситуацию.\n");
            Console.ReadKey();
            Console.WriteLine("Погрязнув в своих мыслях я не заметил как дошёл до источника звука\n" +
                "Источником выступала бригада рабочих мешающих бетон.");
            Console.WriteLine("Из радио стоящего рядом доносилась пронзательна мелодия");
            music.StartMusic("Music/beton.mp3");
            Console.WriteLine("Заприметив мои неудачные попытки дать о себе знать один из рабочих выключил радио и подошёл поближе");
            Console.ReadKey();
            music.StopMusic();
            var waveStop = new WaveOutEvent();
            
            
            if (Gutter1_1Var == false)
            {
                bool CycleVar = true;
                while (CycleVar)
                {
                    Console.WriteLine($"{nps[0].name}: Эй ты бомжара, а ну пшёл отсюда нах!");
                    Console.WriteLine("1. Следи за языком, работящий. ");
                    Console.WriteLine("2. Я не бомжара. Ничерта не помню, что вчера было");
                    Console.WriteLine("3. А может ты пидор?");

                    dialogechoise = Console.ReadLine();
                    switch (dialogechoise)
                    {
                        case "1":
                            CycleVar = false;
                            Console.WriteLine($"{nps[0].name}: А я смотрю ты не промах, себя в обиду не дашь." +
                                $"\nЛадно, какого чёрта ты тут забыл?");
                            Gutter1_3(player, battle, easteregg, nps, enemies, misc, Enemy.Resistance);
                            break;
                        case "2":
                            Console.WriteLine($"{nps[0].name}: Вот и вали домой, проспись, нечего тебе здесь шляться!");
                            CycleVar = false;
                            Gutter1_3(player, battle, easteregg, nps, enemies, misc, Enemy.Resistance);
                            break;
                        case "3":
                            CycleVar = false;
                            player.abilities.Add(Lists.allAbilities[1]);
                            Enemy enemy1 = (Enemy)nps[0];
                            enemy1.hp = 500;
                            enemy1.damage = 228;
                            enemy1.battlecry = "Сюда!";
                            enemy1.deathrattle = "Ну почему всегда я? а?";
                            enemy1.name = "Буйный работяга";
                            battle.BattleStart(enemy1, player, misc);
                            Console.WriteLine($"Пасхалок найдено {++easteregg}");
                            
                            break;
                        default:
                            Console.WriteLine("Лох, пидр");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{nps[0].name}: Парень, ты заблудился. Здесь не парк развлечений!\n" +
                    $"Чего тебе здесь надо!?");
                Gutter1_3(player, battle, easteregg, nps, enemies, misc, Enemy.Resistance);
            }
            
            
        }
        public void Gutter1_3(Player player, Battle battle, int easteregg, List<Nps> nps, List<Enemy> enemies, Misc misc, List<Ability> abilities)
        {
            bool checkInventory = false;

            foreach (var item in player.Inventory)
            
            {
                if (item.Name == "Ржавый ключ")
                    checkInventory = true;
            }
            bool SycleVar2 = true;
            int DedMaksim = 0;
            while (SycleVar2)
            {
             while(DedMaksim <2)
                {
                    if (checkInventory)
                    {
                        Console.WriteLine($"к. Спросить о ржавом ключе ");
                    }
                    if (Gutter1_1Var)
                    {
                        Console.WriteLine("s. Мужики, мне бы шмотки поменять, пьяный был, упал в лужу");
                    }
                    Console.WriteLine("c. Спросить о мужите с бородой");
                    Console.WriteLine("e. Попросить поесть");
                    if (DedMaksim >= 1)
                    {
                    Console.WriteLine();
                    }
                    Console.WriteLine("");
                    dialogechoise = Console.ReadLine();
                    switch (dialogechoise)
                    {
                        case "k":
                            if (checkInventory)
                            {
                                Console.WriteLine($"{ nps[0].name}: Ничего себе! Петрович этот ключ две недели назад посеял!\n" +
                                                                $"Где ты его нашёл?\n" +
                                                                $"На куче обоссанных шмоток?\n" +
                                                                $"Ладно, не важно, давай его сюда!\n" +
                                                                $"Взамен получишь комплект чистых вещей" + $"");
                                Console.WriteLine("Начальник смены сдержал своё слово и выдал мне сухой комбенезон");
                                player.clothes.Clear();
                                player.clothes.Add(Lists.clothes[2]);
                                Console.WriteLine($"На тебе надето: {player.clothes[0].Name}");
                                //Конец помойки----------------------------------------------
                                SycleVar2 = false;
                            }
                            else
                                Gutter1_GachiLocaion(player, battle, easteregg, nps, enemies, misc);
                            break;
                        case "s":
                            if (Gutter1_1Var)
                                SycleVar2 = false;
                            Gutter1_GachiLocaion(player, battle, easteregg, nps, enemies, misc);
                            break;
                        case "c":
                            Console.WriteLine($"{ nps[0].name}: "+
                                "ты о Деде-Максиме? \n" +
                                "Он тут завсегдай! \n" +
                                "Главное не выбрасывай никогда бутылки при нём.\n" + "");
                            Console.WriteLine("1. Забудем...\n");
                            Console.WriteLine("2. Так может ему пезды дать, этому вашему Максиму?\n");
                            dialogechoise = Console.ReadLine();
                            switch (dialogechoise)
                            {
                                case "1":
                                    Console.WriteLine();
                                    break;
                                case "2":
                                    if(DedMaksim == 0)
                                    DedMaksim++;
                                    Console.WriteLine("Что-же. Могу лишь пожелать тебе удачи. \n" +
                                        "Дед-Максим тот ещё боец. \n" +
                                        "Он воевал 10 лет на Улицах Ярости во Въетнаме\n" +
                                        "Но раз хочешь дать пезды - значит есть за что.\n" +
                                        "Слушай. Максим живет в лочуге на краю помойки. \n" +
                                        "Если хочешь дать ему пизды - запомни: после Въетнама у него испортились Лёгкие. \n" +
                                        "Любой сильный запах крайне полезненнен для него\n" +
                                        "Надеюсь мой совет тебе поможет.");
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "e":
                            Console.WriteLine($"{ nps[0].name}: Есть только просроченное молоко");
                            if (DedMaksim >= 1)
                            {
                                bool SycleVar228 = true;
                                while(SycleVar228)
                                {
                                    Console.WriteLine("1. Настоять\n" +
                                                      "2. Назад");
                                    dialogechoise = Console.ReadLine();
                                    switch (dialogechoise)
                                    {
                                        case "1":
                                            
                                            DedMaksim++;
                                            Console.WriteLine("Выпив молока я почувствовал жуткое бурление в животе, а возможно ещё и силу земли!");
                                            player.abilities.Add(Lists.allAbilities[3]);
                                            Console.WriteLine($"Получено умение {Lists.allAbilities[3].Name}");
                                            Gutter1_Maksim(player, battle, easteregg, nps, enemies, misc, Enemy.Resistance);
                                            SycleVar228 = false;
                                            SycleVar2 = false;
                                            
                                            DedMaksim++;
                                            break;
                                        case "2":
                                            SycleVar228 = false;
                                            break;
                                        default:
                                            Console.WriteLine("Пиздец. Может уже выучишь расположение клавишь?");
                                            break;
                                    }
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void Gutter1_GachiLocaion(Player player, Battle battle, int easteregg, List<Nps> nps, List<Enemy> enemies, Misc misc)
        {
            Console.WriteLine($"{ nps[0].name}: Хех. Что-бы не всё так просто. Придётся тебе их отработать! \n" +
    $"Видишь мужики по пояс в глине стоят? \n" +
    $"Нужно помочь им помочь с песком смешать и в бетономешалку погрузить.\n" +
    $"Возьмёшься?\n" +
    $"1. А чего бы и не помесить глину, да с мужиками!\n" +
    $"2. Не, мужики, я лучше обоссаным похожу.");
            dialogechoise = Console.ReadLine();
            switch (dialogechoise)
            {
                case "1":
                    music.StartMusic("Music/gachi1.mp3");
                    Console.WriteLine("Я снял штаны.\n" +
                        "Мужики в глине были рады пополнению. \n" +
                        "Время пролетело не заметно как вся глина была переработана в бетон\n" +
                        "Попрощавшись с бригадой мне одобрительно кивнули.\n" +
                        "Начальник смены сдержал своё слово и выдал мне сухой комбенезон");
                    Console.WriteLine($"Пасхалок найдено {++easteregg}");
                    Console.ReadKey();
                    music.StopMusic();
                    Console.WriteLine("Мне не оставалось ничего больше, кроме как двигаться дальше, \n" +
                        "ведь у мене всё ещё нет чёткой картины того, что вчера было...");

                    //Конец помойки----------------------------------------------
                    break;
                case "2":
                    Console.WriteLine($"{ nps[0].name}: Вот и иди. Не смею задерживать");
                    Console.WriteLine("Мне не оставалось ничего больше, кроме как двигаться дальше, \n" +
                        "ведь у мене всё ещё нет чёткой картины того, что вчера было...");
                    
                    break;
                    //Конец помойки----------------------------------------------
                default:
                    music.StartMusic("Music/coffin.mp3");
                    Console.ReadKey();
                    music.StopMusic();
                    break;
            }
            
        }
        public void Gutter1_Maksim(Player player, Battle battle, int easteregg, List<Nps> nps, List<Enemy> enemies, Misc misc, List<Ability> abilities)
        {
            Console.WriteLine("Выпив прокисшего молока я с трудом сдерживаю в себе выхлоп.\n" +
                "Подходя к лочуге я всё больше начинал сомневался\n" +
                "Может Дед вовсе не такой плохой?\n");
            Console.ReadKey();
            Console.WriteLine("но было уже поздно");
            Console.ReadKey();
            Console.WriteLine("Как только я подошёл к небрежно собранной из бытовой утвори домишке из неё показался он...");
            battle.BossBattle(enemies[1], player, misc, Enemy.Resistance);
            Console.WriteLine("Обыскав лачугу деда мне удалось обнаружить:");
            player.Inventory.Add(Lists.items[0]);
            player.Inventory.Add(Lists.items[1]);
            player.Inventory.Add(Lists.items[2]);
            Console.WriteLine($"{Lists.items[0].Name} x3");
            Console.WriteLine($"Пошарив по карманам дедушки я у удивлением нашёл {Lists.questItems[1].Name}");
            player.Inventory.Add(Lists.questItems[1]);
            Console.WriteLine($"Пасхалок найдено {++easteregg}");
            Console.WriteLine("*Что-же, видимо на помойке мне делать больше нечего. Нужно продолжать идти дальше*");
        }
    }
}


