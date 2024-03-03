using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP
{
    // The Teacher class inherits from the Person class, with an additional Department attribute
    class Teacher : Person
    {
        // Use properties to encapsulate data fields
        public string Department { get; set; }

        // Override method to display teacher information
        public override void ShowInfo()
        {
            Console.WriteLine("Teacher: {0}, Age: {1}, Department: {2}", Name, Age, Department);
        }
    }
}
