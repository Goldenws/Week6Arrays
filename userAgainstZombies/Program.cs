using System;

namespace userAgainstZombies
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks the user to enter the names of five items from the user's bag.
             The program displays arandom pick from the user's weapon collection 
            to fight of zombies with
            "In case of zombie apocalypse you will have to fight zombies with{random item in my weapon collection}"*/

            string[] userCollection = new string[5];
            int i = 0;
            while(i < userCollection.Length)
            {
                Console.WriteLine("What's  there in your collection?");
                userCollection[i] = Console.ReadLine();
                i++;
            }
            Random rnd = new Random();
            Console.WriteLine($"In case of zombie apocalypse you will have to" +
                $"fight zombies off with a{userCollection[rnd.Next(0, userCollection.Length)]}");
        }
    }
}
