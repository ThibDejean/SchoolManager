using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SchoolManager
{
    public class ClassRoom
    {
        Teacher _classRoomTeacher;
        int _numberOfEmptySeat;
        int _numberOfStudent;

        #region getter and setter
        public Teacher ClasseRoomTeacher
        {
            get { return _classRoomTeacher; }
        }

        public int NumberOfEmptySeat
        {
            get { return _numberOfEmptySeat; }
        }
        public int NumberOfStudent
        {
            get { return _numberOfStudent; }
        }
        #endregion

        public ClassRoom(int seat, int student, Teacher classTeacher)
        {
            _numberOfEmptySeat = seat;
            _numberOfStudent = student;
            _classRoomTeacher = classTeacher;
        }

        public void ModifyClass(int seat, int student, Teacher classTeacher)
        {
            _numberOfEmptySeat = seat;
            _numberOfStudent = student;
            _classRoomTeacher = classTeacher;
        }
    }
}
