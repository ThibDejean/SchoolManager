using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SchoolManager.Tests
{
    [TestFixture]
    public class ClassRoomTests
    {
        [Test]
        public void Constructor_test()
        {
            ClassRoom classroom = new ClassRoom(3, 18, new Teacher("Jean", "Dupond", true));
            int nbSeat = classroom.NumberOfEmptySeat;
            int nbStudent = classroom.NumberOfStudent;
            Teacher toto = classroom.ClasseRoomTeacher;
            Assert.That(nbSeat, Is.EqualTo(3));
            Assert.That(nbStudent, Is.EqualTo(18));
            Assert.That(toto.FirstName, Is.EqualTo("Jean"));
            Assert.That(toto.LastName, Is.EqualTo("Dupond"));
            Assert.That(toto.IsPresent, Is.True);
        }

        [Test]
        public void Modify_classroom()
        {
            ClassRoom classroom = new ClassRoom(3, 18, new Teacher("Jean", "Dupond", true));
            Teacher jojo = new Teacher("Jeanne", "Pouet", true);
            classroom.ModifyClass(4, 17, jojo);
            int nbSeat = classroom.NumberOfEmptySeat;
            int nbStudent = classroom.NumberOfStudent;
            Teacher toto = classroom.ClasseRoomTeacher;
            Assert.That(nbSeat, Is.EqualTo(4));
            Assert.That(nbStudent, Is.EqualTo(17));
            Assert.That(toto.FirstName, Is.EqualTo("Jeanne"));
            Assert.That(toto.LastName, Is.EqualTo("Pouet"));
            Assert.That(toto.IsPresent, Is.True);
        }
    }
}
