using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private IList<Student> students = new List<Student>();

        public Course(List<Student> students)
        {
            this.students = students;
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
