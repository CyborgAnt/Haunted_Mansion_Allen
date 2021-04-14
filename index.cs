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
            WriteLine("Code upcoming soon!");
            FirstFloor.LeftSide.foyer();
        }
    }
}


