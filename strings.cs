
using System;
using System.Text;

class Strings
{
    public static void stringbul()
    {
        string name = "bharath";
        name += " Hi";
        name += " long time no see";
        Console.WriteLine(name);
        //above one creates a variable each time and consumes a lot of memory...

        StringBuilder sb = new StringBuilder("bharat");
        sb.Append(" hi");
        sb.Append(" how r u dng");
        Console.WriteLine(sb);
        //Console.WriteLine(sb.ToString());
        //it consumes a less memory and it doesnt create variabkes mulitple times...
    }
}

//Verbatim string literal it uses "@" it tells
// the compiler to treat string exactly as it is \
//with out taking // or /n for new line for ex:

///string path = "C:\\Users\\Bharath\\Documents";
///string path = @"C:\Users\Bharath\Documents";


// String vs string builder

// | Feature  | `string`                          | `StringBuilder`                    |
// | -------- | --------------------------------- | ---------------------------------- |
// | Type     | Built-in **data type**            | Class from `System.Text` namespace |
// | Behavior | **Immutable** (cannot change)     | **Mutable** (can be changed)       |
// | Usage    | Good for **small/simple strings** | Good for **many or large changes** |

//strings crete new variables every time and consumes a lot of memory...

// string builder does not create anew varaible and consumes less memory which is 
//fast and efficient than string...
// u can use string builder whn u do lot of string modifications in your code...