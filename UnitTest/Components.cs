using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Full_Adder;
using Full_Adder.nodes;

namespace UnitTest
{
    [TestClass]
    public class Components
    {
        [TestMethod]
        public void AndComponentShouldBeTrue()
        {
            //Arrange
            var and = new AND();
            and.addInput(true);
            and.addInput(true);

            //Act
            var result = and.execute();

            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void AndComponentShouldBeFalse()
        {
            //Arrange
            var and = new AND();
            and.addInput(false);
            and.addInput(true);

            //Act
            var result = and.execute();

            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void NandComponentShouldBeFalse()
        {
            //Arrange
            var nand = new NAND();
            nand.addInput(true);
            nand.addInput(false);

            //Act
            var result = nand.execute();

            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void NandComponentShouldBeTrue()
        {
            //Arrange
            var nand = new NAND();
            nand.addInput(false);
            nand.addInput(false);

            //Act
            var result = nand.execute();

            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void NorComponentShouldBeTrue()
        {
            //Arrange
            var nor = new NOR();
            nor.addInput(false);
            nor.addInput(false);

            //Act
            var result = nor.execute();

            //Assert
            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void NorComponentShouldBeFalse()
        {
            //Arrange
            var nor = new NOR();
            nor.addInput(true);
            nor.addInput(true);

            //Act
            var result = nor.execute();

            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void NotComponentShouldBeFalse()
        {
            //Arrange
            var not = new NOT();
            not.addInput(true);

            //Act
            var result = not.execute();

            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void NotComponentShouldBeTrue()
        {
            //Arrange
            var not = new NOT();
            not.addInput(false);

            //Act
            var result = not.execute();

            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OrComponentShouldBeTrue()
        {
            //Arrange
            var or = new OR();
            or.addInput(false);
            or.addInput(true);

            //Act
            var result = or.execute();

            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OrComponentShouldBeFalse()
        {
            //Arrange
            var or = new OR();
            or.addInput(false);
            or.addInput(false);

            //Act
            var result = or.execute();

            //Assert
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void XorComponentShouldBeFalse()
        {
            //Arrange
            var xor = new OR();
            xor.addInput(false);
            xor.addInput(false);

            //Act
            var result = xor.execute();

            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void XorComponentShouldBeTrue()
        {
            //Arrange
            var xor = new OR();
            xor.addInput(true);
            xor.addInput(false);

            //Act
            var result = xor.execute();

            //Assert
            Assert.AreEqual(true, result);
        }


    }
}
