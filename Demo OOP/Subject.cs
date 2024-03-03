using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP
{
    // Subject class to manage subjects, has two properties: Name and Teacher
    class Subject
    {
        // Use properties to encapsulate data fields
        public string Name { get; set; }
        public Teacher Teacher { get; set; }

        // Method to display subject information
        public void ShowInfo()
        {
            Console.WriteLine("Subject: {0}, Teacher: {1}", Name, Teacher.Name);
        }
    }
}
