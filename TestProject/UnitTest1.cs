using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            // Create instances of teachers, students, departments, courses, and subjects
            Teacher t1 = new Teacher() { Name = "Nguy?n V?n A", Age = 40, Department = "C�ng ngh? th�ng tin" };
            Teacher t2 = new Teacher() { Name = "Tr?n Th? B", Age = 35, Department = "To�n h?c" };
            Teacher t3 = new Teacher() { Name = "L� V?n C", Age = 38, Department = "V?t l�" };

            Student s1 = new Student() { Name = "Ph?m Th? D", Age = 20, Course = null, Subjects = new List<Subject>() };
            Student s2 = new Student() { Name = "Nguy?n V?n E", Age = 21, Course = null, Subjects = new List<Subject>() };
            Student s3 = new Student() { Name = "Tr?n Th? F", Age = 19, Course = null, Subjects = new List<Subject>() };

            Department d1 = new Department() { Name = "C�ng ngh? th�ng tin", Teachers = new List<Teacher>() { t1 } };
            Department d2 = new Department() { Name = "To�n h?c", Teachers = new List<Teacher>() { t2 } };
            Department d3 = new Department() { Name = "V?t l�", Teachers = new List<Teacher>() { t3 } };

            Course c1 = new Course() { Name = "C# .NET", Students = new List<Student>() { s1, s2 } };
            Course c2 = new Course() { Name = "Java", Students = new List<Student>() { s3 } };

            Subject sub1 = new Subject() { Name = "L?p tr�nh h??ng ??i t??ng", Teacher = t1 };
            Subject sub2 = new Subject() { Name = "Gi?i t�ch", Teacher = t2 };
            Subject sub3 = new Subject() { Name = "?i?n t?", Teacher = t3 };

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
            Assert.AreEqual("Nguy?n V?n A", t1.Name);
            Assert.AreEqual("Tr?n Th? B", t2.Name);
            Assert.AreEqual("L� V?n C", t3.Name);

            Assert.AreEqual("Ph?m Th? D", s1.Name);
            Assert.AreEqual("Nguy?n V?n E", s2.Name);
            Assert.AreEqual("Tr?n Th? F", s3.Name);

            Assert.AreEqual("C�ng ngh? th�ng tin", d1.Name);
            Assert.AreEqual("To�n h?c", d2.Name);
            Assert.AreEqual("V?t l�", d3.Name);

            Assert.AreEqual("C# .NET", c1.Name);
            Assert.AreEqual("Java", c2.Name);

            Assert.AreEqual("L?p tr�nh h??ng ??i t??ng", sub1.Name);
            Assert.AreEqual("Gi?i t�ch", sub2.Name);
            Assert.AreEqual("?i?n t?", sub3.Name);
        }
    }
}