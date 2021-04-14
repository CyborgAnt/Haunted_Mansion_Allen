using System;
using System.Text;
using static System.Console;

namespace FirstFloor
{
    class LeftSide
    {
        //Functions are 'Rooms
        public static void foyer() {
            WriteLine("You step through the front door and enter a modest - for a Mansion - Foyer.");
            WriteLine("There is a closet to your left, with various jackets and coats hanging in there. \nThere are some standing coat racks along the wall, next to the closet. Along the walls of the foyer are small framed pieces of artwork, depicting 'bright' things such as a sunrise, tulips, and meadows. ");
            WriteLine("There is a small table, to the left of the doorway, but there is nothing of interest on it.\nThere is an entryway or short hallway to the left of the closet. \nTo the right of the doorway you entered the Mansion through, there is a set of stairs leading down. \nThere is also a hall that opens up into a much larger room, next to the stairs.");

            WriteLine("\nChoose your next move: \n1. To investigate the Hall next to the closet\n2. To investigate the stairs\n3. To investigate the large room\nAny other key to Quit");
            var foyerChoice = Int32.Parse(ReadLine());

            switch (foyerChoice)
            {
                case 1:
                    den();
                    break;
                case 2:
                    WriteLine("Code Upcoming!");
                    break;
                case 3:
                    RightSide.greatRoom();
                    break;    
                default:
                    WriteLine("Code to come!");
                    break;
            }

        }

        public static void nothing() {
            WriteLine("You found nothing of interest.");
            return;     //not sure if this is the right step
        }
        public static void terrace() {
            //combined with Sitting Room
            //silver charm on swing
            WriteLine("You enter the Sitting Room that is attached to the Master Bedroom.");
            WriteLine("It's a simple extension of the bedroom; there are a couple of comfortable-looking, leather chairs, with a small wooden table between them. There is a piece of paper on the table.\nHowever, the main feature of the room is the terrace that it opens uo to.\nIt has stone paths intersecting in the center. Explosions of colors reside in nearly every available inch of the terrace, with multitudes of smells accompanying the colors.");
            WriteLine("While a beautiful sight, you do not see anything in the terrace that could help you with this case.");

            WriteLine("What would you like to do next? \n1. Examine the paper on the table. \n2. Check the Sitting Room. \n3. Return to the Master Bedroom.");
            var terraceChoice = Int32.Parse(ReadLine());

            switch (terraceChoice) {
                case 1:
                    WriteLine("You examine the piece of paper on the table.\nIt is an article from the local newspaper - one of those 'Community Spotlight' pieces that you find in the paper on the weekends.\nThe article is a recap of an interview with Richard and Roz Allen, about a charity event that they hosted about 6 weeks ago. They raised a lot of money for a couple of in-town organizations... and had a killer party to accompany it, it seems. \nAccording to the articlee, this is not the first time that the Allens have opened their mansion to charity events.\n");
                    WriteLine("\nThey seem like good people.\nYou pocket the paper and head back to the bedroom.");
        
                    WriteLine("Press 'Enter' to continue.");

                    Console.ReadLine();
                    Console.Clear();
                    masteerBR();
                    break;
                case 2:
                    nothing();
                    break;
                case 3:
                    WriteLine("You decide to go back to the Master Bedroom.");
                    masteerBR();
                    break;
                default:
                    WriteLine("Break!");
                    break;
            }
        }
        public static void masterBath() {
            WriteLine("You enter the very spacious Master Bathroom.\n");
            WriteLine("Everything in here feels almost uncomforatbly expensive, although it's not necessarily 'showy'. \nThere is a small hot tub against the far wall. \nLining the back half of the wall to the right is a large, porcelin bathtub. Various shampoos, body washes, conditioners, and fragrances line the wide, outer rim of the tub. \nOn the right wall, closer to the door, is a closet, full of towels, wash cloths, and other odds and ends found in most bathrooms.");
            WriteLine("On the left wall, close to the hot tub, is a normal toilet - maybe the most 'normal'-looking thing in this room. \nNext to the toilet is a fairly large sink, with an oval mirror above it. The mirror, with a face in it, is trimmed in a gold leaf pattern -");

            WriteLine("WAIT.\n\nPress 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("You look back at the mirror! You KNOW you saw a face in it! \nIt was of a woman with long silver hair... but it isn't there, now.");
            WriteLine("More code upcoming!");

        }
        public static void masteerBR() {
            //some kind of encounter
        }
        public static void bedroomA() {
            
        }
        public static void storage() {
            
        }
        public static void den() {
            //Rook, Diary 1
        }
        public static void shortHall() {
            
        }
    }

    class RightSide
    {
        public static void greatRoom() {
            //family picture - normal
        }
        public static void diningRoom() {
            //item/flavor?
        }
        public static void nook() {
            
        }
        public static void kitchen() {
            //writing, sounds
        }
        public static void hall4Rooms() {
            //Butler, closets, storage
            //'Hand' (Closet1), 'Ghost' (Butler)
        }
        public static void pantry() {
            
        }
        public static void laundry() {
            //Dresden or King book
        }
        public static void tIntersect() {
            //leads to porches
        }
        public static void porchTop() {
            
        }
        public static void porchBottom() {
            //flavor?
        }

    }
}

