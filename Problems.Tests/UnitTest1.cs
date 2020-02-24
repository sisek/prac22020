using NUnit.Framework;

namespace Problems.Tests
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
            string kk = new Program;
            string atput = kk.Prefix("hello")

            Assert.Pass(atput,"5,1 :hello");
        }
        [Test]
        public void Test2()
        {
            string kk = new Program;
            string atput = kk.Prefix("")

            Assert.Pass(atput,"0,0");

    }
    [Test]
        public void Test3()
        {
            string kk = new Program;
            string atput = kk.Prefix("what ... did you say")

            Assert.Pass(atput,"27,5");
}