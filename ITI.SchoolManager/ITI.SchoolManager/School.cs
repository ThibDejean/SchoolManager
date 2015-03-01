using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SchoolManager
{
    public class School
    {
        List<ClassRoom> _classRoomList = new List<ClassRoom>();
        string _schoolName;


        int _count = 0;
        public int CountClassRoom
        {
            get { return _count;}
            set { _count++; }
        }

        public List<ClassRoom> ClassRoomList
        {
            get { return _classRoomList; }
            set { _classRoomList = value; }
        }

        public string SchoolName
        {
            get { return _schoolName; }
            set { _schoolName = value; }
        }

        public School()
        {

        }
    }
}
