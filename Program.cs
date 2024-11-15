using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ваше предложение");
        string input = Console.ReadLine();

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'а', 'е', 'и', 'о', 'у', 'я', 'ю', 'ё', 'э', 'ы' };

        input = input.ToLower();

        int totalVowels = 0;
        for (int i = 0; i < input.Length; i++)
        {
            totalVowels += Array.IndexOf(vowels, input[i]) >= 0 ? 1 : 0;
        }

        Console.WriteLine("гласных букв -  " + totalVowels);

    }
}
