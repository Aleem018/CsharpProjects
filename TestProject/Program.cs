/* Question

int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
*/

// My solution

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        bool found = true;

        if (found)
            Console.WriteLine("Set contains 42");
    }
}

Console.WriteLine($"Total: {total}");

// This also works

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42)
//         found = true;  
// }

// if (found)
// {
//     Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");