using System;

public static class StringExtensions {
    public static int CountVowels(this string input) {
        int count = 0;
        string vowels = "aeiouAEIOU";
        foreach (char c in input) {
            if (vowels.IndexOf(c) != -1) {
                count++;
            }
        }
        return count;
    }
}

class Program {
    static void Main(string[] args) {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int vowelCount = input.CountVowels();
        Console.WriteLine("Number of vowels: {0}", vowelCount);
    }
}