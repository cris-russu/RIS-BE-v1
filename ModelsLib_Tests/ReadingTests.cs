using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelsLib;

namespace ModelsLib_Tests
{
    [TestClass]
    public class ReadingTests
    {
        [TestMethod]
        public void GetReadingDateTest1()
        {
            //Arrange
            ChemicalReading reading = new ChemicalReading();
            DateTime testDate = DateTime.Now;
            reading.Time_stamp = testDate;
            string expectedRes = "10/7/2019";

            //Act
            string result = reading.GetReadingDate();

            //Assert
            Equals(expectedRes, result);
        }

        [TestMethod]
        public void GetReadingDateTest2()
        {
            //Arrange
            ChemicalReading reading = new ChemicalReading();
            DateTime testDate = DateTime.Now;
            reading.Time_stamp = testDate;
            string expectedRes = "11/7/2019";

            //Act
            string result = reading.GetReadingDate();

            //Assert
            Assert.IsFalse(string.Equals(expectedRes, result));
        }

        [TestMethod]
        public void GetReadingTimeTest1()
        {
            //Arrange
            ChemicalReading reading = new ChemicalReading();
            DateTime date = DateTime.Parse("2019-07-10 15:30:22");
            reading.Time_stamp = date; 
            string expected = "15:30:22";

            //Act
            string actual = reading.GetReadingTime();

            //Assert
            Equals(expected, actual); 
        }

        [TestMethod]
        public void GetReadingTimeTest2()
        {
            //Arrange
            ChemicalReading reading = new ChemicalReading();
            DateTime date = DateTime.Parse("2019-07-10 15:30:22");
            reading.Time_stamp = date;
            string expected = "14:30:22";

            //Act
            string actual = reading.GetReadingTime();

            //Assert
            Assert.IsFalse(string.Equals(expected, actual));
        }

        [TestMethod]
        public void GetAtmReadingTest1()
        {
            //Arrange
            AtmosphericReading reading = new AtmosphericReading();
            DateTime date = DateTime.Parse("2019-07-10 15:30:22");
            reading.Time_stamp = date;
            string expected = "14:30:22";

            //Act
            string actual = reading.GetReadingTime();

            //Assert
            Assert.IsFalse(string.Equals(expected, actual));
        }

    }
}
