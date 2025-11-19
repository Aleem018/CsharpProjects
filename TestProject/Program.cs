/* // Code project 1- Code that validates integer input

Console.WriteLine("Enter an integer value between 5 and 10.");

string? readResult;
int numericValue = 0;
bool validNumber = false;
do
{
    do
    {
        readResult = Console.ReadLine();
    } while (readResult == null);


    validNumber = int.TryParse(readResult, out numericValue);
    if (validNumber == false)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
        continue;
    }

    if (numericValue < 5 || numericValue > 10)
    {
        Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
        continue;
    } else if (numericValue >= 5 && numericValue <= 10)
    {
        break;
    }

    
} while (true);

Console.WriteLine($"Your input value ({numericValue}) has been accepted!");

*/

/*
// Code project 2- write code that validates string input

Console.WriteLine("Enter your role name (Administrator, Manager or User)"); 

string? roleName;
string inputValue;
do
{
    do
    {
        roleName = Console.ReadLine();
    } while (roleName == null);

    inputValue = roleName.ToLower().Trim();
    if (inputValue == "administrator" || inputValue == "manager" || inputValue == "user")
    {
        break;
    } else
    {
        Console.WriteLine($"The role name you entered, '{roleName}' is not valid. Enter your role name (Administrator, Manager or User)");
    }

} while (true);

Console.WriteLine($"Your input value ({roleName.Trim()}) has been accepted.");
*/

// Code project 3- Code that processes the contents of a string array.

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // to extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {
        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

    // the remainder of myString is the string value to the right of the location
    myString = myString.Substring(periodLocation + 1);

    // remove any leading white-space from myString
    myString = myString.TrimStart();

    // update the period location and increment the counter
    periodLocation = myString.IndexOf(".");

    Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);

}