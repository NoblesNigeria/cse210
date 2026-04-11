using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
         GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("0. Exit");

            string choice = Console.ReadLine();

                if (choice == "1")
                {

                    CreateGoal(manager);
                }

                else if (choice == "2")
                {
                    manager.DisplayGoals();
                }

                else if (choice == "3")
                {
                    manager.DisplayGoals();
                    Console.Write("Select goal: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                }

                else if (choice == "4")
                {
                    manager.Save("goals.txt");
                }

                else if (choice == "5")
                {
                    manager.Load("goals.txt");
                }

                else if (choice == "6")
                {
                    manager.ShowScore();
                }

                else if (choice == "0")
                {
                    return;
                }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

            if (type == "1")
            {
                manager.AddGoal(new SimpleGoal(name, desc, points));
            }

             else if (type == "2")
             {
                manager.AddGoal(new EternalGoal(name, desc, points));
             }

             else if (type == "3")
             {
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
             }

       
        {
            case "1":
                manager.AddGoal(new EternalGoal(name, desc, points));
                break;

            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }

    }

}