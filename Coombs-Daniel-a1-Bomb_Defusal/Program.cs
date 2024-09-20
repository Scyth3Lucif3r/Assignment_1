// See https://aka.ms/new-console-template for more information
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
{
    Console.WriteLine("You cannot handle the stress of the situation and curl into a sobbing ball on the floor. By the time you've cried\n" +
        "yourself out, the timer is almost done.\n \n 3... 2... 1... BOOM. \n\n GAME OVER.");
}
