using NUnit.Framework;

namespace TestProject
{
    internal class Student
    {
        public string Name { get; internal set; }
        public int Age { get; internal set; }
        public object Course { get; internal set; }
        public List Subjects { get; internal set; }
    }
}