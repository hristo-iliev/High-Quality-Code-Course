using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private IList<Course> courses = new List<Course>();

        private School(List<Course> courses)
        {
            this.Courses = courses;
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
