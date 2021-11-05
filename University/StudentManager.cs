using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class StudentManager
    {
        Student[] _students; 
        public StudentManager(int count)
        {
            Random rnd = new Random();
            _students = new Student[count];

            for (int i = 0; i < count; i++)
            {
                string name = "Name" + (i + 1);
                int age = rnd.Next(16, 22);

                Student student = new Student(name, age);
                _students[i] = student;
            }
        }

        public Student[] GetAll()
        {
            return _students;
        }
    }
}
