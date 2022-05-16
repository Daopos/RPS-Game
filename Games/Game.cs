namespace rpsgame.Games
{
    public class Game
    {
        User user = new User();
        Computer comp = new Computer();
        public Game()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            user.showName();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            user.showChoice();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            comp.showName();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            comp.showChoice();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            this.getResult();
            Console.ResetColor();

        }

        public void getResult()
        {

            if (user.choice == "rock" && comp.choice == "scissor")
            {
                Console.WriteLine("User Win");
            }
            else if (user.choice == "paper" && comp.choice == "rock")
            {
                Console.WriteLine("User Win");
            }
            else if (user.choice == "scissor" && comp.choice == "paper")
            {
                Console.WriteLine("User Win");
            }
            else
            {
                Console.WriteLine("User Lose");
            }
        }

    }
}