using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SortClass
    {
        public void SortOnCategory()
        {
            Person[] people = {
            new Person(){ FirstName="Steve", LastName="Jobs"},
            new Person(){ FirstName="Bill", LastName="Gates"},
            new Person(){ FirstName="Lary", LastName="Page"}
        };

            var list = from p in people
                       orderby p.LastName
                       select p;

            Array.ForEach<Person>(list.ToArray<Person>(), p => Console.WriteLine(p.FirstName + " " + p.LastName));
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}

