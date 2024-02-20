using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_InterfaceandIEnumerable_StephanieLopez
{
    internal class Student
    {
        string _FirstName;
        string _Lastname;

        public Student(string FirstName, string Lastname)
        {
            _FirstName = FirstName;
            _Lastname = Lastname;
        }

        public override string ToString()
        {
            return $"{_FirstName} {_Lastname}";
        }
    }
}
