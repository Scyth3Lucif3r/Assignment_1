// See https://aka.ms/new-console-template for more information

//preamble
Console.WriteLine("You wake up bound to a hard metal chair. \nThe room is too dark for you to see anything, until a blinding light " +
    "illuminates a table in front of you. After a few \nseconds, your eyes adjust and you see a strange device on the table, " +
    "surrounded by tools like screwdrivers, pliers, and,\n oddly enough, a power drill. You are jolted to attention by the loud noise" +
    "made by a PA system turning on. A distorted voice speaks through it.\n");
Console.WriteLine("\"Welcome to my game, contestant. Before you is an explosive device, rigged to go off exactly 30 minutes after this buzzer sounds.\"\n" +
    "You hear a generic buzzer noise. Once it ends, the voice continues, \"If you succeed in disarming the explosive before it detonates,\n" +
    "you may leave free.\n\n Good Luck.");
Console.WriteLine("\nThe buzzer sounds again, and the cuffs restraining you to this chair are released. A large red timer appears\n" +
    "on the oppsite wall counting down from 30 minutes. What will you do?");
Console.WriteLine("1. Examine the device. \n2. Look for an escape. \n3. Curl into a ball and cry.");
int choice_1 = int.Parse(Console.ReadLine());

if (choice_1 == 3)
{//widdle baby
    Console.WriteLine("You cannot handle the stress of the situation and curl into a sobbing ball on the floor. By the time you've cried\n" +
        "yourself out, the timer is almost done.\n \n 3... 2... 1... BOOM. \n\n GAME OVER.");
}
else if (choice_1 == 2)
{ //The Escapist
    Console.WriteLine("You frantically seach the room looking for an escape. You feel out what must be the outline of the door, but\n" +
        "you cannot manage to pry it open. Looking back at the timer, you see just how much time you've lost.\n\n 25:05... 25:04... 25:03...\n" +
        "What will you do now?");
    Console.WriteLine("1. Examine the device. \n2. Curl into a ball and cry.");
    int choice_2 = int.Parse(Console.ReadLine());

    if (choice_2 == 2)
    { //widdle baby
        Console.WriteLine("You cannot handle the stress of the situation and curl into a sobbing ball on the floor. By the time you've cried\n" +
        "yourself out, the timer is almost done.\n \n 3... 2... 1... BOOM. \n\n GAME OVER.");
    }
    else if (choice_2 == 1)
    { //Device Inspection 
        Console.WriteLine("You look over the device and notice multiple details about it. \n1. Four wires. One red, one green, and one blue and one Copper." +
            "\n2. A puzzle made up of a 3x3 of squares with notches, except the bottom left square is missing. \n3. A big red button ");
        int choice_3 = int.Parse(Console.ReadLine());

        if (choice_3 == 3)
        { //Big red button
            Console.WriteLine("BOOM \n\n GAME OVER.");
        }
        else if (choice_3 == 2)
        { //Sliders
            Console.WriteLine("You notice the notches on each of the squares range from 1 - 8. After some time working on the puzzle,\n" +
                "you manage to sole the puzzle. You hear a click from inside the device, but there is no explosion, so you can assume \n" +
                "you did something right.");

        } else if (choice_3 == 1)
        { //Wires
            Console.WriteLine("You can assume that ");
        }

    }
    
}
else if (choice_1 == 1)
{ // Device inspection
    Console.WriteLine("You look over the device and notice multiple details about it. \n1. Four wires. One red, one green, and one blue and one Copper." +
            "\n2. A puzzle made up of a 3x3 of squares with notches, except the bottom left square is missing. \n3. A big red button ");
    int choice_3 = int.Parse(Console.ReadLine());

    if (choice_3 == 3)
    { //Big red button
        Console.WriteLine("BOOM \n\n GAME OVER.");
    }
    else if (choice_3 == 2)
    { //Sliders
        Console.WriteLine("You notice the notches on each of the squares range from 1 - 8. After some time working on the puzzle,\n" +
            "you manage to sole the puzzle. You hear a click from inside the device, but there is no explosion, so you can assume \n" +
            "you did something right.");

    }
}