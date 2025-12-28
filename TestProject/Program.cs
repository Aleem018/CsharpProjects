using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic;

Random random = new Random();

string? readResult = "";

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        int target;
        int roll;

        target = TargetMethod();
        roll = RollMethod();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
        
    }
}

bool ShouldPlay()
{
    bool test = false;
    do
    {
        readResult = Console.ReadLine();
        string answer = "";
        if (readResult != null)
        {
            answer = readResult.Trim().ToUpper();
        } else
        {
            Console.WriteLine("Error, cannot be a null value");
        }

        if (answer == "Y")
        {
            return true;
        } else if (answer == "N")
        {
            return false;
        } else
        {
            Console.WriteLine("Invalid input. Enter Y/N");
            test = true;
        }
    } while (test);

    return false;
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    } else
    {
        return "You lose!";
    }
    
}

int RollMethod()
{
    return random.Next(1, 7);
}

int TargetMethod()
{
    return random.Next(1,6);
}