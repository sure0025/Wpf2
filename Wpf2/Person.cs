using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2
{

    class Person
    {

        public Person(string FirstName, string LastName, int Age, string TelephoneNr)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.TelephoneNr = TelephoneNr; 
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string TelephoneNr { get; set; }
    }
}
