public class Program
{
    public static void Main()
    {
        const int rock = 0;
        const int paper = 1;
        const int scissor = 2;
        const int invalid = -1;

        
        
        
        int seed = (int)DateTime.Now.Ticks;
        Random random = new Random();
        int draw = 0;
        int winning = 0;
        int losses = 0;
        int userMove;
        
        
        do
        {
        Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors, or [q]uit:");
        string input = Console.ReadLine().ToLower();
        
        if (input == "r" || input == "rock")
        {
            userMove = rock;
        }
        else if (input == "p" || input == "paper")
        {
            userMove = paper;
        }
        else if (input == "s" || input == "scissor")
        {
            userMove = scissor;
        }
        else if (input == "q" || input == "quit")
        {
            break;
        }
        else
        {
            Console.WriteLine("invalid");
            continue;
        }
        int computermove = random.Next(0, 3);

        int result = 0;
        if (userMove == rock)
        {
            if (computermove == paper)
            {
                result = 1;
            }
            else if (computermove == scissor)
            {
                result = invalid;
            }
            else
            {
                result = 0;
            }
            
        }
        else if (userMove == paper)
        {
            if (computermove == scissor)
            {
                result = 1;
            }
            else if (computermove == paper)
            {
                result = invalid;
            }
            else
            {
                result = 0;
            }
        }
        else if (userMove == scissor)
        {
           if (computermove == rock)
            {
                result = 1;
            }
            else if (computermove == paper)
            {
                result = -1;
            }
            else
            {
                result = 0;
            } 
        }

        switch (result)
        {
            case 0:
                Console.WriteLine("draw");
                draw++;
                break;

            case 1:
                Console.WriteLine("you lose");
                losses++;
                break;

            case -1:
                Console.WriteLine("you win");
                winning++;
                break;
            default:
                Console.WriteLine("error");
                break;
        }

        switch (userMove)
        {
            case rock:
                Console.Write("you choose rock");
                break;
            case paper:
                Console.Write("you choose paper");
                break;
            case scissor:
                Console.Write("you choose scissor");
                break;

        }
        switch (computermove)
        {
            case rock:
                Console.WriteLine(" and computer choose rock");
                break;
            case paper:
                Console.WriteLine(" and computer choose paper");
                break;
            case scissor:
                Console.WriteLine(" and computer choose scissor");
                break;

        }
        Console.WriteLine($"{userMove} {computermove}");
        Console.WriteLine("Score: {0} wins, {1} losses, {2} draws", winning, losses, draw);
        }
        while (true);
    }
}