namespace GalacticQuest
{
    internal class Program
    {
        enum GameAction
        {
            Monsters = 1,
            Exit = 0
        }

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                string input = Console.ReadLine();
                int.TryParse(input, out int parsedInput); // int parsedInput = input(din string in int)

                switch (parsedInput)
                {
                    case (int)GameAction.Monsters: // if parsedInput == 1
                        Console.WriteLine("Hello monsters");
                        break;
                    case (int)GameAction.Exit: // if parsedInput == 0
                        Console.WriteLine("You will exit");
                        isRunning = false;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Hello, World!");
        }
    }
}