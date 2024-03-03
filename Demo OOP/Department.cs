using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP
{
    // Department class to manage departments, has two properties: Name and Teachers
    class Department
    {
        // Use properties to encapsulate data fields
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }

        // Use the index to access the teachers in the department
        public Teacher this[int index]
        {
            get { return Teachers[index]; }
            set { Teachers[index] = value; }
        }

        // Method to display department information
        public void ShowInfo()
        {
            Console.WriteLine("Department: {0}", Name);
            Console.WriteLine("Teachers:");
            foreach (var teacher in Teachers)
            {
                Console.WriteLine("- {0}", teacher.Name);
            }
        }
    }
}
