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
                    masterBR();
                    break;
                case 2:
                    nothing();
                    break;
                case 3:
                    WriteLine("You decide to go back to the Master Bedroom.");
                    masterBR();
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
        public static void masterBR() {
            //some kind of encounter
        }
        public static void bedroomA() {
            WriteLine("You enter a bedroom.\nThis appears to be a Guest bedroom. There is a Queen-sized bed, a nightstand, and a set of chairs and table.\nThe closet door, on the far wall, is cracked open but you can't make out what's in it from where you stand. There is also a small Entertainment Center against the wall, with a medium-sized TV on top of it, along with a DVD player on a shelf under the TV.\n");
            WriteLine("\nPress 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("A non-descript bathroom is attached to the bedroom. You look in but see nothing of note or interest.\n\nWhat would you like to do next?");
            WriteLine("1. Check the closet\n2. Check the Entertainment Center\n3. Leave the bedroom");

            var bedA = Int32.Parse(ReadLine());

            switch (bedA) {
                case 1:
                    nothing();
                    break;
                case 2:
                    WriteLine("You examine the Entertainment Center but find nothing of interest.\nHowever, on a 'hunch', you decide to turn on the TV and DVD player. Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear(); 

                    WriteLine("The DVD player cycles up and starts playing. It is a documentary about European mythology.\nYou watch for a few minutes; the program talks about such topics as the Formorians, Stonehenge, and Baba Yaga.\nThe last section you watch, before stopping the DVD, is about Irish folklore, specifically the Banshee. \nInterestng info but it doesn't seem to be related to this case.");
                    WriteLine("You turn off the TV and DVD player, and head back to the Foyer. Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear(); 
                    foyer();
                    break;
                case 3:
                    WriteLine("You leave the bedroom. Where do you go next?");
                    WriteLine("1. To the Master Bedroom\n2. Back through the short hallway, to the Foyer\n3. To the Den");

                    var bedB = Int32.Parse(ReadLine());

                    switch (bedB) {
                        case 1:
                            masterBR();
                            break;
                        case 2:
                            foyer();
                            break;
                        case 3:
                            den();
                            break;
                        default:
                            WriteLine("You exit the game");
                            break;

                    }
                    break;
            }
        }
        public static void storage() {
            WriteLine("You open the door and see... a storage area?");
            WriteLine("Odd that a storage area is on the other side of a bathroom but you didn't design the house.\nNevertheless, this is a large storage room, with stacks of boxes, crates, and chests. You notice that the crates mainly contain magazines, books, and manila folders.\nMost of the chests are closed, although you can't tell if they are locked; the chests are mainly in the NW corner, next to the door. Press 'Enter' to continue.");

            Console.ReadLine();
            Console.Clear();

            WriteLine("Most of the stacked boxes are closed or sealed; however a few lone boxes are open.\nWhat would you like to do?");

            WriteLine("Check some of the open boxes: '1'\nCheck the chests: '2'\Check the rest of the room: '3'\nLeave: '4'");

            var storageChoice = Int32.Parse(ReadLine());

            switch(storageChoice) {
                case 1:
                    WriteLine("Code to come!");
                    break;
                case 3:
                    WriteLine("You examine the room more closely.\nThere are no discernable features that you see... except for a SLIGHTLY lighter patch on the far wall. You push on the patch and the section moves in.\You found a Secret Door! Press 'Enter' to continue.");
                    //secret door to 2F
                    Console.ReadLine();
                    Console.Clear();
                    WriteLine("More code to come!");
                    break;
                case 2:
                    WriteLine("You check the lids of some of the chests but they are all locked. You need to find a key or keys.");
                    storage();
                    break;
                case 4:
                    WriteLine("You don't notice anything important, so you return to the Master Bathroom.\nPress 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear;
                    masterBath();
                    break;
                default:
                    break;

            }
        }
        public static void den() {
            //Rook, Diary 1
            WriteLine("Code upcoming!");
        }
        public static void shortHall() {
            
        }
    }

    class RightSide
    {
        public static void greatRoom() {
            //family picture - normal
            WriteLine("You walk a short distance from the Foyer and enter the largest room you've ever seen in a residental building.\nPress Enter to continue.");
            Console.ReadLine();

            WriteLine("You enter the room from the SW corner.\nThe Grand Hall is a 2-story room, realistically an extension of the Foyer.\nThere is a walkway that encircles the area on the 2nd floor, framed by a beautiful, cherry wood railing. On the first floor, there are comfortale-looking benches on the wall to your left (the west wall).\nOn and against the North wall, there are some pieces of artwork, including a couple of statues. Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("As you continue to look around, you see that there are many areas that lead into the Grand Hall.\nAlong the South wall, there is a large opening that leads into what appears to be a Dining Hall or Dining Room; there is a Hallway that runs between the Dining area and the Grand Hall\nThere are openings on the East Wall that lead to a room to the North and the South\nThere are the stairs that you noticed when you came in.\nThere appears to be an indoor Garden on the other side of the North wall. Press 'Enter' to continue.");
            Console.ReadLine();

            WriteLine("\nChoose where you would like to go:");
            WriteLine("1 - Back to the Foyer\n2 - To the Dining Area\n3 - To the Hall between the Dining Area and the Grand Hall\n4 - East wall room North\n5 - East wall room South\n6 - To the Garden\nAny other key - Quit");
            var grandChoice = Int32.Parse(ReadLine());

            switch(grandChoice) {
                case 1:
                    foyer();
                    break;
                case 2:
                    diningRoom();
                    break;
                case 3:
                    hall4Rooms();
                    break;
                case 4:
                    nook();
                    break;
                case 5:
                    kitchen();
                    break;
                case 6:
                    garden();
                    break;
                default:
                    break;
            }
        }
        public static void diningRoom() {
            //item/flavor?
            WriteLine("Dining code upcoming!");
        }
        public static void nook() {
            //encounter
            WriteLine("You head to the East wall of the Grand Hall, and choose to investigate the room to the North. Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("This is mainly just an empty space, a nook, as opposed to an actual room. There is a problem: \n\nThe fogure standing 5 feet in front of you. Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            WriteLine("The figure is of a tall man, slight of build, maybe in his 30's. \nHe is also obviously a ghost!\nWhat do you do?");
            WriteLine("1 - Run!\n2 - Try to communicate\n3 - Fight!");

            var ghostNook = Int32.Parse(ReadLine());
            switch(ghostNook) {
                case 1:
                    //run
                    WriteLine("Your internal senses tell you to 'run', so that is what you do!\nYou run back to the Grand Hall and turn around...\nThe figure did not follow. Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    greatRoom();
                    break;
                case 2:
                    //talk?
                    WriteLine("Fighting your instincts, you decide to try to talk to the figure... while backing up a few feet. \n'Who are you?', you ask. The figure looks at you - no malice in it's gaze but not exactly inviting, either.");
                    WriteLine("You try again: 'Do you know what happened to the Allen family?'\nAt this, the ghost nods slowly. \nPress 'Enter' to continue.");

                    Console.ReadLine();

                    WriteLine("The ghost then points to the east, to it's left, and fades away.\nEqual parts spooked, intrigued, and confused, you head towards the eastern end of the mansion.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    WriteLine("You walk around the corner of the nook and see an opening into a kitchen.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    kitchen();
                    break;
                case 3:
                    //fight
                    WriteLine("Ghost Fight code upcoming!");
                    break;
                default:
                    break;
            }

        }
        public static void garden() {
            
        }
        public static void kitchen() {
            //writing, sounds
            WriteLine("You enter the Kitchen.\nThis kitchen is enormous! There are areas that branch off from here: \nto the north, there is a small room, almost like a nook between rooms\nto the west is an opening to the Grand Hall\nto the south, there are 2 doors that lead to a hallway\nto the southwest, there is a dining area.");
            WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            WriteLine("Inside the kitchen:\nYou notice a large island in the center of the room. On the island counter is a newspaper section.\nThere are cabinets lining the south and east walls. There are also your standard kitchen appliances - stove, refridgerator, sink, etc. - but of a higher quality that isn't found in most homes. \nThere is a pantry to the southeast.");
            WriteLine("What would you like to do?");

            WriteLine("\n1. Check the room in general\n2. Check the newspaper\n3. Check the cabinets\n4. Check the stove\n5. Check the Pantry\n6. Leave the kitchen");

            var kitchenChoice = Int32.Parse(ReadLine());
            switch(kitchenChoice){
                case 1:
                    //room; diary in wall
                    WriteLine("Room code!");
                    break;
                case 2:
                    //newspaper; disappeaances
                    WriteLine("Paper code!");
                    break;
                case 3:
                    nothing();
                    break;
                case 4:
                    nothing();
                    break;
                case 5:
                    //pantry
                    WriteLine("Pantry code!");
                    break;
                case 6:
                    WriteLine("Where do you want to go?");
                    WriteLine("a. to the Nook \nb. back to the Grand Hall \nc. to the hallway to the south \nd. to the dining area");

                    var kitRoomChoice = Int32.Parse(ReadLine());
                    switch(kitRoomChoice) {
                        case 'a':
                            nook();
                            break;
                        case 'b':
                            greatRoom();
                            break;
                        case 'c':
                            4Rooms();
                            break;
                        case 'd':
                            diningRoom();
                            break;
                        default:
                            foyer();
                            break;
                    }
                default:
                    WriteLine("You end the game.");
                    break;
            }

        }
        public static void hall4Rooms() {
            //Butler, closets, storage
            //'Hand' (Closet1), 'Ghost' (Butler)
            WriteLine("4Rooms code upcoming!");
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

