using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCI.Web.UnitTests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestPassMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
        
         [Test]
        public void TestOtherPassMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your 2nd passing test");
        }

        [Test]
        public void TestWarningMethod()
        {
            // TODO: Add your test code here
            Assert.Warn("Your first passing test");
        }

        [Test]
        public void TestFailMethod()
        {
            // TODO: Add your test code here
            Assert.Fail("Your first passing test");
        }
    }
}
