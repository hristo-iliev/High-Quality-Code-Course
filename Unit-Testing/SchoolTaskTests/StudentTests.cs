namespace SchoolTaskTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void StudentTest()
        {
            string name = "Pesho Mishkov";
            int uniqueNumber = 62355;
            Student student = new Student(name, uniqueNumber);
            Assert.AreEqual(student.Name, "Pesho Mishkov");
            Assert.AreEqual(student.UniqueNumber, 62355);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentConstructorTestUniqueNumber()
        {
            string name = string.Empty;
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NameTestNullValue()
        {
            string name = "Pe6o Ivanov";
            int uniqueNumber = 345;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        public void UniqueNumberTestStartValue()
        {
            string name = "Pe6o Ivanov";
            int uniqueNumber = 10000;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void UniqueNumberTestEndValue()
        {
            string name = "Pe6o Ivanov";
            int uniqueNumber = 99999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }
    }
}
