Random value = new Random();
int number = value.Next(0,2);
Console.WriteLine(number);
Console.WriteLine($"Result: {(number > 0 ? "heads" : "tails" )}");