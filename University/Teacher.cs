using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Teacher
    {
        public Guid _id;
        public string _name;
        public int _age;
        Student[] _students;

        public Teacher(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
        }

        public void AssignStudents(Student[] students)
        {
            _students = students;
        }

        public void Print()
        {
            Console.WriteLine($"Teacher -- {_name} age -- {_age} ");
            Console.WriteLine("Students list");
            for (int i = 0; i < _students.Length; i++)
            {
                _students[i].Print();
            }
        }

    }
}
