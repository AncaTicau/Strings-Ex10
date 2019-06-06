using System;

namespace Strings_Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            StartCharacterA("Ana are mere");
        }

        //Write a method to check whether a string starts with specified characters

        public static string StartCharacterA(string input)
        {
            if (input[0] == 'A')
            {
                Console.WriteLine("Yes, the string starts with \"a\"");
            }
            else
            {
                Console.WriteLine("No, the string doesn't start with \"a\"");
            }
            return input;
        }
    }
}