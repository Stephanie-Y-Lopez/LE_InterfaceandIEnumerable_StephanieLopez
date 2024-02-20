using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_InterfaceandIEnumerable_StephanieLopez
{
    internal class ClassRoster : IEnumerable
    {
        //Field
        List<Student> _students = new List<Student>();

        public List<Student> Students
        {
            get => _students;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void AddStudent(string firstName, string lastName)
        {
            _students.Add(new Student(firstName, lastName));
        }

        public IEnumerator GetEnumerator()
        {
            return new ClassRosterInternal(ref _students);
        }

        //Internal class
        private class ClassRosterInternal : IEnumerator
        {
            int index = -1;

            List<Student> Students;

            //Constructor
            public ClassRosterInternal(ref List<Student> students)
            {
                Students = students;
            }

            public object Current => Students[index];

            public bool MoveNext()
            {
                index++;

                if (index >= Students.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
