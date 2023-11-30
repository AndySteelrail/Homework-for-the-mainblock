using System;

public class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Введите текст, преобразуемый в массив через пробел: ");
        string input = Console.ReadLine()??"";
        string[] words = input.Split(' ');

        int charLimit = 3;
        string[] shortWords = Program.Separation(words, charLimit);

        foreach (string word in shortWords)
        {
            Console.WriteLine(word);
        }
        
    }   
    private static string[] Separation(string[] words, int charLimit)
    {
        int countShortWord = 0;
        foreach (string word in words)
        {
            if (word.Length <= charLimit)
            {
                countShortWord += 1;
            }
        }
        
        string[] shortWords = new string [countShortWord];
        int i = 0;
        foreach (string word in words)
        {
            if (word.Length <= charLimit)
            {
                shortWords[i] = word;
                i += 1;
            }
        }

        return shortWords;

        // Можно было бы обойтись одним проходом по массиву,
        // Затем использовать методы, вроде .CopyTo(), .Resize(),
        // Но по сути это был бы тот же доп.проход по массиву
    }
}