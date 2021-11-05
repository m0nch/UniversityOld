﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student
    {
        public Guid _id;
        public string _name;
        public int _age;
        Teacher _teacher;
        public Student(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
        }

        public void AssignTeacher(Teacher teacher)
        {
            _teacher = teacher;
        }
        public void Print()
        {
            Console.WriteLine($"Name -- {_name} age -- {_age}");
        }
    }
}
