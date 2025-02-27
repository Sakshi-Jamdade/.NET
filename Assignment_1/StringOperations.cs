using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        Console.WriteLine("Uppercase: " + text.ToUpper());              // String Operations
        Console.WriteLine("Lowercase: " + text.ToLower());
        Console.WriteLine("Trimmed: '" + text.Trim() + "'");
        Console.WriteLine("Replaced 'l' with '*': " + text.Replace('l', '*'));

        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'l')
            {
                count++;
            }
        }
        Console.WriteLine("Number of 'l' in the string: " + count);       // Count l In String

        string joined = string.Join("*", text);                           // Join characters with *
        Console.WriteLine("Formatted output: " + joined);
    }
}