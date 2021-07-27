using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQQQ
{
    partial class Program
    {
        private static  List<Person> people = new List<Person>();
        
        static void Main(string[] args)
        {
            //Person assd = new Person();
            //assd.FirstName = "Tim;";
            //assd.LastName = "chen";
            SetUpSampleData();
            GeetallThePeople();
            Console.ReadLine();
        }
        private static void SetUpSampleData()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Core" });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm" });
            people.Add(new Person { FirstName = "Jill", LastName = "Jones" });
        }
        private static void GeetallThePeople()
        {
          foreach (var person in people)
            {
                Console.WriteLine($"Hello {person.FirstName}{person.LastName }");
            }
        }

    }
}
