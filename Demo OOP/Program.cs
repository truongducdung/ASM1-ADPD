using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP
{
    class Program
    {
        // Program class to run the program
        static void Main(string[] args)
        {
            // Create teacher, student, department, course and subject objects
                Teacher t1 = new Teacher() { Name = "Nguyen Van A", Age = 40, Department = "IT" };
                Teacher t2 = new Teacher() { Name = "Tran Thi B", Age = 35, Department = "Discrete Math" };
                Teacher t3 = new Teacher() { Name = "Le Van C", Age = 38, Department = "Networking" };

                Student s1 = new Student() { Name = "Pham Thi D", Age = 20, Course = null, Subjects = new List<Subject>() };
                Student s2 = new Student() { Name = "Nguyen Van E", Age = 21, Course = null, Subjects = new List<Subject>() };
                Student s3 = new Student() { Name = "Tran Thi F", Age = 19, Course = null, Subjects = new List<Subject>() };

                Department d1 = new Department() { Name = "IT", Teachers = new List<Teacher>() { t1 } };
                Department d2 = new Department() { Name = "Math", Teachers = new List<Teacher>() { t2 } };
                Department d3 = new Department() { Name = "Physical", Teachers = new List<Teacher>() { t3 } };

                Course c1 = new Course() { Name = "C# .NET", Students = new List<Student>() { s1, s2 } };
                Course c2 = new Course() { Name = "Java", Students = new List<Student>() { s3 } };

                Subject sub1 = new Subject() { Name = "OOP", Teacher = t1 };
                Subject sub2 = new Subject() { Name = "Discrete Math", Teacher = t2 };
                Subject sub3 = new Subject() { Name = "Networking", Teacher = t3 };

            // Assign courses and subjects to students
                s1.Course = c1;
                s1.Subjects.Add(sub1);
                s1.Subjects.Add(sub2);

                s2.Course = c1;
                s2.Subjects.Add(sub1);
                s2.Subjects.Add(sub3);

                s3.Course = c2;
                s3.Subjects.Add(sub1);
                s3.Subjects.Add(sub2);
                s3.Subjects.Add(sub3);

            // Displays information of objects
                Console.WriteLine("Information about objects:");
                Console.WriteLine();

                t1.ShowInfo();
                Console.WriteLine();

                t2.ShowInfo();
                Console.WriteLine();

                t3.ShowInfo();
                Console.WriteLine();

                s1.ShowInfo();
                Console.WriteLine();

                s2.ShowInfo();
                Console.WriteLine();

                s3.ShowInfo();
                Console.WriteLine();

                d1.ShowInfo();
                Console.WriteLine();

                d2.ShowInfo();
                Console.WriteLine();

                d3.ShowInfo();
                Console.WriteLine();

                c1.ShowInfo();
                Console.WriteLine();

                c2.ShowInfo();
                Console.WriteLine();

                sub1.ShowInfo();
                Console.WriteLine();

                sub2.ShowInfo();
                Console.WriteLine();

                sub3.ShowInfo();
                Console.WriteLine();

                Console.ReadKey();
            }
        }
    }

