using NUnit.Framework;

namespace NUnitTestProjectWithGit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Description("The first test in new branch feature/firstUser")]
        public void Test1()
        {

            Assert.Pass();
        }
        [Test]
        [Description("The second test in new branch feature/firstUser")]
        public void Test2()
        {

            Assert.Pass();
        }
    }
}