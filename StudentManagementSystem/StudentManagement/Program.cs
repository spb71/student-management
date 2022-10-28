using StudentManagement;
using System;
namespace StudentManagerPortal;

class Program
{

    static List<Course> courses = new List<Course>(); //Preset courses
    static List<Student> students = new List<Student>(); //Keep track of total number of students
    static void Main(string[] args)
    {

        courses.Add(new Course("History"));
        courses.Add(new Course("English"));
        courses.Add(new Course("Math"));
        courses.Add(new Course("Science"));

        //Used throughout app to keep user in menus until finished
        bool exitStatus = false;

        Console.WriteLine("<------------Student Management-------------->");
        while (!exitStatus)
        {
            Console.WriteLine("Please select a menu option!!!!");
            Console.WriteLine("\n1. Register Student" + "\n2. List Students" + "\n3. Find Student by id" + "\n4. Edit Student info" + "\n5. Course Student total" + "\n6. Exit");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    
                    string name, fName = "", mName, lName = "";
                    DateTime dob;
                    int year = 0, month = 0, day = 0;
                    List<Course> courses = new List<Course>();

                    while (!exitStatus)
                    {
                        Console.WriteLine("Please enter Student's first name: ");

                        fName = Console.ReadLine();

                        if (fName.Equals(""))
                        {
                            Console.WriteLine("First name can not be blank.");
                        }
                        else
                        {
                            exitStatus = true;
                        }
                    }

                    exitStatus = false;

                    while (!exitStatus)
                    {
                        Console.WriteLine("Please enter Student's last name: ");

                        lName = Console.ReadLine();

                        if (lName.Equals(""))
                        {
                            Console.WriteLine("Last name can not be blank.");
                        }
                        else
                        {
                            exitStatus = true;
                        }
                    }

                    exitStatus = false;

                    name = String.Concat(fName, " ", lName);

                    while (!exitStatus)
                    {
                        Console.WriteLine("Please enter Student's birth year: ");

                        year = int.Parse(Console.ReadLine());

                   
                    }

                    exitStatus = false;

                    while (!exitStatus)
                    {
                        Console.WriteLine("Please enter Student's birth month: ");

                        month = int.Parse(Console.ReadLine());

                        if (month > 12 || month < 1)
                        {
                            Console.WriteLine("Invalid month");
                        }
                        else
                        {
                            exitStatus = true;
                        }
                    }

                    exitStatus = false;

                    while (!exitStatus)
                    {
                        Console.WriteLine("Please enter Student's birth day: ");

                        day = int.Parse(Console.ReadLine());

                        if (day > 31 || year < 1)
                        {
                            Console.WriteLine("Invalid day.");
                        }
                        else
                        {
                            exitStatus = true;
                        }
                    }

                    exitStatus = false;

                    dob = new DateTime(year, month, day);

                    Student student = new Student(name, dob, courses);
                    students.Add(student);
                    break;
                case 2:
                    //List of Students;
                    break;
                case 3:
                    //Find Student by Id;
                    break;
                case 4:
                    //Edit Student Info;
                    break;
                case 5:
                    //Total number of Courses;
                    break;
                case 6:
                    exitStatus = true;
                    break;
            }
        }
    }
}

