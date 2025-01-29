using System;
using System.Collections.Generic;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
}

public class Program
{
    public static void Distinguish(List<Person> personList)
    {
        const string Male = "Male";
        const string Female = "Female";
        List<Person> maleList = new List<Person>();
        List<Person> femaleList = new List<Person>();

        foreach (var person in personList)
        {
            if (person.Gender == Male)
            {
                maleList.Add(person);
            }
            else if (person.Gender == Female)
            {
                femaleList.Add(person);
            }
        }

        Console.WriteLine("Male List:");
        foreach (var male in maleList)
        {
            Console.WriteLine($"Id: {male.Id}, Name: {male.Name}, Gender: {male.Gender}");
        }

        Console.WriteLine("\nFemale List:");
        foreach (var female in femaleList)
        {
            Console.WriteLine($"Id: {female.Id}, Name: {female.Name}, Gender: {female.Gender}");
        }
    }

    public static void Main(string[] args)
    {
        List<Person> personList = new List<Person>
        {
            new Person { Id = 1, Name = "Nish", Gender = "Male" },
            new Person { Id = 2, Name = "Nishant", Gender = "Male" },
            new Person { Id = 3, Name = "Rita", Gender = "Female" },
            new Person { Id = 4, Name = "Lisa", Gender = "Female" },
            new Person { Id = 5, Name = "David", Gender = "Male" }
        };

        Distinguish(personList);
    }
}