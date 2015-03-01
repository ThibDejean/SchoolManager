using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SchoolManager.Tests
{
    [TestFixture]
    public class SchoolTests
    {
        [Test]
        public void SchoolTest()
        {
            School myschool = new School();
            Teacher toto = new Teacher("Jean", "dupond", true);
            ClassRoom myclassroom = new ClassRoom(5, 18, toto, "CP");
            myschool.ClassRoomList.Add(myclassroom);
            Assert.That(myschool.ClassRoomList[0], Is.EqualTo(myclassroom));
            
        }
    }
}
