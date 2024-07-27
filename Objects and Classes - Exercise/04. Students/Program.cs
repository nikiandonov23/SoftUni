// See https://aka.ms/new-console-template for more information




int n = int.Parse(Console.ReadLine());

List<Student> allStudents = new List<Student>();
string input = "";
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine();
    string[] tockens = input.Split(" ");

    Student currentStudent = new Student(tockens[0], tockens[1], double.Parse(tockens[2]));
    allStudents.Add(currentStudent);
}

//b1 i b2 sa izmisleni sled tova mu kazvam ot kude da po4ne da namalq ili obratnoto



allStudents.Sort((b1,b2)=>b2.Grade.CompareTo(b1.Grade));


foreach (var student in allStudents)
{
    student.Print();
}




class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public void Print()
    {
        Console.WriteLine($"{FirstName} {LastName}: {Grade:f2}");
    }

}
