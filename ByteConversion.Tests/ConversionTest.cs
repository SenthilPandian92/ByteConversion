using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ByteConversion;

namespace ByteConversion.Tests
{
    [TestFixture]
    public class ConversionTest
    {
        [Test]
        public Conversion_MegabyteToBytesTest()
        {
            //Arrange
            Conversion number = new Conversion(1);
            //Act
            number.MegabyteToBytes();
            //Assert
            Assert.AreEqual(1,048,576, MegabyteToBytes());

        }

        [Test]
        public Conversion_GigabyteToMegaBytesTest()
        {
            //Arrange
            Conversion number1 = new Conversion(1);
            //Act
            number1.GigabyteToMegaBytes();
            //Assert
            Assert.AreEqual(1024, GigabyteToMegaBytes());

        }

        [Test]
        public Conversion_TerabyteToGigaBytes()
        {
            //Arrange
            Conversion number2 = new Conversion(1);
            //Act
            number2.TerabyteToGigaBytes();
            //Assert
            Assert.AreEqual(1024, TerabyteToGigaBytes());

        }

        [Test]
        public Conversion_MegabyteToBytesTest()
        {
            //Arrange
            Conversion number3 = new Conversion(2);
            //Act
            number3.MegabyteToBytes();
            //Assert
            Assert.AreEqual(2097152, MegabyteToBytes());

        }

        [Test]
        public Conversion_TerabyteToGigaBytes()
        {
            //Arrange
            Conversion number4 = new Conversion(3);
            //Act
            number4.TerabyteToGigaBytes();
            //Assert
            Assert.AreEqual(3072, TerabyteToGigaBytes());

        }

    }
}
