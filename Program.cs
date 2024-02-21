﻿
﻿public class Program
{
    public static void Main()
    {
        const int rock = 0;
        const int paper = 1;
        const int scissor = 2;
        const int invalid = -1;
        const int spock = 3;
        const int lizard = 4;




        int seed = (int)DateTime.Now.Ticks;
        Random random = new Random();
        int draw = 0;
        int winning = 0;
        int losses = 0;
        int userMove;


        do
        {
        Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors, [sp]ock, [lz]ard or [q]uit:");
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
        else if (input == "sp" || input == "spock")
        {
            userMove = spock;
        }
        else if (input == "lz" || input == "lizard")
        {
            userMove = lizard;
        }
        else
        {
            Console.WriteLine("invalid");
            continue;
        }
        int computermove = random.Next(0, 5);

        int result = 0;
        if (userMove == rock)
        {
            if (computermove == paper || computermove == spock)
            {
                result = 1;
            }
            else if (computermove == scissor || computermove == lizard)
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
            if (computermove == scissor || computermove == lizard)
            {
                result = 1;
            }
            else if (computermove == rock || computermove == spock)
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
           if (computermove == rock || computermove == spock)
            {
                result = 1;
            }
            else if (computermove == paper || computermove ==lizard)
            {
                result = -1;
            }
            else
            {
                result = 0;
            } 
        }
        else if (userMove == spock)
        {
            if(computermove == paper || computermove == lizard)
            {
                result = 1;
            }
            else if (computermove == rock || computermove == scissor)
            {
                result = -1;
            }

        }
        else if (userMove == lizard)
        {
            if (computermove == rock || computermove == scissor)
            {
                result = 1;
            }
            else if (computermove == spock || computermove == paper)
            {
                result = -1;
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
            case spock:
                Console.Write("you choose spock ");
                break;
            case lizard:
                Console.Write("you choose lizard ");
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
            case spock:
                Console.WriteLine("and computer choose spock");
                break;
            case lizard:
                Console.WriteLine("and computer choose lizard");
                break;

        }
        Console.WriteLine($"{userMove} {computermove}");
        Console.WriteLine("Score: {0} wins, {1} losses, {2} draws", winning, losses, draw);
        }
        while (true);
    }
}