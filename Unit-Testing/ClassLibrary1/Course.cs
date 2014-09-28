namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private string name;
        private IList<Student> students = new List<Student>();

        public Course(string name)
        {
            this.Name = name;
        }

        public Course(string name, List<Student> students) : this(name)
        {
            this.students = students;
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

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public void JoinCourse(Student student)
        {
            if (this.Students.Count + 1 > 30)
            {
                throw new InvalidOperationException("Course should have no more than 30 students");
            }

            this.Students.Add(student);
        }

        public void LeaveCourse(Student student)
        {
            if (!this.Students.Contains(student))
            {
                throw new InvalidOperationException("the given studnet is not part of the course!");
            }

            this.Students.Remove(student);
        }
    }
}
