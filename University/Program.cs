using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {

            int studentCountInGroups = default;
            int studentCountInLastGroup = default;

            Console.Write("How many students are in the University: ");
            int studentCount = int.Parse(Console.ReadLine());

            Student[] students = new Student[studentCount];

            Console.Write("How many teachers are in the University: ");
            int teacherCount = int.Parse(Console.ReadLine());

            Teacher[] teachers = new Teacher[teacherCount];

            if (studentCount % teacherCount == 0)
            {
                studentCountInGroups = studentCount / teacherCount;
                Console.WriteLine($"In {teacherCount} groups are {studentCountInGroups} students");
            }
            else
            { 
                studentCountInGroups = studentCount / teacherCount;
                studentCountInLastGroup = studentCount / teacherCount + studentCount % teacherCount;
                Console.WriteLine($"In {teacherCount - 1} groups are {studentCountInGroups} students, in last groups are {studentCountInLastGroup} students");
            }

            TeacherManager teacherManager = new TeacherManager(teacherCount);
            teacherManager.GetAll();
            StudentManager studentManager = new StudentManager(studentCount);
            studentManager.GetAll();

            UnivarsityManager univarsityManager = new UnivarsityManager(teacherCount, studentCount);
            univarsityManager.Distribute();

            //Teacher teacher = new Teacher("Aaa", 50);
            //Student[] students = new 

            //teacher.AssignStudents(studentManager.GetAll());
            //teacher.Print();

            univarsityManager.Print();

            Console.ReadKey();


        }
    }
}
