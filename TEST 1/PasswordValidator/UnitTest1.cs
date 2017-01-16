using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordValidator
{
    [TestClass]
    public class UnitTest1
    {
        private bool ConstructAndExecute(string password,string type)
        {
            Password_Validator pswd = new Password_Validator();
            bool result = pswd.Verify(password,type);
            return result;
        }
        [TestMethod, ExpectedException(typeof(InvalidProgramException))]
        public void GivingNull_VerifyingIt_ShouldThrowException()
        {
            bool result = ConstructAndExecute("","ex");            
        }
        [TestMethod, ExpectedException(typeof(InvalidProgramException))]
        public void GivingLessThanEightChars_VerifyingIt_ShouldThrowException()
        {
            bool result = ConstructAndExecute("acbde", "ex");
        }
        [TestMethod, ExpectedException(typeof(InvalidProgramException))]
        public void GivingNoUpperCaseChars_VerifyingIt_ShouldThrowException()
        {
            bool result = ConstructAndExecute("aa","ex");
        }
        [TestMethod, ExpectedException(typeof(InvalidProgramException))]
        public void GivingNoLowerCaseChars_VerifyingIt_ShouldThrowException()
        {
            bool result = ConstructAndExecute("aa", "ex");
        }

        [TestMethod, ExpectedException(typeof(InvalidProgramException))]
        public void GivingNoDigits_VerifyingIt_ShouldThrowException()
        {
            bool result = ConstructAndExecute("a", "ex");
        }

        [TestMethod]
        public void SatisifyingFeature2_VerifyingIt_ShouldPassTheTest()
        {
            bool result = ConstructAndExecute("A1","ex");
            Assert.AreEqual(true,result,"Incorrect Result");
        }
        [TestMethod]
        public void SatisifyingFeature3_VerifyingIt_ShouldPassTheTest()
        {
            bool result = ConstructAndExecute("aefghI","ex");
            Assert.AreEqual(true, result, "Incorrect Result");
        }
        [TestMethod]
        public void PerformingInternalPasswordCheck_VerifyingIt_ShouldPassTheTest()
        {
            bool result = ConstructAndExecute("abcdefghi", "in");
            Assert.AreEqual(true, result, "Incorrect Result");
        }
    }
}
