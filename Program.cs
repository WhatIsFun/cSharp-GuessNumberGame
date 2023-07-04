namespace Guessing_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            int count = 0;
            Console.WriteLine("    Welcome To    ");
            Console.WriteLine(" +-+-+-+-+-+-+-+-+-+\r\n |W|h|a|t|I|s|F|u|n|\r\n +-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("Guesiing Number Game\n");
            while (true)
            {
                Console.Write("Guess a number between 1 and 100: ");
                string guessNumber = Console.ReadLine();

                try
                {
                    int guess = int.Parse(guessNumber);

                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                        ++count;
                    }
                    else if (guess == randomNumber)
                    {
                        ++count;
                        Console.WriteLine("Congratulations! You guessed the number " + randomNumber + " After " + count + " tries.");
                        Console.ReadLine();
                        break;
                        
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("higher. Try again.");
                        ++count;
                    }
                    else
                    {
                        Console.WriteLine("lower. Try again.");
                        ++count;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    ++count;
                }
            }
        }
    }
    
}