namespace NumberGuessingGame {
    class Program {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(0, 100);
            bool win = false;

            do {
                System.Console.Write("Guess a number between 0 and 100: ");
                string s = System.Console.ReadLine();
                int i = int.Parse(s);

                if (i > winNum) {
                    System.Console.WriteLine("Too high, try again!");
                } else if (i < winNum) {
                    System.Console.WriteLine("Too low, try again!");
                } else {
                    System.Console.WriteLine("You win!");
                    win = true;
                }
            } while ( win == false);
        }
    }
}