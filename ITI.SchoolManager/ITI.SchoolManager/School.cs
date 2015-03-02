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

        #region
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
        #endregion
        public School()
        {

        }
      
        public void SaveSchool(School toto)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(School));

            System.IO.StreamWriter file = new System.IO.StreamWriter(
                     @"d:\Dev\ITI-PF\SchoolManagerITI\SerializationOverview.xml");
            writer.Serialize(file, toto);
            file.Close();
        }

        public School LoadSchool()
        {
            // TODO
            //string backupName = Path.ChangeExtension(FileName, ".old");

            //    if (File.Exists(backupName))

            System.Xml.Serialization.XmlSerializer reader =
        new System.Xml.Serialization.XmlSerializer(typeof(School));

            System.IO.StreamReader file = new System.IO.StreamReader(
                @"d:\Dev\ITI-PF\SchoolManagerITI\SerializationOverview.xml");
            School toto = new School();
            toto = (School)reader.Deserialize(file);
            file.Close();

            return toto;
        }
    }
}
