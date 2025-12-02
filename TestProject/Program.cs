string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(',');
Array.Sort(orderIDs);

foreach (string orderID in orderIDs)
{
    if (orderID.Length != 4)
    {
        Console.WriteLine($"{orderID}\t- Error");
    } else if (orderID.Length == 4)
    {
        Console.WriteLine(orderID);
    }
}