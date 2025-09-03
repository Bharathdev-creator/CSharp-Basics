//Jump statements are used to change the flow of control in a program
// — like skipping code, repeating, or exiting early.
//Break,Continue,GOTO,Return,throw...

//Break stops the current iteration..

//Continue skips the current one and switch to next...

//Return exit the method and optionally returns a value...i will tell u when i m working on functions..

//GOTO Jumps to a labeled statement...

//Throw Used to throw an exception...

class BCJR
{
    public static void Jumps()
    {
        string[] friends = { "a", "b", "c", "d", "e" };
        for (int i = 0; i < friends.Length; i++)
        {
            Console.WriteLine($"hey, {friends[i]} welcome to the party");
            if (friends[i] == "d")
            {
                Console.WriteLine("You people are enough");
                break;
            }
        }
    }

    public static void skippingCurrentone()
    {
        string[] fri = { "a", "b", "c", "d", "e" };
        for (int i = 0; i < fri.Length; i++)
        {
            if (fri[i] == "d")
            {
                Console.WriteLine("skipping d too many people");
                continue;
            }
            Console.WriteLine($"hey, {fri[i]} welcome to the party");
        }
    }
}

/*What are Exceptions?
Exceptions are errors or unexpected problems that happen while your program is running.

Instead of crashing your program immediately, C# lets you catch and handle these errors gracefully.

This way, your program can respond (like showing a friendly message) instead of just stopping.*/