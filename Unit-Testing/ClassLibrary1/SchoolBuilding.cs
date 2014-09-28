namespace School
{
    using System;
    using System.Collections.Generic;

    public class SchoolBuilding
    {
        private string name;
        private IList<Course> courses = new List<Course>();

        public SchoolBuilding(string name)
        {
            this.Name = name;
        }

        public SchoolBuilding(string name, List<Course> courses)
            : this(name)
        {
            this.Courses = courses;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Name! Name can't be null or empty");
                }

                this.name = value;
            }
        }

        public IList<Course> Courses
        {
            get
            {
                return this.courses;
            }

            set
            {
                this.courses = value;
            }
        }
    }
}
