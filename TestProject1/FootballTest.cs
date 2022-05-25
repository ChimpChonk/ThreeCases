using NUnit.Framework;
using ClassLibrary;
using System;

namespace TestProject1
{
    public class Tests
    {
        FootBallLogic _football;

        [SetUp]
        public void Setup()
        {
            _football = new FootBallLogic();

        }

        [Test]
        public void ThePasses_PassIsZero_Shh_Test()
        {

            var result = _football.ThePasses(0);

            Assert.AreEqual("Shhh", result);
        }

        [Test]

        public void ThePasses_PassIsThree_Huh_test()
        {

            var result = _football.ThePasses(3);

            Assert.AreEqual("Huh! Huh! Huh!", result);
        }

        [Test]
        public void ThePasses_PassIsNegative_error_test()
        {
            var result = _football.ThePasses(-1);

            Assert.AreEqual("OOPS looks like you are playing backwards", result);
        }

        [Test]
        public void ThePasses_PassIsTen_HighFive_test()
        {
            var result = _football.ThePasses(10);

            Assert.AreEqual("High Five - Jubel!!!", result);
        }

        [Test]

        public void CheerGoal_GoalIsYes_Test()
        {
            var result = _football.CheerGoal("yes");

            Assert.AreEqual("Olé olé olé", result);
        }

        [Test]

        public void CheerGoal_GoalIsYesOrPass_Test()
        {
            var result = _football.CheerGoalOrPass("yes", 4);

            Assert.AreEqual("Olé olé olé", result);
        }
    }
}