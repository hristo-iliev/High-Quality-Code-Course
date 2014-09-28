namespace SchoolTaskTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CourseTestName()
        {
            string name = "OOP";
            Course course = new Course(name);
            Assert.AreEqual(course.Name, "OOP");
        }

        [TestMethod]
        public void CourseTestListStudents()
        {
            string name = "OOP";
            List<Student> students = new List<Student> 
            { 
                new Student("Peshko Shishkov", 12233) 
            };
            Course course = new Course(name, students);
            bool contains = this.DoesCourseContainStudent(course.Students, "Peshko Shishkov");
            Assert.IsTrue(contains);
        }  
              
        [TestMethod]
        public void JoinCourseTest()
        {
            string name = "OOP";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student pesho = new Student("Pesho Peshov", 12345);
            course.JoinCourse(pesho);
            Assert.IsTrue(course.Students.Contains(pesho));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void JoinCourse31StudentsTest()
        {
            string name = "OOP";
            List<Student> students = new List<Student>
            {
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
                new Student("Peshko Shishkov", 12233),
            };
            Course course = new Course(name, students);
            Student pesho = new Student("Pesho Peshov", 12233);
            course.JoinCourse(pesho);
            Assert.IsTrue(course.Students.Contains(pesho));
        }

        [TestMethod]
        public void LeaveCourseTest()
        {
            string name = "OOP";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student pesho = new Student("Pesho Peshov", 12345);
            course.JoinCourse(pesho);
            course.LeaveCourse(pesho);
            Assert.IsTrue(course.Students.Count == 0);
        }
        
        private bool DoesCourseContainStudent(IList<Student> students, string name)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
