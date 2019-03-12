using System;
using System.Linq;
namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine(Initials("Lauren Faye Stephens"));


            Console.ReadLine();
        }

        
        // TODO: Create a method that takes in a full name and return the initials in all capital letters.
        public static string Initials(String name)
        {
            
            string firstLetters = String.Join(String.Empty, text.Split(new[] { ' ' }).Select(word => word.First()))

            foreach (var name in name.split(' '))
            {
                firstLetters += part.substring(0, 1);
            }
            firstLetters.ToUpper();
            return firstLetters;

            
            string firstLetters =
                String.Join(String.Empty, text.Split(new[] { ' ' }).Select(word => word.First()))





        }

    }

}
