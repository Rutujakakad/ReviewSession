using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        
        public Program obj;
        [SetUp]
        public void Setup()
        {
            obj = new Program();
        }

        //[Test]
        public bool IsPrimeNo(int num, bool expected)
        { //arrange
            int x = 3;

            //act
            int result = obj.IsPrimeNo(x);

             //assert
            Assert.AreEqual(expected, true);
        }
    }
}