using System;
using System.Collections.Generic;
using System.Linq;

class Monster
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
}

class tema2curs3
{
    static Dictionary<string, Monster> monsters = new Dictionary<string, Monster>()
    {
        { "Goblin", new Monster{ Name="Goblin", Health=30, Attack=5 } },
        { "Orc", new Monster{ Name="Orc", Health=60, Attack=10 } },
        { "Dragon", new Monster{ Name="Dragon", Health=300, Attack=40 } },
        { "Slime", new Monster{ Name="Slime", Health=20, Attack=2 } },
        { "Vampire", new Monster{ Name="Vampire", Health=100, Attack=15 } },
        { "Zombie", new Monster{ Name="Zombie", Health=50, Attack=6 } },
        { "Werewolf", new Monster{ Name="Werewolf", Health=120, Attack=20 } }
    };

    static void Main()
    {
        MainMenu();
    }

    // -------------------------------------------
    // MAIN MENU
    // -------------------------------------------
    static void MainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select One Option:\n");
            Console.WriteLine("1. Monsters");
            Console.WriteLine("2. Travel");
            Console.WriteLine("3. Journal");
            Console.WriteLine("4. Exit");

            Console.Write("\nChoose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": MonstersMenu(); break;
                case "2": TravelMenu(); break;
                case "3": JournalMenu(); break;
                case "4": return; // EXIT APP
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    // -------------------------------------------
    // MONSTERS MENU
    // -------------------------------------------
    static void MonstersMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== MONSTERS ===\n");

            foreach (var m in monsters.Values)
            {
                Console.WriteLine($"{m.Name} - HP: {m.Health}, ATK: {m.Attack}");
            }

            Console.WriteLine("\n1. Filter By Name");
            Console.WriteLine("2. Back");

            Console.Write("\nChoose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": FilterMonsters(); break;
                case "2": return; // go back
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void FilterMonsters()
    {
        Console.Clear();
        Console.Write("Enter part of a name to filter: ");

        string filter = Console.ReadLine().ToLower();

        var results = monsters.Values
            .Where(m => m.Name.ToLower().Contains(filter))
            .ToList();

        Console.WriteLine();

        if (results.Count == 0)
        {
            Console.WriteLine("No monsters match that search.\n");
            ShowAllMonsters();
        }
        else
        {
            Console.WriteLine("Filtered Monsters:\n");
            foreach (var m in results)
            {
                Console.WriteLine($"{m.Name} - HP: {m.Health}, ATK: {m.Attack}");
            }
        }

        Console.WriteLine("\nPress Enter to go back...");
        Console.ReadLine();
    }

    static void ShowAllMonsters()
    {
        Console.WriteLine("All Monsters:\n");
        foreach (var m in monsters.Values)
        {
            Console.WriteLine($"{m.Name} - HP: {m.Health}, ATK: {m.Attack}");
        }
    }

    // -------------------------------------------
    // TRAVEL MENU
    // -------------------------------------------
    static void TravelMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== TRAVEL ===\n");
            Console.WriteLine("1. Explore");
            Console.WriteLine("2. Search For Items");
            Console.WriteLine("3. Back To Ship");

            Console.Write("\nChoose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Console.WriteLine("Exploring..."); break;
                case "2": Console.WriteLine("Searching..."); break;
                case "3": return;
                default: Console.WriteLine("Invalid option."); break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    // -------------------------------------------
    // JOURNAL MENU
    // -------------------------------------------
    static void JournalMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== JOURNAL ===\n");
            Console.WriteLine("1. Monsters");
            Console.WriteLine("2. Planets");
            Console.WriteLine("3. Items");
            Console.WriteLine("4. Back");

            Console.Write("\nChoose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": MonstersMenu(); break;
                case "2": Console.WriteLine("No planets yet."); break;
                case "3": Console.WriteLine("No items yet."); break;
                case "4": return;
                default: Console.WriteLine("Invalid option."); break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
