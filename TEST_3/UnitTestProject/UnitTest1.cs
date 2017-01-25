using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TEST_3;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod, ExpectedException(typeof(InvalidProgramException))]
        public void TestMethod1()
        {
            VerifyDetails verify = new VerifyDetails();
            bool result = verify.Verify("", "", "");
            Assert.AreEqual(true, result, "Incorrect Result");
        }

        [TestMethod, ExpectedException(typeof(InvalidProgramException))]
        public void InvalidEmail()
        {
            VerifyDetails verify = new VerifyDetails();
            bool result = verify.Verify("a", "b", "c");
            Assert.AreEqual(true, result, "Incorrect Result");
        }

        [TestMethod, ExpectedException(typeof(InvalidProgramException))]
        public void FirstNameEmpty()
        {
            VerifyDetails verify = new VerifyDetails();
            bool result = verify.Verify("", "b", "a@gmail.com");
            Assert.AreEqual(true, result, "Incorrect Result");
        }

        [TestMethod, ExpectedException(typeof(InvalidProgramException))]
        public void LastNameEmpty()
        {
            VerifyDetails verify = new VerifyDetails();
            bool result = verify.Verify("a", "", "a@gmail.com");
            Assert.AreEqual(true, result, "Incorrect Result");
        }

        [TestMethod, ExpectedException(typeof(InvalidProgramException))]
        public void EmptyEmail()
        {
            VerifyDetails verify = new VerifyDetails();
            bool result = verify.Verify("a", "", "");
            Assert.AreEqual(true, result, "Incorrect Result");
        }

        [TestMethod]
        public void Valid()
        {
            VerifyDetails verify = new VerifyDetails();
            bool result = verify.Verify("a", "b", "a@gmail.com");
            Assert.AreEqual(true, result, "Incorrect Result");
        }
    }
}
