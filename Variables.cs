using System;
using System.Text;

class Variables
{

    static string color = "red";

    //Static methods can't access non-static fields directly.
    //Either make the variable static, or access it via an object.

    //object creation is shown in method map
    float Speed = 3.50f;
    public static void Run()
    {
        int x = 10;
        int y = 20;
        int sum = x + y;
        Console.WriteLine("Variable Example: Sum = " + sum);
    }
    public static void velocity()
    {
        // int x = 100;
        Variables s = new Variables();
        Console.WriteLine(s.Speed);
    }
    //u can define a variable inside a method and cant acces it in another method
    public static void location()
    {
        Console.WriteLine("color of the car is :" + color);
        //Console.WriteLine(x); it throws error initially .....u cant access in this method...
    }

    public static void block()
    {
        int age = 20;
        if (age > 18)
        {
            StringBuilder name = new StringBuilder("tanu");
            name.Append("Hi tanu welcome to my home....");
            Console.WriteLine("You can say " + name);
        }
        // Console.WriteLine(name);  it gives error...
    }
}
