using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP
{
    // Course class to manage courses, has two properties: Name and Students
    class Course
    {
        // Use properties to encapsulate data fields
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        // Use the index to access the students in the course
        public Student this[int index]
        {
            get { return Students[index]; }
            set { Students[index] = value; }
        }

        // Method to display course information
        public void ShowInfo()
        {
            Console.WriteLine("Course: {0}", Name);
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine("- {0}", student.Name);
            }
        }
    }
}
