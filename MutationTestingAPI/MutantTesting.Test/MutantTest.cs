using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanTesting;
using MutantTesting;
using NUnit.Framework;
using Shouldly;

namespace MutantTesting.Test
{
    [TestFixture]
    public class MutantTest
    {
        [Test]
        public void CanCommunicateWithHuman_WhenSameLanguage_ReturnsTrue()
        {
            var human = new Human {Language = "a"};
            var mutant = new Mutant { Language = "a" };

            mutant.CanCommunicateWithHuman(human).ShouldBeTrue();
        }
    }
}
