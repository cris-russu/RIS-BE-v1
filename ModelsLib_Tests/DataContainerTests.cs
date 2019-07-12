using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelsLib;

namespace ModelsLib_Tests
{
    public class AssertHelper
    {
        public static void HasEqualFieldValues<T>(T expected, T actual)
        {
            var failures = new List<string>();
            var fields = typeof(T).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (var field in fields)
            {
                var v1 = field.GetValue(expected);
                var v2 = field.GetValue(actual);
                if (v1 == null && v2 == null) continue;
                if (!v1.Equals(v2)) failures.Add(string.Format("{0}: Expected:<{1}> Actual:<{2}>", field.Name, v1, v2));
            }
            if (failures.Any())
                Assert.Fail("AssertHelper.HasEqualFieldValues failed. " + Environment.NewLine + string.Join(Environment.NewLine, failures));
        }
    }

    [TestClass]
    public class DataContainerTests
    {
        
        [TestMethod]
        //[ExpectedException(typeof(AssertFailedException))]
        public void ConstructorTest1()
        {
            // Arrange
            Telegram tlgr = new Telegram()
            {
                ack = true,
                eui = "0102030405060708",
                ts = 1562939501,
                fnct = 1,
                port = 1,
                data = "0ABA12B3BB0200AF0CBBA0",
                freq = 868500000,
                rssi = -130,
                snr = 1.3
            };

            DateTime expectedDT = Convert.ToDateTime("2019/07/12 15:51:41");
            string expectedEUI = "0102030405060708";
            ChemicalReading expectedTGS2602 = new ChemicalReading(expectedDT, 2746);
            ChemicalReading expectedTGS2611 = new ChemicalReading(expectedDT, 4787);
            ChemicalReading expectedTGS2620 = new ChemicalReading(expectedDT, 47874);
            AtmosphericReading expectedAtmosphericReading = new AtmosphericReading(expectedDT, 44812, 0, 128 - 187, 160);
            
            // Act
            DataContainer dc = new DataContainer(tlgr);

            // Assert
            Assert.AreEqual(expectedDT, dc.Timestamp);
            Equals(expectedEUI, dc.EUID);
            AssertHelper.HasEqualFieldValues(expectedTGS2602, dc.TGS2602Reading);
            AssertHelper.HasEqualFieldValues(expectedTGS2611, dc.TGS2611Reading);
            AssertHelper.HasEqualFieldValues(expectedTGS2620, dc.TGS2620Reading);
            AssertHelper.HasEqualFieldValues(expectedAtmosphericReading, dc.BME680Reading);

        }
    }
}
