Random guess = new Random();
int number = guess.Next(0, 100);

Console.WriteLine(number);

// TO GET USER INPUT

// For words (string input)
Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine($"Hello, {name}");

// For numbers (numeric input)
Console.Write("Enter your age: ");
string ageInput = Console.ReadLine();

Console.WriteLine($"You are {ageInput} years old");
/* This works, but for something better...*/
Console.Write("Enter your age: ");
string ageInput2 = Console.ReadLine();
int age = int.Parse(ageInput2); //This converts the string to int

Console.WriteLine($"You are {age} years old");

// To add error handling
Console.Write("Enter a number: ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int num1))
{
    Console.WriteLine($"You entered {num1}");
}
else
{
    Console.WriteLine("Invalid Input! Enter a valid number.");
}

// For multiple inputs
Console.WriteLine("For multiple inputs...");

Console.Write("Enter your name: ");
string urName = Console.ReadLine();

Console.Write("Enter your age: ");
int urAge = int.Parse(Console.ReadLine());

Console.Write("Enter your city: ");
string urCity = Console.ReadLine();

Console.WriteLine($"I'm {urName}, I am {urAge} years old and i live in {urCity}.");

// For Single Character Input
Console.WriteLine("To test single character input (reading keys)...");
Console.Write("Press any key to continue...");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine($"\nYou pressed: {key.KeyChar}");

Console.WriteLine("For yes/no prompts...");
Console.Write("Do you want to continue? (y/n): ");
char response = Console.ReadKey().KeyChar;
Console.WriteLine();

if (char.ToLower(response) == 'y')
{
    Console.WriteLine("Continuing...");
}
else
{
    Console.WriteLine("Exiting...");
}

// NOTES
/*
Console.ReadLine() -> This gets a line of text input
Console.ReadKey() -> This gets a single key press
int.Parse() -> This converts a string to int (This gives exception on failure)
int.TryParse() -> This safely converts a string to int. It returns true/false
*/
