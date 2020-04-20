using ConsoleAppInterfaces.DataDoodads;
using ConsoleAppInterfaces.Models;
using System;
using System.Collections.Generic;

namespace ConsoleAppInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, Person> people = new Dictionary<int, Person>();
            BaseDataCache<Person> dads = new BaseDataCache<Person>(people, people.Count);
            dads.Add(new Person { Name = "Amy", Email = "amy@localhost" });
            dads.Add(new Person { Name = "Joe", Email = "joe@localhost" });
            dads.Add(new Person { Name = "Dan", Email = "Dan@localhost" });
            dads.Add(new Person { Name = "Ted", Email = "Ted@localhost" });

            Person person1 = new Person { Name = "Ted", Email = "Ted@localhost" };
            var search = dads.FindOne(person1);
            if(search.Sucess)
            {
                dads.Remove(search.Item);
            }
            

            var person2 = dads.FindOne(data: new Person { Name = "Amy" });

            Console.WriteLine("Hello, " + person1.Name);
        }
    }
}
