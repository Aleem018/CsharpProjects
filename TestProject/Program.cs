for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

string[] names = { "Alex", "Eddie", "David", "Aleem" };
for (int j = names.Length - 1; j >= 0; j--)
{
    Console.WriteLine(names[j]);
}
for (int k = 0; k < names.Length; k++)
{
    Console.WriteLine(names[k]);
}

for (int l = 0; l < names.Length; l++)
{
    if (names[l] == "David") names[l] = "Sammy";
}

foreach (var name in names) Console.WriteLine(name);