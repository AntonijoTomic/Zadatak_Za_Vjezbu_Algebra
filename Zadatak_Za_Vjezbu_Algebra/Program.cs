using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;


namespace ZadatakZaVjezbuAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Type something and check if it is a palindrom");
            string str = "";
            do
            {
                str = Console.ReadLine();
            }
            while (str.Length == 0);

            Console.WriteLine("Is the string a palindrome? " + IsPalindrome(str));
            

            

            Console.ReadKey();
        }

        static bool IsPalindrome(string str)
        {
            if (str.Length <= 1)  // PROVJERA da li smo do sredine (sve s lijeve i desne strane je isto)
                return true;
            else if (str[0] != str[str.Length-1])  // Ako prvi i posljednji znak nisu isti
                return false;
            else  
                return IsPalindrome(str.Substring(str.Length - 1,1)); //micemo zadnje i prvo slovo i pozivamo funkciju s novim stringom
        }
    }
}
