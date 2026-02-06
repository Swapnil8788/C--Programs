
using System.Text;
using System.Linq;
using System.Collections;
namespace Concepts;


public class Student
{
    public string name { get; set;}
    public string surname { get; set;}
    public int standard { get; set;}
}
public class School : IEnumerable
{
    List<Student> students = new List<Student>();
    public void Add(Student s)
    {
        students.Add(s);
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
public class PatternMatching
{
    static string ReadString()
    {
        Console.Write("Please enter a string to continue: ");
        string s = Console.ReadLine();
        return s;
    }
    public static void Run()
    {
        Student s1 = new Student(){name="ab",surname="AB", standard= 10};
        Student s2 = new Student(){name="bc",surname="BC", standard= 11};
        Student s3 = new Student(){name="cd",surname="CD", standard= 12};
        School stds = new School();
        stds.Add(s1);
        stds.Add(s2);
        stds.Add(s3);
        foreach (Student item in stds)
        {
            
        }

    }
}