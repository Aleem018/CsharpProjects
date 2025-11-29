string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float total = 0;

string message = "";
foreach (var value in values)
{
    float number;
    if (float.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");