string[] OrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string orderID in OrderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

double[] CGPAs = [2.34, 3.45, 4.67, 4.65, 2.43, 3.23, 3.98, 4.01];
// To get each cgpa greater than 4.00

foreach (double CGPA in CGPAs)
{
    if (CGPA >= 4.00)
    {
        Console.WriteLine(CGPA);
    }
}

