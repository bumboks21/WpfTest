using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfTestUnit.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestUnit.Core.Tests
{
    [TestClass()]
    public class PcManagerTests
    {
        PcManager pcManager = new PcManager();
        [TestMethod()]
        public void LoadPcFeatureTest()
        {
            //Allert 
            int numberOfCups = 0;
            bool os64 = false;
            string expected = "The number of CPUs cannot be zero";
            //Act 
            var result = pcManager.LoadPcFeature(numberOfCups, os64);
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void LoadPcFeatureTest_Negative()
        {
            //Allert 
            int numberOfCups = -1;
            bool os64 = true;
            string expected = "An error occurred during data generation";
            //Act 
            var result = pcManager.LoadPcFeature(numberOfCups, os64);
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void LoadPcFeatureTest_Positive()
        {
            //Allert 
            int numberOfCups = 1;
            bool os64 = true;
            string expected = "PC data has been successfully generated";
            //Act 
            var result = pcManager.LoadPcFeature(numberOfCups, os64);
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void LoadPcFeatureTest_OS64()
        {
            //Allert 
            int numberOfCups = 19879;
            bool os64 = true;
            string expected = "PC data has been successfully generated";
            //Act 
            var result = pcManager.LoadPcFeature(numberOfCups, os64);
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void LoadPcFeatureTest_LongValue_NotLive()
        {
            //Allert 
            int numberOfCups = 666666;
            bool os64 = false;
            string expected = "An error occurred during data generation";
            //Act 
            var result = pcManager.LoadPcFeature(numberOfCups, os64);
            //Assert 
            Assert.AreEqual(expected, result);
        }
    }
}
    
