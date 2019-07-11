
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelsLib;

namespace ModelsLib_Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TelegramTests
    {
       

        [TestMethod]
        public void ConvertToJSONTest()
        {
            //Arrange
            Telegram tlgr = new Telegram()
            {
                ack = true,
                eui = "0102030405060708",
                ts = 1470850675433,
                fnct = 1,
                port = 1,
                data = "0ABA12B3BB0200AF0C",
                freq = 868500000,
                rssi = -130,
                snr = 1.3
            };
            string expected = "{ \"cmd\":\"rx\",\"eui\":\"0102030405060708\",\"ts\":1470850675433,\"ack\":true,\"fnct\":1,\"port\":1,\"data\":\"0ABA12B3BB0200AF0C\",\"freq\":868500000,\"rssi\":-130,\"snr\":1.3}";

            //Act
            string actual = tlgr.ConvertToJson();

            //Assert
            Equals(expected, actual);
        }

        [TestMethod]
        public void ConvertToTelegramTest()
        {
            //Arrange
            
            string jsonString = "{ \"cmd\":\"rx\",\"eui\":\"0102030405060708\",\"ts\":1470850675433,\"ack\":true,\"fnct\":1,\"port\":1,\"data\":\"0ABA12B3BB0200AF0C\",\"freq\":868500000,\"rssi\":-130,\"snr\":1.3}";
            string expectedEUI = "0102030405060708";
            //Act
            Telegram actual = new Telegram().GetTelegram(jsonString);

            //Assert
            Equals(expectedEUI, actual.eui); 
        }
    }
}
