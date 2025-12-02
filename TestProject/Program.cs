string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');
string[] reversedArray = new string[words.Length];

for (int i = 0; i < words.Length; i++)
{
    char[] charArray = words[i].ToCharArray();
    Array.Reverse(charArray);
    string result = new string(charArray);
    reversedArray[i] = result;
}

string final = String.Join(" ", reversedArray);
Console.WriteLine(final);


