using System;
class Person
{
    public string[] Names = {"Zak", "Dave", "Tom"};
    public string Name { get; set; }
    
    public Person(string name)
    {
        if (Names.Contains(name))
        {
            Name = name;
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("2");
        }
    }
}
