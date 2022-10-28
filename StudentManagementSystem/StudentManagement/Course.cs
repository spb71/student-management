using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Course
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int grade;
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public int studentTotal;

        public Course(string name)
        {
            this.name = name;
            this.studentTotal = 0;
        }
    }
}
