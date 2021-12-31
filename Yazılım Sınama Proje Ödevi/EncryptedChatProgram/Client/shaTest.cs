using NUnit.Framework;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [TestFixture]
    class shaTest
    {
        sha sha256 = new sha();

        [Test]
        public void ByteArrayToHexStringTest()
        {
            sha sha256 = new sha();
            //string sonuc = sha.ByteArrayToHexString({ 0, 0, 0, 25});

        }

        [Test]
        public void HexStringToByteArrayTest()
        {
            sha sha256 = new sha();
            byte[] test = sha.HexStringToByteArray("selam");
        }


    }
}
