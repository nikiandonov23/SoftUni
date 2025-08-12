// See https://aka.ms/new-console-template for more information


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


}

class Family
{
    private List<Person> members;

    public Family()
    {
        members=new List<Person>();
    }

    public void AddMember(Person member)
    {
        members.Add(member);
    }

}
