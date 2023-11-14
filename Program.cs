using System;
using System.Text.RegularExpressions;

class Program
//{
//    static void Main()
//    {
//        // Read input text from the console

//        string inputText = Console.ReadLine();

//        // Call the function to match and print full names
//        MatchFullNames(inputText);
//    }

//    static void MatchFullNames(string text)
//    {
//        // Use regular expression to find valid full names
//        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
//        MatchCollection matches = Regex.Matches(text, pattern);

//        // Print the matched full names
//        foreach (Match match in matches)
//        {
//            Console.Write(match.Value + " ");
//        }
//    }
//}
{
    static void Main()
    {
        // Read input text from the console

        string inputText = Console.ReadLine();

        // Call the function to match and print valid dates
        MatchDates(inputText);
    }

    static void MatchDates(string text)
    {
        // Use regular expression to find valid dates
        string pattern = @"(?<Day>\d{2})(?<Separator>[./-])(?<Month>[A-Za-z]{3})(\k<Separator>)(?<Year>\d{4})\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        // Print the matched dates
        foreach (Match match in matches)
        {
            Console.WriteLine($"Day: {match.Groups["Day"].Value}, Month: {match.Groups["Month"].Value}, Year: {match.Groups["Year"].Value}");
        }
    }
}
