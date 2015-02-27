using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SchoolManager
{
    public class School
    {
        List<ClassRoom> _classRoomList;
        string _schoolName;

        public List<ClassRoom> ClassRoomList
        {
            get { return _classRoomList; }
        }

        public string SchoolName
        {
            get { return _schoolName; }
        }
    }
}
