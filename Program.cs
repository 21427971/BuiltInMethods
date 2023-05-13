using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            //find the position for the first 3-star rated song and save it to a variable.
            //Print a message to the console, like “Song number X is rated three stars”.
            int threeRating = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {threeRating + 1} is rated three stars.");
            //the first song that has more than 10 characters in its title.

            string findName = Array.Find(summerStrut, song => song.Length > 10);

            Console.WriteLine($"The first song that has more than 10 characters in the title is {findName}.");
            //Organize the playlist alphabetically. To check that it worked, print the first and last song titles to the console.
            Array.Sort(summerStrut);
            string firstSong = summerStrut[0];
            string lastSong = summerStrut[7];
            Console.WriteLine($"The first song in the playlist is now {firstSong}.");
            Console.WriteLine($"The last song in the playlist is now {lastSong}.");

        }
    }
}

