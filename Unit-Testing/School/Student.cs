using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
     public class Student
    {
         private string name;
         private int uniqueNumber;

         public Student(string name)
         {
             this.Name = name;
         }

         public Student(string name, int number) : this(name)
         {
             this.UniqueNumber = number;
         }

         public string Name
         {
             get
             {
                 return this.name;
             }
             set
             {
                 if (String.IsNullOrEmpty(value))
                 {
                     throw new ArgumentException("Invalid Name! Name can't be null or empty");
                 }
                 this.name = value;
             }
         }

         public int UniqueNumber
         {
             get
             {
                 return this.uniqueNumber;
             }
             set
             {
                 if (value < 1000 || value > 99999)
                 {
                     throw new ArgumentException("Invalid Unique Number! It should be in range 10000 - 99999");
                 }
             }
         }
    }
}
