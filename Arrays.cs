//Arrays

// int[] number = new int[5];
// number[0] = 20;       //Assigning values...
// number[1] = 30;
// number[2] = 40;
// number[3] = 50;
// number[4] = 60;
// Console.WriteLine(number[3]);

class Sarrays
{
    public static void singledim()
    {
        // string[] fruits = { "apple", "banana", "cat", "dog" };
        // foreach (string fruit in fruits)
        // {
        //     Console.WriteLine(fruit);
        // }

        int[] numberss = { 80, 60, 50, 75, 95, 31 };
        Array.Sort(numberss); // Ascending order...//Alphabetical order...
        Array.Reverse(numberss); //Descending order...
    }

    //multi dimension same rows and coloumns...
    public static void multdimen()
    {
        //imagine marks of 3 students in 2 subjs col 0 math,col1 sci
        int[,] marks_of_students ={
            {70,80},
            {80,90},
            {90,95}
        };
        Console.WriteLine("Marks of student1 is:" + marks_of_students[0, 0]);
        //o indicates row 0 {70,80}, second zero indicates colo 0 (70).....
        string[,] party = {
            {"ram","sam"},
            {"daniel","cathy"}
        };
        Console.WriteLine("welcome to the party:" + party[0, 1]);
    }

    //jagged arrays same rows but multiple coloumns:
    public static void jged()
    {
        int[][] students_marks = new int[3][];
        students_marks[0] = new int[] { 70 };
        students_marks[1] = new int[] { 60, 49 };
        students_marks[2] = new int[] { 50, 79, 89 };
        //Console.WriteLine(students_marks[1][1]);

        string[][] hobbies = new string[3][];
        hobbies[0] = new string[] { "cricket", "football" };
        hobbies[1] = new string[] { "hockey", "football", "videogames" };
        hobbies[2] = new string[] { "cricket" };
        Console.WriteLine(hobbies[2][0]);
        //row 1 coloumn1 => 49
    }

    // params allow u to pass a multiple values in to method of same datatype 
    // or even zero values then it will give an empty array .
    // u must use one param keyword that should be the last keyword...

    public static void PrintNumbers(params int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(i);
        }
    }
    // PrintNumbers(1,2,3,4,5); this is how ucall a method..
    // PrintNumbers(); this will give an empty array.
}
