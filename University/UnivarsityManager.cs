using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class UnivarsityManager
    {
        TeacherManager _teacherManager;
        StudentManager _studentManager;

        Student[] _students;
        Teacher[] _teachers;
        public UnivarsityManager(int teachersCount, int studentsCount)
        {
            _teacherManager = new TeacherManager(teachersCount);
            _studentManager = new StudentManager(studentsCount);
        }
        public void Distribute()
        {
            Student[] students = _studentManager.GetAll();
            Teacher[] teachers = _teacherManager.GetAll();
            int studentCount = students.Length;
            int teacherCount = teachers.Length;

            int avarageStudents = studentCount / teacherCount;
            for (int i = 0; i < teachers.Length - 1; i++)
            {
                Student[] currentTeachersStudets = new Student[avarageStudents];
                for (int j = 0; j < avarageStudents; j++)
                {
                    int studentIndex = i * avarageStudents + j;
                    currentTeachersStudets[j] = students[studentIndex];
                }
                teachers[i].AssignStudents(currentTeachersStudets);
            }
            int leftStudents = studentCount / teacherCount + studentCount % teacherCount;
            for (int i = teacherCount-1; i < teacherCount; i++)
            {
                Student[] currentTeachersStudets = new Student[leftStudents];
                for (int j = 0; j < leftStudents; j++)
                {
                    int studentIndex = (teacherCount - 1) * avarageStudents + j;
                    currentTeachersStudets[j] = students[studentIndex];
                }
                teachers[i].AssignStudents(currentTeachersStudets);
            }
        }

        public void Print()
        {
            _students = _studentManager.GetAll();
            _teachers = _teacherManager.GetAll();
            Console.WriteLine($"Group ");
            for (int i = 0; i < _teachers.Length; i++)
            {
                _teachers[i].Print();
            }

        }
    }
}
