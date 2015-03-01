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
        string _classroomName;

        #region getter and setter
        public Teacher ClasseRoomTeacher
        {
            get { return _classRoomTeacher; }
            set { _classRoomTeacher = value; }
        }

        public int NumberOfEmptySeat
        {
            get { return _numberOfEmptySeat; }
            set { _numberOfEmptySeat = value; }

        }
        public int NumberOfStudent
        {
            get { return _numberOfStudent; }
            set { _numberOfStudent = value; }

        }

        public string ClassRoomName
        {
            get { return _classroomName; }
            set { _classroomName = value; }

        }
        #endregion

        public ClassRoom()
        {

        }
        public ClassRoom(int seat, int student, Teacher classTeacher, string classroomName)
        {
            _numberOfEmptySeat = seat;
            _numberOfStudent = student;
            _classRoomTeacher = classTeacher;
            _classroomName = classroomName;
        }

        public void ModifyClass(int seat, int student, Teacher classTeacher, string classroomName)
        {
            _numberOfEmptySeat = seat;
            _numberOfStudent = student;
            _classRoomTeacher = classTeacher;
            _classroomName = classroomName;
        }
    }
}
