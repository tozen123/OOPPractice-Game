using System;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character();
            player.Name = "John";

            Item health_potion = new Item();
            health_potion.Name = "Health Potion";
            player.Items.Add(health_potion);


            Character azeroth = new Character();
            azeroth.Name = "Azeroth";


            while (true)
            {
                Console.Clear();
                Console.WriteLine("OOP Practice");

                Console.WriteLine($"Character 1: {player.Name} ");
                Console.WriteLine($"Inventory: ");
                foreach (Item item in player.Items)
                {
                    Console.WriteLine($"{item.Name}");
                }
                Console.WriteLine("-");


                Console.WriteLine($"Character 2: {azeroth.Name} ");
                
                Console.WriteLine("-");

                Console.Read();
            }
        }
    }
}
