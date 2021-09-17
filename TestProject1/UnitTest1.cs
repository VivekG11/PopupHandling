using NUnit.Framework;
using log4netSample;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            logging.testAlertPopup();
        }
    }
}