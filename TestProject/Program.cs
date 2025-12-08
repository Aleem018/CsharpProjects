// string message = "Hello, world!";
// char[] charsToFind = { 'a', 'e', 'i' };

// int index = message.IndexOfAny(charsToFind);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Mesage: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() method requires a char array of characters

char[] openSymbols = { '[', '{', '(' };

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now, to find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify that the search for the matching symbol should start at the openingPosition in the string

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally...

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
