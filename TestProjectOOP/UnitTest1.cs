using Xunit;

namespace TestProjectOOP
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            // Create instances of teachers, students, departments, courses, and subjects
            Teacher t1 = new Teacher() { Name = "Nguyen Van A", Age = 40, Department = "IT" };
            Teacher t2 = new Teacher() { Name = "Tran Thi B", Age = 35, Department = "Discrete Math" };
            Teacher t3 = new Teacher() { Name = "Le Van C", Age = 38, Department = "Networking" };

            Student s1 = new Student() { Name = "Pham Thi D", Age = 20, Course = null, Subjects = new System.Collections.Generic.List<Subject>() };
            Student s2 = new Student() { Name = "Nguyen Van E", Age = 21, Course = null, Subjects = new System.Collections.Generic.List<Subject>() };
            Student s3 = new Student() { Name = "Tran Thi F", Age = 19, Course = null, Subjects = new System.Collections.Generic.List<Subject>() };

            Department d1 = new Department() { Name = "IT", Teachers = new System.Collections.Generic.List<Teacher>() { t1 } };
            Department d2 = new Department() { Name = "Math", Teachers = new System.Collections.Generic.List<Teacher>() { t2 } };
            Department d3 = new Department() { Name = "Physical", Teachers = new System.Collections.Generic.List<Teacher>() { t3 } };

            Course c1 = new Course() { Name = "C# .NET", Student = new System.Collections.Generic.List<Student>() { s1, s2 } };
            Course c2 = new Course() { Name = "Java", Student = new System.Collections.Generic.List<Student>() { s3 } };

            Subject sub1 = new Subject() { Name = "OOP", Teacher = t1 };
            Subject sub2 = new Subject() { Name = "Discrete Math", Teacher = t2 };
            Subject sub3 = new Subject() { Name = "Networking", Teacher = t3 };

            // Act
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

            // Assert
            // Verify the expected behavior of the program
            Assert.Equal("Nguyen Van A", t1.Name);
            Assert.Equal("Tran Thi B", t2.Name);
            Assert.Equal("Le Van C", t3.Name);

            Assert.Equal("Pham Thi D", s1.Name);
            Assert.Equal("Nguyen Van E", s2.Name);
            Assert.Equal("Tran Thi F", s3.Name);

            Assert.Equal("IT", d1.Name);
            Assert.Equal("Math", d2.Name);
            Assert.Equal("Physical", d3.Name);

            Assert.Equal("C# .NET", c1.Name);
            Assert.Equal("Java", c2.Name);

            Assert.Equal("OOP", sub1.Name);
            Assert.Equal("Discrete Math", sub2.Name);
            Assert.Equal("Networking", sub3.Name);
        }
    }

    internal class Student
    {
        public string Name { get; internal set; }
        public object Course { get; internal set; }
        public System.Collections.Generic.List<Subject> Subjects { get; internal set; }
        public int Age { get; internal set; }
    }

    internal class Teacher
    {
        public string Name { get; internal set; }
        public int Age { get; internal set; }
        public string Department { get; internal set; }
    }
    internal class Department
    {
        public Department()
        {
        }

        public string Name { get; set; }
        public object Teachers { get; set; }
    }
    internal class Subject
    {
        public string Name { get; internal set; }
        public Teacher Teacher { get; internal set; }
    }
    internal class Course
    {
        public System.Collections.Generic.List<Student> Student { get; internal set; }
        public string Name { get; internal set; }
    }
}
