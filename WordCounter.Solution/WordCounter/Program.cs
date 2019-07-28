using System;


namespace WordCount
{
    public class Program
    {
        public static void Main()
        {
          Counter userInput = new Counter();
          Console.WriteLine("Hello User this is a word counter!");
           Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
          Console.WriteLine("Enter your sentence.");
          string userSentence = Console.ReadLine();
          Console.WriteLine("Enter a word from your sentence to see how many times it is used.");
          string userWord = Console.ReadLine();
          if (userWord.Contains(" "))
          {
            userWord = Console.ReadLine();
          }
          int CountWords = userInput.wordCount(userSentence,userWord);
          Console.WriteLine(userWord + " appears in (" + userSentence + ") " + CountWords + " times.");


        }
    }
}