string permission = "Manager";
int level = 15;

//Console.WriteLine(permission.Contains("Admin") || level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user."); 

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
} else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
} else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
} else if (permission.Contains("Manager") && level < 20)
{
    Console.WriteLine("You do not have sufficient priviledges.");
} else
{
    Console.WriteLine("You do not have sufficient priviledges.");
}

// This also works
if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    } else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
} else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    } else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
} else
{
    Console.WriteLine("You do not have sufficient privileges.");
}