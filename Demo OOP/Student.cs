using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP
{
    // The Student class inherits from the Person class, with additional Course and Subject properties
    class Student : Person
    {
        // Use properties to encapsulate data fields
        public Course Course { get; set; }
        public List<Subject> Subjects { get; set; }

        // Override method to display student information
        public override void ShowInfo()
        {
            Console.WriteLine("Student: {0}, Age: {1}, Course: {2}", Name, Age, Course.Name);
            Console.WriteLine("Subjects:");
            foreach (var subject in Subjects)
            {
                Console.WriteLine("- {0}", subject.Name);
            }
        }
    }
}
