using System;
using System.Collections.Generic;
namespace Lab8
{
    public class StudentManager
    {
        public List<Student> students = new List<Student>();

        public StudentManager()
        {
            //populate list
            students.Add(new Student("Dakota", "Kent City", "Pho"));
            students.Add(new Student("Joshua", "Grand Rapids", "Cheese Tortellini"));
            students.Add(new Student("Tommy", "Raleigh", "Chicken Curry"));
            students.Add(new Student("James", "Grand Rapids", "Cheeseburger and Fries"));
            students.Add(new Student("Maricela", "Morelia", "Tacos"));
            students.Add(new Student("KimVy", "Grand Rapids", "Sushi"));
            students.Add(new Student("Sam", "Grand Rapids", "Tacos"));
            students.Add(new Student("Cody", "Lawton", "Potato Soup"));
            students.Add(new Student("Flaka", "Pristina", "Thai Food"));
            students.Add(new Student("Mahruchi", "Teaneck", "Chicken Wings"));
            students.Add(new Student("Manik", "Cox's Bazar", "Spicy Beef Curry"));
            students.Add(new Student("Moise", "Grand Rapids", "Lasagna"));
            students.Add(new Student("Liz", "Earth", "Smoked Salmon"));
            students.Add(new Student("Jason", "Holland", "Burgers"));
        }

        public void IntroMessage()
        {
            Console.WriteLine("Welcome to our C# class.");
            Console.WriteLine("Which student would you like to learn more about?\n");
        }

        public int GetStudentIndex()
        {
            int index = 0;
            bool isValid = false;

            while (isValid == false)
            {
                try
                {
                    Console.Write("Please enter a student number between 1 and 14: ");
                    index = int.Parse(Console.ReadLine());

                    if (index > 0 && index < 15)
                    {
                        isValid = true;
                        return index;
                    }
                    else
                    {
                        Console.WriteLine("Entry not between 1 and 14.\n");
                        continue;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Entry not a valid integer.\n");
                    continue;
                }
            }
            return -1;

        }


        public void DisplayInfo(int studentNum)
        {
            Student stu = students[studentNum - 1]; //reduce studentNum by 1 for list starting at 0

            Console.WriteLine("Student " + studentNum + " is " + stu.GetName() + ".");
            Console.WriteLine("What would you like to know about " + stu.GetName() + "?");
            Console.Write("(enter \"hometown\" or \"favorite food\"): ");

            string response = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (response == "hometown")
            {
                bool isValid = false;

                while (isValid == false)
                {
                    Console.WriteLine(stu.GetName() + " is from " + stu.GetHometown() + ".");
                    Console.Write("Would you like to know more? (enter \"yes\" or \"no\"): ");
                    string response2 = Console.ReadLine().ToLower();

                    if (response2 == "yes")
                    {
                        Console.WriteLine();
                        isValid = true;
                        DisplayInfo(GetStudentIndex());
                    }
                    else if (response2 == "no")
                    {
                        isValid = true;
                        Console.WriteLine("Thanks!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid response.");
                        DisplayInfo(studentNum);
                        isValid = false;
                    }
                }
            }
            else if (response == "favorite food")
            {
                bool isValid = false;

                while (isValid == false)
                {
                    Console.WriteLine(stu.GetName() + "'s favorite food is " + stu.GetFaveFood() + ".");
                    Console.Write("Would you like to know more? (enter \"yes\" or \"no\"): ");
                    string response2 = Console.ReadLine().ToLower();

                    if (response2 == "yes")
                    {
                        Console.WriteLine();
                        isValid = true;
                        DisplayInfo(GetStudentIndex());
                    }
                    else if (response2 == "no")
                    {
                        isValid = true;
                        Console.WriteLine("Thanks!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid response.");
                        DisplayInfo(studentNum);
                        isValid = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("That data does not exist. Please try again.\n");
                DisplayInfo(studentNum);
            }
        }
    }
}
