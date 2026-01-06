namespace Problems;

public class DictionaryProblems
{
    public static void Run()
    {
        // Dictionary<int,string> names = new Dictionary<int, string>
        // {
        //   {1,"Aba"},
        //   {2, "swap"}  
        // };

        // foreach (var item in names)
        // {
        //     Console.WriteLine($"{item.Key} - {item.Value}");
        // }


        // names[3] = "Shri";

        // if(names.TryGetValue(1, out string? value))
        // {
        //     Console.WriteLine(value);
        // }

        // Console.WriteLine($"1 is exists {names.ContainsKey(1)}");
        // names.Remove(3);

        // foreach (var item in names)
        // {
        //     Console.WriteLine($"{item.Key} - {item.Value}");
        // }



        string input = "aabbbcddde";

        Dictionary<char, int> chars = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write($"{input[i]} ");
            if (!chars.ContainsKey(input[i]))
            {
                chars[input[i]] = 0;
            }
            chars[input[i]]++; 
        }

        Console.WriteLine();
        foreach (var item in chars)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine($"the first repeating char is ");
    }
}