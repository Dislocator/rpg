using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg
{
    class Street
    {
        public int CurrentLocation = 1;
        Random RandomDodge = new Random();
        string dialogechoise;
        string dialogechoise2;
        string locationchoise;
        public int ChosenLocation = 1;
        public void Street_Location(Player player, Battle battle, int easteregg, List<Nps> nps, Misc misc, List<Enemy> enemies, List<Ability> abilities)
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
            Console.ReadKey();
            Console.WriteLine("Пройдя ещё немного я услышал приглушённый крик в далеке.\n" +
                "1. Проверить\n" +
                "2. Продолжать идти домой");
            locationchoise = Console.ReadLine();
            switch (locationchoise)
            {
                case "1":
                    StreetKot(player, battle, enemies, misc, easteregg);
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine(".|.");
                    break;

            }
            Console.WriteLine("Я был почти у дома, как вдруг почувствовал необъяснимое голос в голове.\n" +
                "Казалось - он хотел отвести меня куда-то\n" +
                "1. Продолжить идти домой\n" +
                "2. Пойти на голос");
            locationchoise = Console.ReadLine();
            switch (locationchoise)
            {
                case "1":
                    YarikHome(player, battle, easteregg, nps, misc, enemies);
                    break;
                case "2":
                    Reptiloid(player, battle, easteregg, nps, misc, enemies);
                    break;
                default:
                    break;
            }
        }
        public void RoadYarik(Player player, Battle battle, int easteregg, List<Nps> nps, Misc misc, List<Enemy> enemies)
        {
            foreach (var item in player.Inventory)
            {
                if (item.Name == "Двi гривнi")
                {
                    Console.WriteLine("Ярик жил достаточно далеко от места где я очутился\n" +
                   "у меня было 2 Варианта:" +
                   "1. Идти пешком" +
                   "2. Поехать на тролейбусе ");
                    locationchoise = Console.ReadLine();
                    switch (locationchoise)
                    {
                        case "1":
                            Gopniks(player, battle, enemies, misc);
                            break;
                        case "2":
                            YarikHome(player, battle, easteregg, nps, misc, enemies);
                            break;
                        default:
                            break;
                    }    

                }
                else
                    Gopniks(player, battle, enemies, misc);
            }
            
            //Пошутить про дви грывни
        }
        public void Gopniks(Player player, Battle battle, List<Enemy> enemies, Misc misc)
        {
            Console.WriteLine("К несчастью всё оказалось не так просто и на мой путь переградили знакомые мне  Сева, Васян и Петька, заядлые алкаши и гопники  ");
            Console.WriteLine($"{ enemies[2].name}: Слышь, братишка. Тормозни—ка, базар есть. \n" +
                $"А чо ты рамсишь—то? Ты чо такой голимый? Это что на тебе {player.clothes[0].Name}?");
            Console.ReadKey();
            Console.WriteLine($"{ enemies[4].name}:Братишка, постой—ка.Ты откуда такой красивый идешь?");
            Console.ReadKey();
            Console.WriteLine($"{ enemies[3].name}Дай куртку, пацану холодно.");
            Console.ReadKey();
            Console.WriteLine("1. Отдать куртку\n" +
                "2. Не отдавать");
            dialogechoise = Console.ReadLine();
            switch (dialogechoise)
            {
                case "1":
                    Console.WriteLine($"Гопота отжала у тебя {player.clothes[0].Name}");
                    player.clothes.Clear();

                    Console.ReadKey();
                    break;
                case "2":
                    
                    Console.WriteLine("Роняя семки, гопники убрались восвоясье");
                    Console.WriteLine("Немного опомнившись я продолжил путь домой.");
                    Console.WriteLine("******************************************");


                    break;
                default:
                    Console.WriteLine("По классике. Пошёл нах");
                    break;

            }
            Console.WriteLine($"Полный уверенности {enemies[2].name} влетает с ноги");
            battle.BattleStart(enemies[2], player, misc);
            Console.WriteLine($"Оттянув рассыпающегося на семки братана, {enemies[3].name} влетает с ноги");
            battle.BattleStart(enemies[3], player, misc);
            Console.WriteLine($"Остался лишь {enemies[4].name}");
            battle.BattleStart(enemies[4], player, misc);
            Console.WriteLine("Гопари повержены");
            Console.ReadKey();
        }
        public void StreetKot(Player player, Battle battle, List<Enemy> enemies, Misc misc, int easteregg)
        {
            Console.WriteLine("Быстрым шагом подойдя к месту события я выяснил, что источником звука выступала бабуля, стоящая у дерева.");
            Console.ReadKey();
            Console.WriteLine("Подойдя немного ближе бабушка не замечая меня продолжала что-то глазами искать на этом дереве.\n" +
                "Этим чем-то был ... Кот... ");
            Console.ReadKey();
            Console.WriteLine($"{Lists.nps[1].name}: Барсик, барсик, барсик! Иди сюда! Чего ты залез то туда? Нука слезай!");

            Console.WriteLine($"{Lists.nps[1].name}: Внучёк, помоги. Кот на дерево залез. А слезть не может!");
            Console.ReadKey();
            Console.WriteLine("1. Помочь\n" +
                "2. Придумать отмазку");
            dialogechoise = Console.ReadLine();
            switch (dialogechoise)
            {
                case "1":
                    Console.WriteLine("Хорошо. Бабуль.");
                    Console.WriteLine("*Чёрт ну и зачем я согласился спасать этого кота*");
                    Console.WriteLine("*Ладно, что может помочь мне его снять?*");
                    Console.ReadKey();
                    bool SycleVar2 = true;
                    while (SycleVar2)
                    {
                        Console.WriteLine("Попросить:\n" +
                        "1. Длинную бельевую верёвку\n" +
                        "2. Топор");
                        dialogechoise = Console.ReadLine();
                        bool SycleVar = true;
                        while (SycleVar)
                        {
                            switch (dialogechoise)
                            {

                                case "1":
                                    Console.WriteLine($"{ Lists.nps[1].name}: как как же ты его снимешь то?");
                                    Console.WriteLine($"{player.name}: а вы достаньте верёвку, Бабуля, мы вам покажем");
                                    Console.WriteLine("Что попросить в дополнение к верёвке?\n" +
                                        "1. Бутылку воды\n" +
                                        "2. Рулон туалетной бумаги\n" +
                                        "3. Отказаться от затеи");
                                    dialogechoise2 = Console.ReadLine();
                                    switch (dialogechoise2)
                                    {
                                        case "1":
                                            Console.WriteLine("Привязав бутылку воды к верёвке я поднялся на второй этаж многоквартирного дома");
                                            Console.ReadKey();
                                            Console.WriteLine("Как следует розмахнувшись я бросил заготовленный снаряд в сторону дерева. \n");
                                            Console.ReadKey();
                                            Console.WriteLine("*ХРЯСЬ*");
                                            Console.WriteLine("Но прогадав где - то на уровне пятного класа урока физики - бутылка под влияние гравитации не долетев до дерева\n" +
                                                "ударила в окно на первом этаже. Естественно разбив его");
                                            Console.ReadKey();
                                            break;
                                        case "2":
                                            //Добавить код подвала
                                            Console.WriteLine("Привязав рулон туалетной бумаги к верёвке я поднялся на второй этаж многоквартирного дома");
                                            Console.ReadKey();
                                            Console.WriteLine("Как следует розмахнувшись я бросил заготовленный снаряд в сторону дерева. \n");
                                            Console.ReadKey();
                                            Console.WriteLine("Долетев до дерева рулон замотался об ветку дерева");
                                            Console.ReadKey();
                                            Console.WriteLine($"{Lists.nps[2].name}: МЯЯУ!");
                                            Console.WriteLine("Как следует взявшись за верёвку я начал раскачивать дерево");
                                            Console.ReadKey();
                                            Console.WriteLine($"{Lists.nps[2].name}: МЯЯяяЯЯяЯУ!");
                                            Console.WriteLine("Дерево расшатывалось, но кот держался крепко");
                                            break;
                                        case "3":
                                            SycleVar = false;
                                            break;
                                        default:
                                            Console.WriteLine(".|.");
                                            break;
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Поблагодарив за топор я принялся рубить ствол дерева, на котором сидел потерпевший");
                                    Console.ReadKey();
                                    Console.WriteLine($"{Lists.nps[2].name}: МЯЯУ!");
                                    Console.WriteLine("СТУК");
                                    Console.ReadKey();
                                    Console.WriteLine("СТУК СТУК СТУК");
                                    Console.WriteLine("ХрР-Пдыщь");
                                    Console.ReadKey();
                                    Console.WriteLine("Дерево начало косить в сторону. Успех уже близок! ");
                                    Console.WriteLine($"{Lists.nps[2].name}: МЯЯяяЯЯяЯУ! ШШшШшш!");
                                    Console.ReadKey();
                                    Console.WriteLine("ХХРРРР-ПАММ!");
                                    Console.WriteLine("Обрубив основу, я дал небольшой толчок и дерево начало падать.\n");
                                    Console.ReadKey();
                                    Console.Clear();
                                    for (int i = 0; i < 3; i++)
                                    {
                                        Thread.Sleep(2000);
                                        Console.WriteLine("К моему большому удивления оно зацепившись за линии электро-передач не упало до конца");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                    
                                    //Добавить задержку 
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Запускаю запасное питание");
                                    Console.ResetColor();
                                    Thread.Sleep(3000);
                                    for (int i = 0; i < 20; i++)
                                    {
                                        
                                        Console.Write(".");
                                        Thread.Sleep(500);
                                    }
                                    Console.WriteLine("");
                                    Console.WriteLine("*Молодец.*");
                                    Console.ReadKey();
                                    Console.WriteLine("*Теперь жильцы всего района остались без света!.*");
                                    Console.ReadKey();
                                    Console.WriteLine("Но что с котом?");
                                    Console.ReadKey();
                                    Console.WriteLine("Бедняга перепугавшись до чортиков прыгнул на провода и отскочив от них святясь как пикачу убежал во дворы");
                                    Console.ReadKey();
                                    Console.WriteLine($"{player.name}: Что-же. Зато я спас кота!");
                                    Console.WriteLine($"{player.name}: Я выполнил приказ. Ведь выполнить приказ - первостепенно важно для меня!");
                                    Console.ReadKey();
                                    Console.WriteLine("Воспользовавшись всеобщей суматохой я забрал топор и пошёл дальше по своим делам");
                                    Console.ReadKey();
                                    player.Inventory.Add(Lists.questItems[2]);
                                    Console.WriteLine($"Получено {Lists.questItems[2].Name}");
                                    Console.WriteLine($"Пасхалок найдено: {++easteregg}");
                                    Console.ReadKey();
                                    SycleVar = false;
                                    SycleVar2 = false;
                                    break;
                                default:
                                    Console.WriteLine(".|.");
                                    break;
                            }
                        }

                    }


                    break;
                case "2":
                    Console.WriteLine($"{player.name}: {Lists.Dodge[GenerateDodge(RandomDodge)]}");
                    Console.WriteLine($"Пасхалок найдено: {++easteregg}");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine(".|.");
                    break;

            }

        }
        public int GenerateDodge(Random RandomDodge)
        {
            int Dodge = RandomDodge.Next(0, Lists.Dodge.Count);
            return Dodge;
        }
        public void Reptiloid(Player player, Battle battle, int easteregg, List<Nps> nps, Misc misc, List<Enemy> enemies)
        {
            Console.WriteLine("Повинуясь голосу я шёл за ним не обращая внимания на окружение");
            Console.WriteLine("Голос привёл меня к двери. Потянув за ручку ничего не произошло. Закрыто");
            Console.WriteLine("1. Назад");
            bool checkInventory = false;
            foreach (var item in player.Inventory)
            {

                if (item.Name == "Ржавый ключ")
                    
                    Console.WriteLine("2. Использовать Ржавый ключ");
                checkInventory = true;
                
            }
            locationchoise = Console.ReadLine();
            switch (locationchoise)
            {
                case "1":

                    break;
                case "2":
                    if (checkInventory)
                    {
                        Console.WriteLine("Поковыряв немного в дверном проёме я ничего не добился");
                        Console.WriteLine("Более детально осмотрев дверь я обнаружил довольно странной формы ещё одну дырку, \n" +
                            "предположительно для другого вида ключа");
                        Console.WriteLine("1. Уйти");
                        bool checkInventory2 = false;
                        foreach (var item in player.Inventory)
                        {

                            if (item.Name == "Деревянный член")
                                Console.WriteLine("2. Попробовать вставить деревянный член");
                            checkInventory2 = true;
                            
                        }
                        locationchoise = Console.ReadLine();

                        switch (locationchoise)
                        {
                            case "1":
                                break;
                            case "2":
                                if (checkInventory2)
                                {
                                    Console.WriteLine("С неподдельным удивлением я наблюдал как после поворота члена дверь распахнулась");
                                    Console.WriteLine("Как только я прошёл чуть дальше - дверь за мной захлопнулась. Обратного пути уже небыло");
                                    Console.WriteLine("То, куда я попал - было подвалом одного из Сталинских пятиэтажек. Славящегося своей запутанностью");
                                    Basement(player, battle, easteregg, nps, misc, enemies);
                                    
                                }
                                break;
                            default:
                                break;
                        }

                    }
                    else
                        checkInventory = false;
                    break;

                default:
                    break;
            }
        }
        public void Basement(Player player, Battle battle, int easteregg, List<Nps> nps, Misc misc, List<Enemy> enemies)
        {
            while(CurrentLocation != 8)
            {
                Console.WriteLine("Пройдя ещё пару шагов я оказался перед развилкой");
                //Console.WriteLine($"Позиция {CurrentLocation}");
                BasementChoise();
                switch (CurrentLocation)
                {
                    case 1:
                        if (ChosenLocation == 1)
                            CurrentLocation = 9;
                        else if (ChosenLocation == 2)
                            CurrentLocation = 2;
                        else
                            CurrentLocation = 1;
                        break;
                    case 2:
                        if (ChosenLocation == 1)
                            CurrentLocation = 15;
                        else if (ChosenLocation == 2)
                            CurrentLocation = 3;
                        else
                            CurrentLocation = 1;
                        break;
                    case 3:
                        if (ChosenLocation == 1)
                            CurrentLocation = 16;
                        else if (ChosenLocation == 2)
                            CurrentLocation = 4;
                        else
                            CurrentLocation = 1;
                        break;
                    case 4:
                        if (ChosenLocation == 3)
                            CurrentLocation = 5;
                        else
                            CurrentLocation = 1;
                        break;
                    case 5:
                        if (ChosenLocation == 1)
                            CurrentLocation = 6;
                        else if (ChosenLocation == 2)
                            CurrentLocation = 20;
                        else if (ChosenLocation == 3)
                            CurrentLocation = 19;
                        else
                            CurrentLocation = 1;
                        break;
                    case 6:
                        if (ChosenLocation == 1)
                            CurrentLocation = 7;
                        else
                            CurrentLocation = 1;
                        break;
                    case 7:
                        if (ChosenLocation == 1)
                            CurrentLocation = 8;
                        else if (ChosenLocation == 2)
                            CurrentLocation = 21;
                        else
                            CurrentLocation = 1;
                        break;
                    case 8:

                        break;
                    case 9:
                        if (ChosenLocation == 1)
                            CurrentLocation = 10;
                        else if (ChosenLocation == 2)
                            CurrentLocation = 15;
                        else
                            CurrentLocation = 1;
                        break;
                    case 10:
                        if (ChosenLocation == 1)
                            CurrentLocation = 17;
                        else if (ChosenLocation == 3)
                            CurrentLocation = 11;
                        else
                            CurrentLocation = 1;
                        break;
                    case 11:
                        if (ChosenLocation == 3)
                            CurrentLocation = 12;
                        else
                            CurrentLocation = 1;
                        break;
                    case 12:
                        if (ChosenLocation == 1)
                            CurrentLocation = 18;
                        else if (ChosenLocation == 2)
                            CurrentLocation = 13;
                        else
                            CurrentLocation = 1;
                        break;
                    case 13:
                        if (ChosenLocation == 1)
                            CurrentLocation = 22;
                        else if (ChosenLocation == 2)
                            CurrentLocation = 14;
                        else
                            CurrentLocation = 1;
                        break;
                    case 14:
                        if (ChosenLocation == 3)
                            CurrentLocation = 8;
                        else
                            CurrentLocation = 1;
                        break;

                    case 15:
                        if (ChosenLocation == 2)
                            CurrentLocation = 16;
                        else
                            CurrentLocation = 1;
                        break;
                    case 16:
                        CurrentLocation = 1;
                        break;
                    case 17:
                        if (ChosenLocation == 2)
                            CurrentLocation = 12;
                        else
                            CurrentLocation = 1;
                        break;
                    case 18:
                        if (ChosenLocation == 2)
                            CurrentLocation = 22;
                        else
                            CurrentLocation = 1;
                        break;
                    case 19:
                        CurrentLocation = 1;
                        break;
                    case 20:
                        CurrentLocation = 1;
                        break;
                    case 21:
                        CurrentLocation = 1;
                        break;
                    case 22:
                        CurrentLocation = 1;
                        break;
                    default:
                        break;

                }
                
            }
            
            Console.WriteLine("Блуждая по этому месту я и не надеялся выбраться, но к моему счастью я вышел в достаточно большую и остлённую комнату");
            Console.WriteLine("На небольшом стуле по среди комнаты сидела фигура в чёрном капюшоне");
            Console.ReadKey();
            string hello1 = "Неизвестный: Приветствую тебя.";
            string helloNormal1 = hello1;
            hello1 = ReverseString(hello1);
            Console.WriteLine("Неизвестный: Приветствую тебя.");
            Console.WriteLine($"{player.name}: Я не понимаю. Кто-ты?");
            string hello = "Если ты тот, о ком слагали легенды - ты всё поймёшь. Мы расса Нибириацев. Получили сигнал из земли отправленный из твоего планшета.";
            string helloNormal = hello;
            hello = ReverseString(hello);

            Console.WriteLine(hello);
            Console.WriteLine("1. Подумать");
            for (int i = 0; i < 20; i++)
            {

                Console.Write(".");
                Thread.Sleep(500);
            }

            Console.WriteLine($"{Lists.nps[3].name}: {helloNormal} ");
            Console.WriteLine($"{player.name}: Не может быть!? Ты - РЕПТИЛОИД!?");

            Console.WriteLine($"{Lists.nps[3].name}: Ты можешь присоедениться к нам и обрести силу Хамона. Или уйти и продолжить своё мирское существование\n" +
                $"1. Присоедениться\n" +
                $"2. Отказаться");
            dialogechoise = Console.ReadLine();
            switch (dialogechoise)
            {
                case "1":
                    player.abilities.Add(Lists.allAbilities[4]);
                    Console.WriteLine($"Получена способность: {Lists.allAbilities[4].Name}");
                    Console.ReadKey();
                    Console.WriteLine($"{Lists.nps[3].name} кивнул головой. Я начал чувствовать изменения внутри. \n" +
                        $"А может это были остатки молока рабочих? В прочим не важно. {Lists.nps[3].name} прервал ход моих мыслей");
                    
                    Console.WriteLine($"{ Lists.nps[3].name}: Теперь ты истинный Рептилоид\n" +
                        $"Я почувствовал слабость у упал в обморок, \a" +
                        $"а когда очнулся - был уже перед дверью Ярика");

                    YarikHome(player, battle, easteregg, nps, misc, enemies);
                    break;
                case "2":

                    misc.GameOver();

                    break;
                default:
                    break;

            }

        }
        public int BasementChoise()
        {

            if (CurrentLocation == 1 || CurrentLocation == 2 || CurrentLocation == 3 || CurrentLocation == 5 || CurrentLocation == 6 || CurrentLocation == 7 || CurrentLocation == 9 || CurrentLocation == 10 || CurrentLocation == 12 || CurrentLocation == 13)
            {
                Console.WriteLine("1. Влево");
            }
            if (CurrentLocation == 1 || CurrentLocation == 2 || CurrentLocation == 3 || CurrentLocation == 5 || CurrentLocation == 15 || CurrentLocation == 17 || CurrentLocation == 13 || CurrentLocation == 7 || CurrentLocation == 18 || CurrentLocation == 12)

            {
                Console.WriteLine("2. Направо");
            }
            if (CurrentLocation == 4 || CurrentLocation == 5 || CurrentLocation == 10 || CurrentLocation == 11 || CurrentLocation == 14)
            {
                Console.WriteLine("3. Прямо");
            }

            Console.WriteLine("4. В начало");

            locationchoise = Console.ReadLine();
            switch (locationchoise)
            {
                case "1":
                    if (CurrentLocation == 1 || CurrentLocation == 2 || CurrentLocation == 3 || CurrentLocation == 5 || CurrentLocation == 6 || CurrentLocation == 7 || CurrentLocation == 9 || CurrentLocation == 10 || CurrentLocation == 12 || CurrentLocation == 13)
                    {

                    }
                    break;
                case "2":
                    if (CurrentLocation == 1 || CurrentLocation == 2 || CurrentLocation == 3 || CurrentLocation == 5 || CurrentLocation == 15 || CurrentLocation == 17 || CurrentLocation == 13 || CurrentLocation == 7 || CurrentLocation == 18 || CurrentLocation == 12)
                    {

                    }
                    break;
                case "3":
                    if (CurrentLocation == 4 || CurrentLocation == 5 || CurrentLocation == 10 || CurrentLocation == 11 || CurrentLocation == 14)
                    {

                    }
                    break;
                case "4":
                    CurrentLocation = 1;
                    break;

                default:
                    break;
            }
             ChosenLocation = Convert.ToInt32(locationchoise);
            return ChosenLocation;
        }
        public static string ReverseString(string hello)
        {
            char[] arr = hello.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public void YarikHome(Player player, Battle battle, int easteregg, List<Nps> nps, Misc misc, List<Enemy> enemies)
        {
            Console.ReadKey();
            Console.WriteLine("Я позвонил в Ярику в дверь. Он какое то время не открывал, но потом раздались шаги");

            Console.ReadKey();
            Thread.Sleep(3000);
            Console.WriteLine($"Ярик: О Login, а что ты тут делаешь?");
            Console.WriteLine($" Login? Верно ведь это моё имя и вовсе не {player.name}");
            player.name = "Login";
            Console.ReadKey();
            Console.WriteLine($"Что вообще вчера произошло?\n" +
                "Ярик: Понятия не имею ты выпил всего стакан пива\n" +
                "Говорил о каких-то рептилоидах и Деде-Максиме. Потом вырубился");
            Console.ReadKey();
            Console.WriteLine("Это что-же получаеться - всё что я пережил - просто сон??");
            Console.ReadKey();
            Console.WriteLine("1. Ай к чёрту. Давай лучше в дотку\n" +
                "2. Ну раз это всё сон - omae wa mou shindeiru, Ярик");
            dialogechoise = Console.ReadLine();
            switch (dialogechoise)
            {
                case "1":
                    Console.WriteLine("Ярик: Ну пошли. Я на Энигме");
                    Console.WriteLine("ДОТЕРСКАЯ КОНЦОВКА ПОЛУЧЕНА");
                    Console.ReadKey();
                    misc.GameOver();
                    break;
                case "2":
                    Console.WriteLine("Ярик: NANI!");
                    battle.BattleYarir(enemies, player, misc, Lists.abilities, Lists.YarikAbility);
                    break;
                default:
                    break;
            }

        }
    }
}
