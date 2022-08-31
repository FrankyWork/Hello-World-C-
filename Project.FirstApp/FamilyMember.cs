namespace Project.FirstApp;

public class FamilyMember
{
    public FamilyMember(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    private string FirstName { get; }
    private string LastName { get; }
    private int Age { get; }

    public override string ToString()
    {
        return string.Format($"Member:\r\n\tName - {FirstName} LastName - {LastName} [ Age {Age} ]");
    }
}