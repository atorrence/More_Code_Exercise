using Microsoft.VisualStudio.TestTools.UnitTesting;
using More_Code_Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Code_Exercises.Tests
{
    [TestClass()]
    public class VowelCountTests
    {
        [TestMethod()]
        public void GetVowelCountTest()
        {

            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"));

        }
    }
}