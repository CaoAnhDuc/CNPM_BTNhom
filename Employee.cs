using System;

public abstract class Employee
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string SocialSecurityNumber { get; private set; }

    public Employee(string first, string last, string ssn)
    {
        FirstName = first;
        LastName = last;
        SocialSecurityNumber = ssn;
    }

    public abstract double Earnings(); // pure virtual

    public virtual void Print() // virtual
    {
        Console.WriteLine($"{FirstName} {LastName}\nsocial security number: {SocialSecurityNumber}");
    }
}
