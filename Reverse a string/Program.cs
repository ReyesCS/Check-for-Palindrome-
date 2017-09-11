using System;

namespace Reverse_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            // User can input any word 
            string word = "Racecar".ToLower(); ;
            string revWord = "";

            //Will iterate through the values in the array from back to front 
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (i >= 0)
                {
            //Will add each character to a string in reverse
                    revWord += word[i];
                }
            }
            //Compares the original string to the new reversed string to see if they match
            if (word == revWord)
                {

            //If the words match the console will display the following     
                    Console.WriteLine("Is palindrome");
                    Console.ReadLine();
                }
                else
                {
            //If not the console will display the following 
                    Console.WriteLine("Is not Palindrome");
                    Console.ReadLine();
                }

            }
        /*
        string word = "Tacocat".ToLower(); ;
            string revWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (i >= 0)
                {
                    revWord += word[i];
                }
                    Console.WriteLine(revWord);
                    Console.ReadLine();

        */
        }
    }