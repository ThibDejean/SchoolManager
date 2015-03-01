using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SchoolManager
{
    public class Teacher
    {
        string _firstName;
        string _lastName;
        bool _isPresent;

        #region getter and setter
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }

        }
        public bool IsPresent
        {
            get { return _isPresent; }
            set { _isPresent = value; }

        }
        #endregion

        public Teacher(string firstName, string lastName, bool present)
        {
            //if(string.IsNullOrWhiteSpace(firstName))
            //{
            //    throw new ArgumentException("first name must not be null or whitespace", " firstName");
            //}
            //if(string.IsNullOrWhiteSpace(lastName))
            //{
            //    throw new ArgumentException("first name must not be null or whitespace", "lastName");
            //}
            _firstName = firstName;
            _lastName = lastName;
            _isPresent = present;
        }

        public Teacher()
        {

        }



        public void SetTeacherPresence()
        {
            _isPresent = !_isPresent;
        }
    }
}
