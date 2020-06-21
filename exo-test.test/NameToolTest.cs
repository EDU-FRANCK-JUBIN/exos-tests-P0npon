using System;
using exo_tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exo_test.test
{
    [TestClass]
    public class NameToolTest
    {
        [TestMethod]
        public void EasyTest()
        {
            string initiale = NameTool.extractInitials("John", "Tolkien");
            Assert.AreEqual(initiale, "J T");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullParametersTest()
        {
            NameTool.extractInitials(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullFirstName()
        {
            NameTool.extractInitials(null, "Tolkien");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullLastName()
        {
            NameTool.extractInitials("John", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidsParametersTest()
        {
            NameTool.extractInitials("John1", "Tolkien3");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidsFirstName()
        {
            NameTool.extractInitials("John1", "Tolkien");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidsLastName()
        {
            NameTool.extractInitials("John", "Tolkien1");
        }

        [TestMethod]
        public void MultipleFirstName()
        {
            string initiale = NameTool.extractInitials("John Ronald Reuel", "Tolkien");
            Assert.AreEqual(initiale, "JRR T");
        }

        [TestMethod]
        public void MultipleLastName()
        {
            string initiale = NameTool.extractInitials("John", "Tolkien Saquet");
            Assert.AreEqual(initiale, "J TS");
        }

        [TestMethod]
        public void ConvertUppercaseTest()
        {
            string initiale = NameTool.extractInitials("john", "tolkien");
            Assert.AreEqual(initiale, "J T");
        }
    }
}
