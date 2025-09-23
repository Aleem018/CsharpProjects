//  Random dice = new Random();
//  int roll = dice.Next(1, 7);
//  Console.WriteLine(roll);

// Random dice = new Random();
// int roll = dice.Next();

//GPA Calculator
// Details:
// COURSE       UNITS      GRADE        POINTS
// MTH 101      2          A            5
// LAG-CPE 115  2          B            4
// LAG-CPE 117  3          B            4
// LAG-CPE 119  2          A            5
// PHY 101      2          A            5
// PHY 103      2          A            5
// PHY 107      1          A            5
// GET 101      1          A            5
// GET 103      2          A            5
// GST 105      2          A            5

// GPA = Total Points / Total Units
// Total Points = Summation of (Points * Units, i.e Grade Points)
Console.WriteLine("GPA Calculator");
string studentName = "Ahmed Aleem Ikeoluwa";

int A = 5;
int B = 4;

int OneUnit = 1;
int TwoUnits = 2;
int ThreeUnits = 3;

int GP_MTH101 = A * TwoUnits;
int GP_LAG_CPE115 = B * TwoUnits;
int GP_LAG_CPE117 = B * ThreeUnits;
int GP_LAG_CPE119 = A * TwoUnits;
int GP_PHY101 = A * TwoUnits;
int GP_PHY103 = A * TwoUnits;
int GP_PHY107 = A * OneUnit;
int GP_GET101 = A * OneUnit;
int GP_GET103 = A * TwoUnits;
int GP_GST105 = A * TwoUnits; 

int TotalPoints = 0;
TotalPoints += GP_MTH101;
TotalPoints += GP_LAG_CPE115;
TotalPoints += GP_LAG_CPE117;
TotalPoints += GP_LAG_CPE119;
TotalPoints += GP_PHY101;
TotalPoints += GP_PHY103;
TotalPoints += GP_PHY107;
TotalPoints += GP_GET101;
TotalPoints += GP_GET103;
TotalPoints += GP_GST105;

int TotalUnits = (7 * TwoUnits) + (1 * ThreeUnits) + ( 2 * OneUnit);
decimal GPA = (decimal) TotalPoints / TotalUnits;
int firstDigit = (int)GPA % 10;
int secondDigit = (int) (GPA * 10) % 10;
int thirdDigit = (int) (GPA * 100) % 10;

Console.WriteLine("\t\tRESULT");
Console.WriteLine($"NAME: {studentName}");
Console.WriteLine("COURSE\t\tGRADE");
Console.WriteLine("MTH 101\t\tA");
Console.WriteLine("LAG-CPE 115\tB");
Console.WriteLine("LAG-CPE 117\tB");
Console.WriteLine("LAG-CPE 119\tA");
Console.WriteLine("PHY 101\t\tA");
Console.WriteLine("PHY 103\t\tA");
Console.WriteLine("PHY 107\t\tA");
Console.WriteLine("GET 101\t\tA");
Console.WriteLine("GET 103\t\tA");
Console.WriteLine("GST 105\t\tA\n");
Console.WriteLine($"GPA = " + firstDigit + "." + secondDigit + thirdDigit);