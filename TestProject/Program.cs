int firstValue = 500;
int secondValue = 600;
int largervalue = Math.Max(firstValue, secondValue);
int smallervalue = Math.Min(firstValue, secondValue);

Console.WriteLine(largervalue);
Console.WriteLine(smallervalue);

if (largervalue > smallervalue) {
    Console.WriteLine("Yup, this is accurate");
}
