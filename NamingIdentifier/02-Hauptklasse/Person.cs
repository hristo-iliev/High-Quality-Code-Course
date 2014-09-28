namespace _02_Hauptklasse
{
    using System;

    public enum Gender 
    { 
        Male, Female 
    }

    public class Person
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
                    
        public void CreatePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "Батката";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Мацето";
                newPerson.Gender = Gender.Female;
            }
        }
    }    
}
