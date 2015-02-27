using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SchoolManager.Tests
{
    [TestFixture]
    public class TeacherTests
    {

        [Test]
        public void Teacher_is_well_created()
        {
            Teacher tot = new Teacher("Paul", "Dupond", true);
            string firstName = tot.FirstName;
            string lastName = tot.LastName;
            bool present = tot.IsPresent;
            Assert.That(firstName, Is.EqualTo("Paul"));
            Assert.That(lastName, Is.EqualTo("Dupond"));
            Assert.That(present, Is.True);            
        }

        //[Test]
        //public void Teacher_Constructor_with_null_or_whitespace_firstName_throws_ArgumentException()
        //{
        //    Assert.Throws<ArgumentException>(() => new Teacher(null, "Dupond", true));
        //    Assert.Throws<ArgumentException>(() => new Teacher("  ", "Dupond", true));
        //    Assert.Throws<ArgumentException>(() => new Teacher("Jean", "  ", true));
        //    Assert.Throws<ArgumentException>(() => new Teacher("Jean", null, true));
        //}

        [Test]
        public void Teacher_goes_absent_when_methode_is_call()
        {
            Teacher toto = new Teacher("Jean", "Dupond", true);
            toto.SetTeacherPresence();
            bool result = toto.IsPresent;
            Assert.That(result, Is.False);
        }
    }
}
