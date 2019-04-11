using System;
using System.Linq;
namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine(Initials("Ln Sy Pt"));


            Console.ReadLine();
        }

        
        // TODO: Create a method that takes in a full name and return the initials in all capital letters.
        public static string Initials(String name)
        {

            string firstLetters = String.Join(String.Empty, name.Split(new[] { ' ' }).Select(word => word.First()));

          
            return firstLetters.ToUpper();

            
            





        }

    }

}
