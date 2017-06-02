using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MixedSolution
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void testTrue()
        {
            Assert.IsTrue(true);
        }
    }
}
