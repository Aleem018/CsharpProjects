Random random = new Random();
int damage;

int heroHealth = 10;
int monsterHealth = 10;
int turn = 0;
do
{
    damage = random.Next(1, 11);
    turn += 1;
    if (turn % 2 == 1)
    {
        monsterHealth -= damage;

        Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health");
    } else if (turn % 2 == 0)
    {
        heroHealth -= damage;

        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health");
    }

     
}   while ( heroHealth > 0 && monsterHealth > 0);

if (heroHealth <= 0)
    {
        Console.WriteLine("Monster wins!");
    } else if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
    }

    /*
    Similar code
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

    */