namespace Problems;

public class LargestOfThree
{
    public static void Run()
    {
        static int ReadValue()
        {
            Console.Write("Please Enter the Number to continue");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        int a = ReadValue();
        int b = ReadValue();
        int c = ReadValue();

        Console.WriteLine($"let the numbers be a , b c {a}, {b}, {c}");

        int largest = a;

        if (b > largest) largest = b;
        if (c > largest) largest = c;

        Console.WriteLine($"{largest} is the largest number");
    }
}
