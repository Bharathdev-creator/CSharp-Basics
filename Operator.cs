using System;
using System.Linq.Expressions;
class Operator
{
    public static void ArithmeticOpe()
    {
        int sum1 = 1000;
        int sum2 = 2000;
        Console.WriteLine(sum1 + sum2);
        Console.WriteLine(sum2 - sum1);
        Console.WriteLine(sum2 * sum1);
        Console.WriteLine(sum2 / sum1);
        Console.WriteLine(sum2 % sum1);
    }

    public static void AssignmentOpe()
    {
        int sum1 = 1000;
        sum1 += 100;
        Console.WriteLine(sum1);
        int sum2 = sum1;
        sum2 -= 500;
        Console.WriteLine(sum2);
        int sum3 = sum2;
        sum3 *= 10;
        Console.WriteLine(sum3);
        int sum4 = sum3;
        sum4 /= 2;
        Console.WriteLine(sum4);
        int sum5 = sum4;
        sum5 %= 2;
        Console.WriteLine(sum5);
        int sum6 = sum5;
        Console.WriteLine(sum6);
    }

    public static void RelationalOpe()
    {
        int x = 1500;
        int y = 2000;
        Console.WriteLine(x == y);
        Console.WriteLine(x != y);
        Console.WriteLine(x > y);
        Console.WriteLine(x < y);
        Console.WriteLine(x >= y);
        Console.WriteLine(x <= y);
    }

    public static void logicalOpe()
    {
        int x = 10;
        int y = 20;
        int a = 30;
        string name = "charan";
        if ((x > y) && (name == "charan"))
        {
            Console.Write("you extracted the exact data");
        }
        else if ((a == 20) || (name != "charan"))
        {
            Console.WriteLine("you got some inf");
        }
        else if ((x != 10) && (a != 30))
        {
            Console.WriteLine("not an exact data");
        }
        else
        {
            Console.WriteLine("these are logical operators");
        }

        int age = 25;
        if (!(age < 18))
        {
            Console.WriteLine("You are eligible");
        }
    }

    public static void UnaryOper()
    {
        // Pre inc and post incr...
        int x = 5;
        int y = ++x;
        Console.WriteLine(x);
        Console.WriteLine(y);

        int a = 5;
        int b = a++;
        Console.WriteLine(a);
        Console.WriteLine(b);

        int c = 5;
        int d = --c;
        Console.WriteLine(c);
        Console.WriteLine(d);

        int z = 5;
        int s = z--;
        Console.WriteLine(z);
        Console.WriteLine(s);
    }

    public static void NullCoalsceing()
    {
        string name = "null";
        string result = name ?? "unknown";
        Console.WriteLine(result);
    }
}