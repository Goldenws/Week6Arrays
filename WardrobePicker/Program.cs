using System;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobe = { "hat", "hoodie", "jeans", "shirt" };
            string[] colors = { "red", "blue", "white", "green","Black" };
            string[] patterns = { "flowery", "stripped", "polka dot", "circles", "chekcered" };

            /*The program asks if the user needs help with picking an outfit
             If the user answers no,the console displays "farewell"
            If th users confirms, the program displays a random combination of
            pattern, color and clothing item
            "Toady you should wear"*/

            Random rnd = new Random();

            Console.WriteLine("Would youlike some fashion advice");
            string userInput = Console.ReadLine();

            if(userInput == "no")
            {
                Console.WriteLine("FareWell");
            }
            else
            {
                Console.WriteLine($"Today you should wear " +
                    $"{colors[rnd.Next(0, colors.Length)]}" +
                    $"{patterns[rnd.Next(0, patterns.Length)]}" +
                    $"{wardrobe[rnd.Next(0, wardrobe.Length)]}");

            }
            
            
            
        }
    }
}
