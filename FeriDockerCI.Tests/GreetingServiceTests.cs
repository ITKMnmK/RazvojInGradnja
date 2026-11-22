using Microsoft.VisualStudio.TestTools.UnitTesting;
using FeriDockerCI;

namespace FeriDockerCI.Tests
{
    [TestClass]
    public class GreetingServiceTests
    {
        [TestMethod]
        public void Test_GetGreeting_WithName()
        {
            GreetingService service = new GreetingService();

            string result = service.GetGreeting("Milan");

            Assert.AreEqual("Pozdravljen, Milan!", result);
        }

        [TestMethod]
        public void Test_GetGreeting_WithEmptyName()
        {
            GreetingService service = new GreetingService();

            string result = service.GetGreeting("");

            Assert.AreEqual("Pozdravljen, uporabnik!", result);
        }

        [TestMethod]
        public void Test_GetGreeting_WithNullName()
        {
            GreetingService service = new GreetingService();

            string result = service.GetGreeting(null);

            Assert.AreEqual("Pozdravljen, uporabnik!", result);
        }

        [TestMethod]
        public void Test_GetGreeting_WithWhitespace()
        {
            GreetingService service = new GreetingService();

            string result = service.GetGreeting("   ");

            Assert.AreEqual("Pozdravljen, uporabnik!", result);
        }

        [TestMethod]
        public void Test_GetGreeting_TrimsWhitespace()
        {
            GreetingService service = new GreetingService();

            string result = service.GetGreeting(" Milan ");

            Assert.AreEqual("Pozdravljen, Milan!", result);
        }
    }
}
