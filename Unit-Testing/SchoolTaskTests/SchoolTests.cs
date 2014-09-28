namespace SchoolTaskTests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;    

    [TestClass]
    public class SchoolBuildingTests
    {
        [TestMethod]
        public void SchoolTest()
        {
            SchoolBuilding ivanVazov = new SchoolBuilding("Ivan Vazov");
            Assert.IsTrue(ivanVazov.Name == "Ivan Vazov");
        }

        [TestMethod]
        public void SchoolCoursesTest()
        {
            List<Course> courses = new List<Course>();
            SchoolBuilding school = new SchoolBuilding("Ivan Vazov", courses);
            Assert.IsNotNull(school);
        }
    }
}
