using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Student
    {

        static int ID = 0;
        public int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime dob;
        public DateTime DoB
        {
            get { return dob; }
            set { dob = value; }
        }

        public List<Course> studentCourses;

        public Student()
        {
            this.id = ID++;
            this.dob = new DateTime();
            this.name = "";
            this.studentCourses = new List<Course>();

        }

        public Student(string name, DateTime dob, List<Course> courses)
        {

            this.id = ID++;
            this.dob = dob;
            this.name = name;
            this.studentCourses = courses;
        }
    }
}
