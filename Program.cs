using System;
using System.Collections.Generic;
using System.Linq;

  public class Program
  {
    public static void Main()
    {
        Console.WriteLine("Please enter your word.");
        string word = Console.ReadLine();
        string copyWord = word;

         char[] wordArr = word.ToCharArray();
         Array.Reverse(wordArr);

         char[] copyWordArr = copyWord.ToCharArray();
         
         Console.WriteLine(copyWordArr);
         Console.WriteLine(copyWordArr);

        if (wordArr == copyWordArr) {
            Console.WriteLine ("Your word is a Palindrome");
        }
        else {
            Console.WriteLine ("Your word is not a Palindrome");
        }
        
    } 
  }


