using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestIllegalChars.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            var a = 1+1;
            Assert.AreEqual(a, 2);
        }
    }
}
