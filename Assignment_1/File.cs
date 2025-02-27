using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "output.txt";

        if (File.Exists(filePath))
        {
            Console.WriteLine("Current contents:");
            Console.WriteLine(File.ReadAllText(filePath));
        }
        else
        {
            Console.WriteLine("File doesn't exist yet. Creating new file.");
        }

        Console.Write("Enter text to add: ");                              // Append Text
        File.AppendAllText(filePath, Console.ReadLine() + "\n");

        Console.WriteLine("Updated contents:");                            // Show updated content
        Console.WriteLine(File.ReadAllText(filePath));
    }
}