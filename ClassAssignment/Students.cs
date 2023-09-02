using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }

        public override string ToString()
        {
            return "Course Id = " + CourseId + "Course Name = " + CourseId + "Fees =" + Fees;
        }
        public void AcceptDet()
        {
            Console.WriteLine("Enter Course Id");
            Console.WriteLine("Enter Course Name");
        }
    }
    class Students
    {
        private int RollNo { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
        private Course MyCourse { get; set; }

        public override string ToString()
        {
            return "Roll No =" + RollNo + "\nName = " + Name + "\nPercentage = " + Percentage+ MyCourse;

        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter Roll No");
            Console.WriteLine("Enter Name");
            Console.WriteLine("Enter Percentage");
        }

    }
}
