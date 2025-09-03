//loop
//performs same task again and again until certain condition met...
//To write the code once and reuse it multiple times...


//in for loop u know number of iterations u can keep a count...
class Loops
{
    public static void iteration1()
    {
        string[] friends = { "aman", "boby", "cathy", "daniel", "lucifer" };
        for (int i = 0; i < friends.Length; i++)
        {
            Console.WriteLine($"Hey,{i},{friends[i]},Welcome to the party");
            Console.WriteLine($"Total number of friends invited {i}");
        }

        string[] friend = { "Rahul", "Sneha", "Arjun", "Meera", "Vikram" };
        foreach (string j in friend)
        {
            Console.WriteLine($"Hey {j}, you're invited to my party!");
        }
    }

    //While loop runs until certain condition is true and keeps repeating until that condition becomes false 
    public static void Waiting()
    {
        bool bus_arrived = false;
        int minutes_waited = 0;
        while (!bus_arrived)
        {
            Console.WriteLine("just keep waiting till bus came");
            minutes_waited++;
            if (minutes_waited == 10)
            {
                bus_arrived = true;
            }
        }
        Console.WriteLine($"catched the bus after {minutes_waited} mins");
    }

    public static void Party()
    {
        string[] people = { "rose", "dose", "danny", "tomy" };
        int i = 0;
        do
        {
            Console.WriteLine($"Hey {people[i]} welcome to the party");
            i++;
        } while (i < people.Length);
    }
}

