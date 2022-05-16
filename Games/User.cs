namespace rpsgame.Games
{
    public class User
    {
        public string name { get; set; }
        public string choice { get; set; }

        public User()
        {
            name = "User";
            choice = getchoice();
        }

        public virtual string getchoice()
        {
            Console.WriteLine("Enter your choice of rock paper scissor");
            string choice = Console.ReadLine().ToLower();
            Console.WriteLine();
            return choice;
        }

        public void showName()
        {
            Console.WriteLine("{0} choose:", name);
        }

        public void showChoice()
        {
            Console.WriteLine("Answer: {0}", choice);
        }

    }
}