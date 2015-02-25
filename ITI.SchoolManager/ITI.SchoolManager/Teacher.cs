using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SchoolManager
{
    class Teacher
    {
        string _firstName;
        string _lastName;
        bool _isPresent;

        public Teacher(string firstName, string LastName)
        {
            _firstName = firstName;
            _lastName = LastName;
            _isPresent = true;
        }

        public void SetTeacherPresence()
        {
            _isPresent = !_isPresent;
        }
    }
}
