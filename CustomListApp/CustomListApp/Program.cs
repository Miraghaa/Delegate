using CustomList.Core.Models;
using CustomList.Data;
using System;
MyList<Person> myList = new MyList<Person>();


myList.Add(new Person { Name = "Miraga", Surname = "Aliyev", Age = 23, Position = "Denior" });
myList.Add(new Person { Name = "Fatali", Surname = "Amirli", Age = 18, Position = "Junior" });
myList.Add(new Person { Name = "Senan", Surname = "Huseynzade", Age = 17, Position = "Boksyor" });

Person person = myList.Find(p => p.Name == "Miraga");

if (person != null)
{
    Console.WriteLine($" {person.Name} {person.Surname} {person.Age} {person.Position}");
}
else
{
    Console.WriteLine("Bele bir adam yoxdu");
}