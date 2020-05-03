using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Loot
    {
        public void TakeLoot(Player player, Enemy enemy)
        {

            Random random1 = new Random();
            int DropChance = random1.Next(1, 1); /*Шанс выбить шмотку 50%*/
            if (DropChance == 1)
            {
                Random random2 = new Random();
                int DropChoise = random2.Next(0, Lists.items.Count); /*Выбор Шмотки из пула*/
                player.Inventory.Add(Lists.items[DropChoise - 1]); /*Добавление шмотки в Инвентарь*/
                Console.WriteLine($"{enemy.name} оставил после себя {Lists.items[DropChoise - 1].Name}!");
                Lists.items.Remove(Lists.items[DropChoise - 1]);
                Console.WriteLine($"Твой инвентарь: ");
                foreach (var predmet in player.Inventory)
                {
                    Console.WriteLine($"{player.Inventory.IndexOf(predmet) + 1} {predmet.Name}");
                }
            }
        }
    }
}
