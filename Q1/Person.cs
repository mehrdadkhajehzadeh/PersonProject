using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Person
    {
        //private string _firstName;
        //private string _lastName;
        public string FirstName { get;private set; }

        
        public string LastName { get;private set; }

        public Person(string firstName)
        {
            FirstName = firstName;
        }
        public void GetFullName()
        {
            Console.WriteLine($"Name is : {FirstName}, LastName is : {LastName}");
        }
        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }
    }
}
