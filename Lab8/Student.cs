using System;
namespace Lab8
{
    public class Student
    {
        public string Name;
        public string Hometown;
        public string FaveFood;

        public Student(string name, string hometown, string faveFood)
        {
            Name = name;
            Hometown = hometown;
            FaveFood = faveFood;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetHometown()
        {
            return Hometown;
        }

        public string GetFaveFood()
        {
            return FaveFood;
        }
    }
}
