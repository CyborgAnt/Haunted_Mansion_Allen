/* Anthony Bonner
    4/12/2021 */

using System;
using System.Text;
using static System.Console;

class mansion{ 
    static void Main(string[] args) {
        WriteLine("If you are ready to begin, press '1'; to quit, press any other key: ");
        var begin = Int32.Parse(ReadLine());
        if(begin == 1)
            intro();
        else
            System.Environment.Exit(0);

        static void intro() {
            // intro flavor text
            // make italics
            WriteLine("You are a Private Investigator, hired by one of the city's elite, to find out the whereabouts of Richard and Roz Allen.\n\nBut this is no ordinary case.\n\nAnd you aren't an ordinary P.I.");
            WriteLine("Press 'Enter' to continue.");

            Console.ReadLine();
            Console.Clear();

            WriteLine("Your expertise is on the 'strange' and 'occult'. \nFrom what your employers ahve told you, there has been plenty of 'strange' happening at the Allen Mansion, since the Allen's disappearances: \nmovements in the windows, lights on the grounds, and 'odd' sounds, especially at night.\nNot necessarily 'occult' but definitely something worth looking into. Press 'Enter' to continue.");

            Console.ReadLine();
            Console.Clear();

            WriteLine("You prepare yourself for the case: You put on a bullet-proof vest\nYou strap on your Gun\nYou put on your backpack, with Notepad, extra Bullets for your Gun, and other odds and ends inside\nYou put on your lucky Silver pendant\n");
            WriteLine("\nYou get in your car and drive to the Allen Mansion. It is a beautiful, 2-story building, light blue in color, situated on a large stretch of well-kempt land.\n\nYou park, get out, and walk up to the front porch. The front door is unlocked.\nYou turn the door handle and enter the Mansion... \n\nPress 'Enter' to continue.");

             Console.ReadLine();
            Console.Clear();

            FirstFloor.LeftSide.foyer();
        }
    }
}


