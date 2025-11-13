Random number = new Random();
int correctGuess = number.Next(0, 100);

string[] guesses = [];

Console.Write("Enter your first guess: ");
string firstGuess = Console.ReadLine();
int guess1 = int.Parse(firstGuess);

if (guess1 == correctGuess) {
    Console.WriteLine("You win!");
} else if (guess1 > correctGuess) {
    Console.WriteLine("Your guess is too high!");
} else if (guess1 < correctGuess) {
    Console.WriteLine("Your guess is too low!");
}

Console.WriteLine(correctGuess);
Console.WriteLine(guess1);