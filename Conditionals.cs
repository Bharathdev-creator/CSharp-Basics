using System;

class Conditionals
{
    public static void Statement1()
    {
        Console.WriteLine("Enter a number...");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            Console.WriteLine("its positive");
        }
    }

    public static void Statement2()
    {
        Console.WriteLine("Enter your age...");
        string age = Console.ReadLine();
        int age1 = 21;
        //Converting string to integer:
        if ((int.TryParse(age, out int num)))
        {
            if (num == age1)
            {
                Console.WriteLine($"you have entered correct {age}");
            }
            else
            {
                Console.WriteLine($"You have entered incorect {age}");
            }
        }
        else
        {
            Console.WriteLine($"You have  entered invalid {age}");
        }
    }

    public static void Statement3()
    {
        Console.WriteLine("Enter a number");
        string num = Console.ReadLine();
        if (int.TryParse(num, out int number))
        {
            if (number > 0)
            {
                Console.WriteLine($"Number is {number}");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine($"number is 0");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }

    //Switch statement is an alternative for long if else-if ladders,
    //it is going to use one expression nd checks multiple cases if any 
    //case satisfied it is executed break statement stops execution come out
    //it will never move to next line with out break it will keep on executing the code
    //bcz of switch statement code looks readable , not messy bcz of cases u can easily
    // update,debug any errors u no need to use same variables repeatedly.....

    public static void switches()
    {
        string drink = "Cappuccino";

        switch (drink)
        {
            case "Espresso":
                Console.WriteLine("Prepare a strong Espresso shot.");
                break;
            case "Latte":
                Console.WriteLine("Prepare a smooth Latte with steamed milk.");
                break;
            case "Cappuccino":
                Console.WriteLine("Prepare a Cappuccino with foam on top.");
                break;
            default:
                Console.WriteLine("sorry sir not available at this moment");
                break;
        }
    }
    // A nested switch is a switch statement placed inside another switch statement.
    // It is used when a decision depends on multiple conditions, allowing you to perform different actions based on a combination of values.

    public static void nestedswitches()
    {
        string course = "Engineering";
        string gender = "Female";

        switch (course)
        {
            case "Engineering":
                Console.WriteLine("You selected Engineering.");

                switch (gender)
                {
                    case "Male":
                        Console.WriteLine("Assign to Mechanical Engineering block.");
                        break;
                    case "Female":
                        Console.WriteLine("Assign to Computer Engineering block.");
                        break;
                    default:
                        Console.WriteLine("Invalid gender for Engineering.");
                        break;
                }
                break;

            case "Science":
                Console.WriteLine("You selected Science.");

                switch (gender)
                {
                    case "Male":
                        Console.WriteLine("Assign to Physics Department.");
                        break;
                    case "Female":
                        Console.WriteLine("Assign to Biology Department.");
                        break;
                    default:
                        Console.WriteLine("Invalid gender for Science.");
                        break;
                }
                break;

            default:
                Console.WriteLine("Invalid course selected.");
                break;
        }
    }
}