using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelsLib;

namespace ModelsLib_Tests
{
    [TestClass]
    public class PayloadHandlerTests
    {
        [TestMethod]
        public void SplitPayloadTest1()
        {
            // Arrange
            PayloadHandler pldlr = new PayloadHandler(); 
            pldlr.InitialString = "0ABA12B3BB0200AF0C";
            List<string> expectedList = new List<string> { "0A","BA","12","B3","BB","02","00","AF","0C"};

            // Act
            pldlr.SplitPayload();

            // Assert
            CollectionAssert.AreEqual(pldlr.KeyValueList, expectedList); 

        }

        [TestMethod]
        public void SetPayloadNumericValuesTest()
        {
            // Arrange
            PayloadHandler pldlr = new PayloadHandler
            {
                InitialString = "0ABA12B3BB0200AF0CBBA0"
            };
            ushort expectedTGS2602 = 2746;
            ushort expectedTGS2611 = 4787;
            ushort expectedTGS2620 = 47874;
            byte expectedBMEHumidity = 0;
            ushort expectedPressure = 44812;
            sbyte expectedTemperature = 128-187;
            byte expectedBMEAirQuality = 160; 

            // Act
            pldlr.SplitPayload();
            pldlr.SetPayloadNumericValues(); 

            // Assert
            Assert.AreEqual(pldlr.TGS2602Val, expectedTGS2602);
            Assert.AreEqual(pldlr.TGS2611Val, expectedTGS2611);
            Assert.AreEqual(pldlr.TGS2620Val, expectedTGS2620);
            Assert.AreEqual(pldlr.BMEHumidity, expectedBMEHumidity);
            Assert.AreEqual(pldlr.BMEPressure, expectedPressure);
            Assert.AreEqual(pldlr.BMETemperature, expectedTemperature);
            Assert.AreEqual(pldlr.BMEAirQuality, expectedBMEAirQuality);

        }

        [TestMethod]
        public void ConstructorWithTelegramTest()
        {
            // Arrange
            Telegram tlgr = new Telegram()
            {
                ack = true,
                eui = "0102030405060708",
                ts = 1470850675433,
                fnct = 1,
                port = 1,
                data = "0ABA12B3BB0200AF0CBBA0",
                freq = 868500000,
                rssi = -130,
                snr = 1.3
            };

            ushort expectedTGS2602 = 2746;
            ushort expectedTGS2611 = 4787;
            ushort expectedTGS2620 = 47874;
            ushort expectedPressure = 44812;
            byte expectedBMEHumidity = 0;
            sbyte expectedTemperature = 128 - 187;
            byte expectedBMEAirQuality = 160;

            // Act
            PayloadHandler pldlr = new PayloadHandler(tlgr);
            
            // Assert
            Assert.AreEqual(pldlr.TGS2602Val, expectedTGS2602);
            Assert.AreEqual(pldlr.TGS2611Val, expectedTGS2611);
            Assert.AreEqual(pldlr.TGS2620Val, expectedTGS2620);
            Assert.AreEqual(pldlr.BMEHumidity, expectedBMEHumidity);
            Assert.AreEqual(pldlr.BMEPressure, expectedPressure);
            Assert.AreEqual(pldlr.BMETemperature, expectedTemperature);
            Assert.AreEqual(pldlr.BMEAirQuality, expectedBMEAirQuality);

        }
    }
}
