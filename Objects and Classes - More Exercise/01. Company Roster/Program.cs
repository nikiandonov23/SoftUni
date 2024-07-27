// See https://aka.ms/new-console-template for more information

string departmentBiggest = "";


List<Employee> allEmployees = new List<Employee>();
int n = int.Parse(Console.ReadLine());

string input = "";
for (int i = 0; i < n; i++)
{
    input=Console.ReadLine();
    string[] tockens = input.Split(" ");

    Employee currEmployee = new Employee(tockens[0], double.Parse(tockens[1]), tockens[2]);
    allEmployees.Add(currEmployee);


}






class Employee
{
    public Employee(string name, double salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }

    public string Name { get; set; }

    public double Salary { get; set; }

    public string Department { get; set; }


    

}
