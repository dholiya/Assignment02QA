using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment02QA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02QA.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        //Unit test case #1
        [TestMethod()]
        public void GetLengthTest_1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(1, 1, 1);
            //Act
            int output = rectangle.GetLength();
            //Assert
            Assert.AreEqual(output, 1);
        }

        //Unit test case #2
        [TestMethod()]
        public void SetLengthTest_1()
        {
            Rectangle rectangle = new Rectangle(); 
            int output = rectangle.SetLength(1);
            Assert.IsTrue(output==1);
        }

        //Unit test case #3
        [TestMethod()]
        public void GetWidthTest_1()
        {
            Rectangle rectangle = new Rectangle(); 
            int output = rectangle.GetWidth();
            Assert.AreEqual(output, 1);
        }

        //Unit test case #4
        [TestMethod()]
        public void SetWidthTest_1()
        {
            Rectangle rectangle = new Rectangle(); 
            int output = rectangle.SetWidth(1);
            Assert.IsTrue(output == 1);
        }


        //Unit test case #5
        [TestMethod()]
        public void GetHeightTest_1()
        {
            Rectangle rectangle = new Rectangle();
            int output = rectangle.GetHeight();
            Assert.AreEqual(output, 1);
        }


        //Unit test case #6
        [TestMethod()]
        public void SetHeightTest_1()
        {
            Rectangle rectangle = new Rectangle();
            int output = rectangle.SetHeight(1);
            Assert.AreEqual(output, 1);
        }


        //Unit test case #7
        [TestMethod()]
        public void GetVolumeTest_1()
        {
            Rectangle rectangle = new Rectangle();
            int output = rectangle.GetVolume();
            Assert.AreEqual(output, 1);
        }



        //Unit test case #8
        [TestMethod()]
        public void GetLengthTest_2_3_4()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(2, 3, 4);
            //Act
            int output = rectangle.GetLength();
            //Assert
            Assert.AreEqual(output, 2);
        }

        //Unit test case #9
        [TestMethod()]
        public void SetLengthTest_8()
        {
            Rectangle rectangle = new Rectangle();
            int output = rectangle.SetLength(8);
            Assert.IsTrue(output == 8);
        }

        //Unit test case #10
        [TestMethod()]
        public void GetWidthTest_11_9_8()
        {
            Rectangle rectangle = new Rectangle(11,9,8);
            int output = rectangle.GetWidth();
            Assert.AreEqual(output, 9);
        }

        //Unit test case #11
        [TestMethod()]
        public void SetWidthTest_12()
        {
            Rectangle rectangle = new Rectangle();
            int output = rectangle.SetWidth(12);
            Assert.AreEqual(output, 12);
        }


        //Unit test case #12
        [TestMethod()]
        public void GetHeightTest_8_2_13()
        {
            Rectangle rectangle = new Rectangle(8,2,13);
            int output = rectangle.GetHeight();
            Assert.AreEqual(output, 13);
        }


        //Unit test case #13
        [TestMethod()]
        public void SetHeightTest_55()
        {
            Rectangle rectangle = new Rectangle();
            int output = rectangle.SetHeight(55);
            Assert.AreEqual(output, 55);
        }


        //Unit test case #14
        [TestMethod()]
        public void GetVolumeTest_5_5_10()
        {
            Rectangle rectangle = new Rectangle(5,5,10);
            int output = rectangle.GetVolume();
            Assert.AreEqual(output, 250);
        }


        //Unit test case #15
        [TestMethod()]
        public void GetLengthTest_19_25_30()
        {
            Rectangle rectangle = new Rectangle(19, 25, 30);
            int output = rectangle.GetLength();
            Assert.AreEqual(output, 19);
        }

        //Unit test case #16
        [TestMethod()]
        public void SetLengthTest_23()
        {
            Rectangle rectangle = new Rectangle();
            int output = rectangle.SetLength(23);
            Assert.IsTrue(output == 23);
        }

        //Unit test case #17
        [TestMethod()]
        public void GetWidthTest_8_19_30()
        {
            Rectangle rectangle = new Rectangle(8,19,30);
            int output = rectangle.GetWidth();
            Assert.AreEqual(output, 19);
        }

        //Unit test case #18
        [TestMethod()]
        public void SetWidthTest_50()
        {
            Rectangle rectangle = new Rectangle();
            int output = rectangle.SetWidth(50);
            Assert.AreEqual(output, 50);
        }


        //Unit test case #19
        [TestMethod()]
        public void GetHeightTest_8_69_72()
        {
            Rectangle rectangle = new Rectangle(8,69,72);
            int output = rectangle.GetHeight();
            Assert.AreEqual(output, 72);
        }


        //Unit test case #20
        [TestMethod()]
        public void SetHeightTest_526()
        {
            Rectangle rectangle = new Rectangle();
            int output = rectangle.SetHeight(526);
            Assert.AreEqual(output, 526);
        }


        //Unit test case #21
        [TestMethod()]
        public void GetVolumeTest_81_28_55()
        {
            Rectangle rectangle = new Rectangle(81,28,55);
            int output = rectangle.GetVolume();
            Assert.AreEqual(output, 124740);
        }


    }
}