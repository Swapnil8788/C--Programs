namespace Problems;

public class LargestOfSeven
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
        int d = ReadValue();
        int e = ReadValue();
        int f = ReadValue();
        int g = ReadValue();
        int largest = a > b ? a : b;
        largest = largest > c ? largest : c;
        largest = largest > d ? largest : d;
        largest = largest > e ? largest : e;
        largest = largest > f ? largest : f;
        largest = largest > g ? largest : g;


        Console.WriteLine($"{largest} is the largest number of all 7 numbers");
    }
}