namespace rpsgame.Games
{
    public class Computer : User
    {
        public Computer()
        {
            name = "Computer";
            choice = getchoice();
        }

        public override string getchoice()
        {
            Random random = new Random();

            string[] choices = { "rock", "paper", "scissor" };

            int rnd = random.Next(choices.Length);

            string result = choices[rnd];

            return result;
        }
    }
}