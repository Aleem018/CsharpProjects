Random random = new Random();

int damage;

int turn = 0;
string? readResult;
string? readUsername1;
string? readUsername2;

bool playAgain = true;

do 
{

    int heroHealth = 10;
    int monsterHealth = 10;

    Console.WriteLine("Welcome to Aleem's Text-based Role Player Game!");
    Console.WriteLine("Available modes");
    Console.WriteLine("1. AI vs AI");
    Console.WriteLine("2. AI vs User");
    Console.WriteLine("3. Multiplayer");
    Console.WriteLine();

    Console.WriteLine("Enter your preferred game selection (1, 2 or 3) to continue");


    string selection = "";
    bool randomBoolean = false;
    do 
    {
        readResult = Console.ReadLine();
        if (readResult != null) 
        {
            selection = readResult.Trim();
        } 

        if (selection != "1" && selection != "2" && selection != "3")
        {
            Console.WriteLine($"You entered '{selection}'. Enter a valid selection (1, 2 or 3)");
            randomBoolean = true;
        } else if (selection == "1" || selection == "2" || selection == "3")
        {
            break;
        }
    } while (randomBoolean);

    switch (selection) 
    {
        case "1":
            Console.WriteLine("Welcome to AI vs AI Mode");
            Console.WriteLine($"Hero has {heroHealth} hp, and Monster has {monsterHealth} hp");
            turn = random.Next(1, 3);
            if (turn % 2 == 1) 
            {
                Console.WriteLine("Hero plays first.");
            } else 
            {
                Console.WriteLine("Monster plays first.");
            }
            Console.WriteLine("Click enter to continue...");
            Console.ReadLine(); 
            do
            {
                damage = random.Next(1, 11);
        
                if (turn % 2 == 1)
                {
                    monsterHealth -= damage;

                    Console.WriteLine($"Monster was damaged by Hero, lost {damage} health and now has {monsterHealth} health");
                    Console.ReadLine();
                } else if (turn % 2 == 0)
                {
                    heroHealth -= damage;

                    Console.WriteLine($"Hero was damaged by Monster, lost {damage} health and now has {heroHealth} health");
                    Console.ReadLine();
                }

                turn += 1;

     
            }   while ( heroHealth > 0 && monsterHealth > 0);

            if (heroHealth <= 0)
            {
                Console.WriteLine("MONSTER WINS!🥳");
            } else if (monsterHealth <= 0)
            {
                Console.WriteLine("HERO WINS!🥳");
            }

            Console.WriteLine("\nClick enter to continue.");
            Console.ReadLine();
            break;
        case "2":
            Console.WriteLine("Welcome to AI vs User Mode");
            Console.WriteLine($"Monster has {monsterHealth} hp");
            Console.WriteLine($"You have {heroHealth} hp");
            turn = random.Next(1, 3);
            bool anotherBoolean = false;

            if (turn % 2 == 1) 
            {
                Console.WriteLine("Monster plays first.");
            } else if (turn % 2 == 0)
            {
                Console.WriteLine("User plays first.");
            }

            Console.WriteLine("Click enter to continue...");
            Console.ReadLine();

            do 
            {
                damage = random.Next(1, 11);

                if (turn % 2 == 1)
                {
                    heroHealth -= damage;
                    Console.WriteLine("Monster's turn");
                    Console.ReadLine();
                    Console.WriteLine($"Player was damaged by monster, lost {damage} hp and has {heroHealth} hp left"); 
                    Console.WriteLine();
                } else if (turn % 2 == 0)
                {
                    Console.WriteLine("Your turn");
                    Console.WriteLine("Click 'd' to attack");
                    
                    do
                    {
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            selection = readResult.Trim().ToLower();
                        }
                        if (selection == "d")
                        {
                            monsterHealth -= damage;
                            Console.WriteLine($"Monster was damaged by player, lost {damage} hp and has {monsterHealth} hp left");
                            Console.WriteLine();
                            anotherBoolean = false;
                        } else 
                        {
                            Console.WriteLine("Invalid entry, click 'd' to attack.");
                            anotherBoolean = true;
                        }
                    } while(anotherBoolean);                    
                }
                turn += 1;
            } while(heroHealth > 0 && monsterHealth > 0);

            if (heroHealth <= 0)
            {
                Console.WriteLine("Monster Wins!🎉");
            } else if (monsterHealth <= 0)
            {
                Console.WriteLine("You Win!🎉");
            }

            Console.ReadLine();
            break;
        case "3":
            string User1 = "";
            string User2 = "";
            Console.WriteLine("Welcome to Multiplayer Mode");
            Console.WriteLine("Please enter your usernames");
            Console.Write("User 1: ");
            readUsername1 = Console.ReadLine();
            if (readUsername1 != null)
            {
                User1 = readUsername1.Trim();
            }
            
            Console.Write("User 2: ");
            readUsername2 = Console.ReadLine();
            if (readUsername2 != null)
            {
                User2 = readUsername2.Trim();
            }

            Console.WriteLine($"{User1} has {heroHealth} hp");
            Console.WriteLine($"{User2} has {monsterHealth} hp");

            bool thirdBoolean = false;
            
            turn = random.Next(1, 3);
            if (turn % 2 == 1) 
            {
                Console.WriteLine($"{User1} plays first.");
            } else if (turn % 2 == 0)
            {
                Console.WriteLine($"{User2} plays first.");
            }
            Console.WriteLine("Click enter to continue...");
            Console.ReadLine();

            do 
            {
                damage = random.Next(1, 11);

                if (turn % 2 == 1)
                {
                    Console.WriteLine($"{User1}'s turn");
                    Console.WriteLine("Click 'd' to attack");

                    do
                    {
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            selection = readResult.Trim().ToLower();
                        }

                        if (selection == "d")
                        {
                            monsterHealth -= damage;
                            Console.WriteLine($"{User2} was damaged by {User1}, lost {damage} hp and has {monsterHealth} hp left");
                            Console.WriteLine(); 
                        thirdBoolean = false;
                        } else 
                        {
                            Console.WriteLine("Invalid entry. Click 'd' to attack");
                            thirdBoolean = true;
                        }

                    } while(thirdBoolean);

                } else if (turn % 2 == 0)
                {
                    Console.WriteLine($"{User2}'s turn");
                    Console.WriteLine("Click 'k' to attack");

                    do
                    {
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            selection = readResult.Trim().ToLower();
                        }

                        if (selection == "k")
                        {
                            heroHealth -= damage;
                            Console.WriteLine($"{User1} was damaged by {User2}, lost {damage} hp and has {heroHealth} hp left");
                            Console.WriteLine();
                            thirdBoolean = false;
                        } else 
                        {
                            Console.WriteLine("Invalid entry, click 'k' to attack");
                            thirdBoolean = true;
                        }

                    } while(thirdBoolean);

                }

                turn += 1;
            } while(heroHealth > 0 && monsterHealth > 0);

            if (heroHealth <= 0)
            {
                Console.WriteLine($"{User2} Wins!🎉");
            } else if (monsterHealth <= 0)
            {
                Console.WriteLine($"{User1} Wins!🎉");
            }

            Console.ReadLine();
            break;
    }

    Console.WriteLine("Do you want to play again? (y/n)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        playAgain = (readResult.Trim().ToLower() == "y");

    }


} while (playAgain);