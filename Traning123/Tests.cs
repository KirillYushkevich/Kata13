using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Traning123
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void TestSimple()
        {
            Assert.AreEqual(Kata.addOrChangeUrlParameter("www.example.com", "key=value"), "www.example.com?key=value");
        }
        [Test]
        public void TestRemove()
        {
            Assert.AreEqual(Kata.addOrChangeUrlParameter("www.example.com?key=value", "key2=value2"), "www.example.com?key=value&key2=value2");
        }
        [Test]
        public void TestReplace()
        {
            Assert.AreEqual(Kata.addOrChangeUrlParameter("www.example.com?key=oldValue`", "key=newValue"), "www.example.com?key=newValue");
        }
    }
}
