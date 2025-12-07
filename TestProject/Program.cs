// string message = "hello there";

// int first_h = message.LastIndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));

// To retrieve all instances of substrings inside parentheses
string message1 = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition1 = message1.IndexOf('(');
    if (openingPosition1 == -1) break;

    openingPosition1 += 1;
    int closingPosition1 = message1.IndexOf(')');
    int length1 = closingPosition1 - openingPosition1;
    Console.WriteLine(message1.Substring(openingPosition1, length1));

    // To return the remaining unprocessed message
    message1 = message1.Substring(closingPosition1 + 1);
}