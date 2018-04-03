using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   

        public class Person
        {
            private string name;
            public string Name
            {
                get { return (name); }
            }
            public Person(string n)
            {
                name = n;
            }
            public virtual void Show()
            {
                Console.WriteLine("Person is {0}", Name);
            }
        }
        public class Employee : Person
        {
            private string supervisor;
            public string Supervisor
            {
                get { return (supervisor); }
            }
            public Employee(string n) : base(n)
            {
                supervisor = "Big Boss";
            }
            public override void Show()
            {
                Console.WriteLine("Employee is {0}", Name);
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] employees = {new Person("Ah Kow"),
                                  new Person("Ah Ter"),
                                  new Employee("Ah Yeow"),
                                  new Employee("Ah Beng")};
            foreach (Person p in employees)
            {
                p.Show();

            }
        }
    }

}
