using NUnit.Framework;
using ClassLibrary;
using System;


namespace ClassTest
{
    public class PasswordTest
    {
        PasswordCheckLogic _passwordTest;

        [SetUp]
        public void Setup()
        {
            _passwordTest = new PasswordCheckLogic();
        }

        [Test]
        public void PasswordCheck_Length_Test()
        {
            var result = _passwordTest.PasswordChecked(password:"hfsjfhjsf");
            Assert.AreEqual(false, result);
        }

        [Test]
        public void PassowrdCheck_StrongPassword_Test()
        {
            var result = _passwordTest.PasswordChecked(password: "J3gCykl3rDagen&Natt3Lang");
            Assert.AreEqual(true, result);
        }

        [Test]

        public void PassowrdCheck_WeekPassword_Test()
        {
            var result = _passwordTest.PasswordChecked(password: "JgCyklrDagensfsfNattLang");
            Assert.AreEqual(false, result);
        }
    }
}
