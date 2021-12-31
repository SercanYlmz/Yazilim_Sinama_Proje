using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Client;

namespace ChatProgramTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanInstantiate()
        {
            sha sha = new sha();  
        }
        [TestMethod]
        public void ByteArrayToHexStringTest()
        {
            sha sha = new sha();
        }
    }
}
