using System;
namespace metoder
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en mening");
            string a =Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Skriv in en till mening");
           string b = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Den längsta var " + Längst(a,b));
        }
        static string Längst(string text1, string text2)
        {
            if (text1 == text2)
            {
                return text1;
            }
            else if (text1.Length > text2.Length)
            {
                return text1;
            }
            else if (text2.Length > text1.Length)
            {
                return text2;
            }
            else return text1;
        }
    }
}