
using csharp_fundamentals_class_members_exemplar.Main;
using NUnit.Framework;

namespace csharp_fundamentals_class_members.Test
{
    public class CoreTests
    {
        Core _core;


        public CoreTests()
        {
            this._core = new Core();
        }

        [Test]
        public void shouldAnswerTheUltimateQuestion()
        {
            Assert.AreEqual(42, this._core.answerToTheUltimateQuestion);
        }

        [Test]
        public void shouldBeAged32()
        {
            Assert.AreEqual(32, this._core.age);
        }

        [Test]
        public void shouldBeNamedJane()
        {
            Assert.AreEqual("Jane", this._core.firstName);
        }

        [Test]
        public void shouldBeAProgrammer()
        {
            Assert.IsTrue(this._core.isProgrammer);
        }

        [Test]
        public void firstNumberShouldBe9182()
        {
            Assert.AreEqual(9182, this._core.firstNumber);
        }

        [Test]
        public void firstStringShouldBeSpecific()
        {
            Assert.AreEqual("She sells C# on the sea shore", this._core.firstString);
        }

        [Test]
        public void isVisibleShouldBePublic()
        {
            
            Assert.IsTrue(this._core.isVisible);
        }
    }
}