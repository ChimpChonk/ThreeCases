using NUnit.Framework;
using ClassLibrary;
using System;


namespace ClassTest
{
    public class DanceTest
    {
        DanceLogic _danceTest;
        DanceLogic _danceTest2;
        DanceLogic _danceTest3;

        [SetUp]
        public void Setup()
        {
            _danceTest = new DanceLogic("Dennish", 20);
            _danceTest2 = new DanceLogic("Tonmmy", 15);
        }

        [Test]

        public void FirstDancer_NameAndScore_Test()
        {
            _danceTest3 = _danceTest + _danceTest2;

            var result = _danceTest3.Name + ": " + _danceTest3.Score;
            Assert.AreEqual("Dennish & Tonmmy: 35", result);
        }
    }
}
