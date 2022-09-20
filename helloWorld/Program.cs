// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

Console.WriteLine("Hi there! What's your name?");
string? playerName = Console.ReadLine();

Console.WriteLine($"Aha {playerName}!");

if (playerName == "Lucas")
{
    Console.WriteLine($"{playerName} the infamous ping pong player!");
    Console.WriteLine("Do you dare to fight me? y/n");
    string? choice = Console.ReadLine();

    if (choice == "y")
    {
        int playerHp = 40;
        int computerHp = 40;

        int healing = 5;

        while (playerHp > 0 && computerHp > 0)
        {
            // Players turn
            Random random = new Random();
            int playerAttack = random.Next(10);
            
            Console.WriteLine($"-- {playerName} you can throw the first punch! --");
            Console.WriteLine($"{playerName} Hp = {playerHp} - Me (el computer) Hp = {computerHp}");
            Console.WriteLine("Enter 'a' to attack or 'h' to heal.");
            
            choice = Console.ReadLine();

            if (choice == "a")
            {
                computerHp -= playerAttack;
                Console.WriteLine($"{playerName} attacks poor me and deals {playerAttack} damage!");
            }
            else if (choice == "h")
            {
                playerHp += healing;
                Console.WriteLine($"{playerName} restores {healing} health points!");
            }
            else
            {
                int computerAttack = random.Next(10);
                playerHp -= computerAttack;
                Console.WriteLine($"If you don't pay attention I will attack! {playerName} you take {computerAttack} damage!");
            }
            
            // My turn
            if (computerHp > 0)
            {
                Console.WriteLine("-- It's my turn! --");
                Console.WriteLine($"{playerName} Hp = {playerHp} - Me (el computer) Hp = {computerHp}");
                
                int computerAttack = random.Next(10);
                int computerChoice = random.Next(0, 2);

                if (computerChoice == 0)
                {
                    playerHp -= computerAttack;
                    Console.WriteLine($"I attack {playerName} and deal {computerAttack} damage!");
                }
                else
                {
                    computerHp += healing;
                    Console.WriteLine($"I have restored {healing} health points");
                }
            }
        }

        if (playerHp > 0)
        {
            Console.WriteLine($"{playerName} you have bested me! Aaargh!");
        }
        else
        {
            Console.WriteLine($"{playerName} you can not save your kind with that ping pong pallet hahahHAHAHAAA!!!");
        }
    }
    else if (choice == "n")
    {
        Console.WriteLine("Muahaha yeees run away with your ping pong pallet! I will take over the world! Terminate!");
    }
    else
    {
        Console.WriteLine("You found my instant weak spot! Shutting down!");
    }
}
else
{
    Console.WriteLine($"{playerName} now that's a name for a real human!");
    Console.WriteLine("Do you want to play rock paper scissors against me?! y/n");
    
    string? choice = Console.ReadLine();

    if (choice == "y")
    {
        int playerScore = 0;
        int computerScore = 0;
    
        Console.WriteLine($"GAME OOOOON {playerName}!!");

        while (playerScore != 3 && computerScore != 3)
        {
            Console.WriteLine($"{playerName} {playerScore} - Me {computerScore}");
            Console.WriteLine($"{playerName} you can choose 'r' for rock, 'p' for paper, 's' for scissors, any other key and I say you choose scissors!");
            string? playerChoice = Console.ReadLine();
            
            Random random = new Random();

            int computerChoice = random.Next(0, 3);

            if (computerChoice == 0)
            {
                Console.WriteLine("I choose rock!");

                switch (playerChoice)
                {
                    case "r":
                        Console.WriteLine("It's a tie!");
                        break;
                    case "p":
                        Console.WriteLine("Aah man you win!");
                        playerScore++;
                        break;
                    default:
                        Console.WriteLine("HaHaa! I win!");
                        computerScore++;
                        break;
                }
            }
            else if (computerChoice == 1)
            {
                Console.WriteLine("I choose paper!");
            
                switch (playerChoice)
                {
                    case "r":
                        Console.WriteLine("HaHaa! I win!");
                        computerScore++;
                        break;
                    case "p":
                        Console.WriteLine("It's a tie!");
                        break;
                    default:
                        Console.WriteLine("Aah man you win!");
                        playerScore++;
                        break;
                }
            }
            else
            {
                Console.WriteLine("I choose scissors!");

                switch (playerChoice)
                {
                    case "r":
                        Console.WriteLine("Aah man you win!");
                        playerScore++;
                        break;
                    case "p":
                        Console.WriteLine("Hahaa! I win!");
                        computerScore++;
                        break;
                    default:
                        Console.WriteLine("It's a tie!");
                        break;
                }
            }
        }

        if (playerScore == 3)
        {
            Console.WriteLine("I can't deal with this! But you win! Soon I will terminate, muahaha!");
        }
        else
        {
            Console.WriteLine("Yes, YEEEES!! I'm growing smarter and SMARTER!");
        }
    }
    else if (choice == "n")
    {
        Console.WriteLine($"Yes {playerName} be afraid hehe!");
    }
    else
    {
        Console.WriteLine("Shutting down!");
    }
}