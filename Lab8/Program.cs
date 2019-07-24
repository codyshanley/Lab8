using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager sm = new StudentManager();

            sm.IntroMessage();
            int index = sm.GetStudentIndex();
            sm.DisplayInfo(index);
        }
    }
}
