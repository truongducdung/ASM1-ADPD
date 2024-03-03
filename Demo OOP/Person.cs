using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP
{
    //The Person class is an abstract class, with two properties: Name and Age
    abstract class Person
    {
        // Use properties to encapsulate data fields
        public string Name { get; set; }
        public int Age { get; set; }

        // Abstract method to display object information
        public abstract void ShowInfo();
    }
}
