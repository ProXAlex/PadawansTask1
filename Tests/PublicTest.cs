using NUnit.Framework;

namespace PadawansTask1.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [Test]
        public void GetYearsTest_With_Result_15()
        {
            Assert.AreEqual(Population.GetYears(50, 1, 0, 5000), 15);
        }
    }
}