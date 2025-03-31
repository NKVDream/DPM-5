using System;
struct Student
{
    public int Id { get; set; }
    public char Status { get; set; }
    public string Name { get; set; }
    public int Grade { get; set; }
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
        Console.WriteLine($"Student id:{id}\t Student name:{name}");
    }
    public Student(int id, char status)
    {
        Id=id;
        Status = status;
        Console.WriteLine($"Student id:{id}\t Student status:{status}");
    }
    public Student(int id, int grade)
    {
        Id = id;
        Grade = grade;
        Console.WriteLine($"Student id:{id}\t Student grade:{grade}");
    }

}