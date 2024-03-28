using System.Text;

namespace ExampleProject
{
    public class ExampleTestCase
    {
        private StringBuilder sut;

        [SetUp]
        public void Setup()
        {
            sut = new StringBuilder();
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        }

        [Test]
        public void TestStringBuilderIsInitiallyEmpty()
        {
            Assert.AreEqual("", sut.ToString());
        }

        [Test]
        public void TestAppendingObjectsToStringBuilder()
        {
            sut.Append(1);
            sut.Append("a");
            sut.Append(2.3);
            sut.Append('b');
            sut.Append(false);
            Assert.AreEqual("1a2.3bFalse", sut.ToString());
        }
    }
}