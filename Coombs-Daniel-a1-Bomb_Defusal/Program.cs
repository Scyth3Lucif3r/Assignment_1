﻿// See https://aka.ms/new-console-template for more information

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
                "you manage to solve the puzzle. You hear a click from inside the device, but there is no explosion, so you can assume \n" +
                "you did something right.");
            Console.WriteLine("You check the timer again.\n\n 15:25... 15:24... 15:23... What will you do now? \n1. Check the wires. \n 2. Press the big red button.");
            int choice_4 = int.Parse(Console.ReadLine());

            if (choice_4 == 2)
            { //Big red button
                Console.WriteLine("BOOM \n\n GAME OVER.");
            }
            else if (choice_4 == 1)
            {//Wires
                Console.WriteLine("You can assume that the pliers on the table are meant to cut the wires, but which one?");
                Console.WriteLine("1. Red \n2.Green \n 3.Blue \n 4.Copper");
                int choice_5 = int.Parse(Console.ReadLine());

                if (choice_5 == 1 || choice_5 == 2 || choice_5 == 3)
                {
                    Console.WriteLine("snip. BOOM \n\n GAME OVER.");
                }
                else if (choice_5 == 4)
                {
                    Console.WriteLine("The box clicks open. A feeling of dread pervades your entire being as you see the inside of the\n" +
                    "\"bomb\" is actually hollow, the only contents inside being your spouse's ring. \n\n THE END.");
                }

            }
        }
        else if (choice_3 == 1)
        { //Wires
            Console.WriteLine("You can assume that the pliers on the table are meant to cut the wires, but which one?");
            Console.WriteLine("1. Red \n2.Green \n 3.Blue \n 4.Copper");
            int choice_5 = int.Parse(Console.ReadLine());

            if (choice_5 == 1 || choice_5 == 2 || choice_5 == 3)
            {
                Console.WriteLine("snip. BOOM \n\n GAME OVER.");
            }
            else if (choice_5 == 4)
            {
                Console.WriteLine("snip. \n...\nNothing happens, so you must have done something right. The timer now reads\n" +
                    "20:01... 20:00... 19:59...\nWhat will you do now? \n1. Check the box puzzle \n2.Push the Big Red button");
                int choice_8 = int.Parse(Console.ReadLine());

                if (choice_8 == 2)
                {
                    //Big red button
                    Console.WriteLine("BOOM \n\n GAME OVER.");
                }
                else if (choice_8 == 1)
                {
                    Console.WriteLine("You notice the notches on each of the squares range from 1 - 8. After some time working on the puzzle,\n" +
                                "you manage to solve the puzzle. You hear a click from inside the device, and the top pops open.");
                    Console.WriteLine("The box clicks open. A feeling of dread pervades your entire being as you see the inside of the\n" +
                        "\"bomb\" is actually hollow, the only contents inside being your spouse's ring. \n\n THE END.");
                }
            }
        }

    }

}

if (choice_1 == 1)
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
            "you manage to solve the puzzle. You hear a click from inside the device, but there is no explosion, so you can assume \n" +
            "you did something right.");
        Console.WriteLine("You check the timer again.\n\n 15:25... 15:24... 15:23... What will you do now? \n1. Check the wires. \n 2. Press the big red button.");
        int choice_4 = int.Parse(Console.ReadLine());

        if (choice_4 == 2)
        { //Big red button
            Console.WriteLine("BOOM \n\n GAME OVER.");
        }
        else if (choice_4 == 1)
        {//Wires
            Console.WriteLine("You can assume that the pliers on the table are meant to cut the wires, but which one?");
            Console.WriteLine("1. Red \n2.Green \n 3.Blue \n 4.Copper");
            int choice_5 = int.Parse(Console.ReadLine());

            if (choice_5 == 1 || choice_5 == 2 || choice_5 == 3)
            { //Wrong Wire
                Console.WriteLine("snip. BOOM. \n\n GAME OVER.");
            }
            else if (choice_5 == 4)
            { //Right Wire
                Console.WriteLine("The box clicks open. A feeling of dread pervades your entire being as you see the inside of the\n" +
                    "\"bomb\" is actually hollow, the only contents inside being your spouse's ring. \n\n THE END.");
            }
        }
    }
    else if (choice_3 == 1)
    { //Wires
        Console.WriteLine("You can assume that the pliers on the table are meant to cut the wires, but which one?");
        Console.WriteLine("1. Red \n2.Green \n 3.Blue \n 4.Copper");
        int choice_5 = int.Parse(Console.ReadLine());

        if (choice_5 == 1 || choice_5 == 2 || choice_5 == 3)
        { //Wrong Wire
            Console.WriteLine("snip. BOOM \n\n GAME OVER.");
        }
        else if (choice_5 == 4)
        { //Right Wire
            Console.WriteLine("snip. \n...\nNothing happens, so you must have done something right. The timer now reads\n" +
                "20:01... 20:00... 19:59...\nWhat will you do now?\n1.The squares puzzle.\n2.The Big Red Button.");
            int choice_7 = int.Parse(Console.ReadLine());

            if (choice_7 == 2)
            { //Big red button
                Console.WriteLine("BOOM \n\n GAME OVER.");
            }
            else
            {
                Console.WriteLine("You notice the notches on each of the squares range from 1 - 8. After some time working on the puzzle,\n" +
                                "you manage to solve the puzzle. You hear a click from inside the device, and the top pops open.");
                Console.WriteLine("The box clicks open. A feeling of dread pervades your entire being as you see the inside of the\n" +
                    "\"bomb\" is actually hollow, the only contents inside being your spouse's ring. \n\n THE END.");
            }
        }

    }
}
