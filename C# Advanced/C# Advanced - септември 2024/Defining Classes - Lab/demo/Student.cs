using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace demo;



public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Family { get; set; }


    public Student()
    {

    }
    public Student(string name) : this()
    {
        Name = name;
    }

    public Student(string name, int age) : this(name)
    {
        Age = age;
    }

    public Student(string name,int age,string family) :this(name,age)
    {
        Family=family;
    }

}