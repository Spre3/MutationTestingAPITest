using NUnit.Framework;
using Shouldly;

namespace HumanTesting.Test
{
    [TestFixture]
    public class HumanTest
    {
        private const string FirstName = "Kavita";
        public const string LastName = "Rao";
        private const int Age = 25;

        [Test]
        public void Ctor_SetsPassedInValues()
        {
            var human = new Human(FirstName, LastName, 25);

            human.FirstName.ShouldBe(FirstName);
            human.LastName.ShouldBe(LastName);
            human.Age.ShouldBe(Age);
        }

        [Test]
        public void GetFullName_ReturnsFirstAndLastName()
        {
            var human = new Human { FirstName = FirstName, LastName = LastName};

            human.GetFullName().ShouldBe(FirstName + LastName);
        }

        [Test]
        public void CanBeGivenAbilities_ReturnsFalseForOver24()
        {
            var human = new Human { Age = 25 };

            human.CanBeGivenAbilities().ShouldBeFalse();
        }
    }
}
