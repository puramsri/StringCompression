using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    // Compress function
    public static string Compress(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        StringBuilder compressed = new StringBuilder();
        int count = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                count++;
            }
            else
            {
                compressed.Append(count).Append(input[i - 1]);
                count = 1;
            }
        }
        compressed.Append(count).Append(input[^1]);

        return compressed.Length < input.Length ? compressed.ToString() : input;
    }

    // Decompress function
    public static string Decompress(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        StringBuilder decompressed = new StringBuilder();
        MatchCollection matches = Regex.Matches(input, @"(\d+)(\D)");

        foreach (Match match in matches)
        {
            int count = int.Parse(match.Groups[1].Value);
            char character = match.Groups[2].Value[0];

            decompressed.Append(character, count);
        }

        return decompressed.ToString();
    }

    static void Main()
    {
        string inputFile = "input.txt";
        string compressedFile = "compressed.txt";
        string decompressedFile = "decompressed.txt";

        // Read input from file
        if (!File.Exists(inputFile))
        {
            Console.WriteLine($"Error: {inputFile} not found!");
            return;
        }

        string original = File.ReadAllText(inputFile);
        Console.WriteLine($"Original Length: {original.Length}");

        // Compress and save
        string compressed = Compress(original);
        File.WriteAllText(compressedFile, compressed);
        Console.WriteLine($"Compressed saved to {compressedFile}");
        Console.WriteLine($"Compressed Length: {compressed}");

        // Decompress and save
        string decompressed = Decompress(compressed);
        File.WriteAllText(decompressedFile, decompressed);
        Console.WriteLine($"Decompressed saved to {decompressedFile}");

        Console.WriteLine($"Decompression is correct: {original == decompressed}");
    }
}