using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class TeacherManager
    {
        Teacher[] _teachers;
        public TeacherManager(int count)
        {
            Random rnd = new Random();
            _teachers = new Teacher[count];

            for (int i = 0; i < count; i++)
            {
                string name = "Teacher" + (i + 1);
                int age = rnd.Next(25, 65);

                Teacher teacher = new Teacher(name, age);
                _teachers[i] = teacher;
            }
        }

        public Teacher[] GetAll()
        {
            return _teachers;
        }
    }
}
