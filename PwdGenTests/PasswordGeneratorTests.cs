using Microsoft.VisualStudio.TestTools.UnitTesting;
using PwdGen;
using System;
using System.Collections.Generic;
using System.Text;

namespace PwdGen.Tests
{
    [TestClass()]
    public class PasswordGeneratorTests
    {
        [TestMethod()]
        public void GetPwdLengthTest()
        {
            // arrange
            int pwdLength = 8;
            PasswordGenerator pg = new PasswordGenerator(8, true, true, true, true);
            // act
            string result = pg.GetPwd();

            // assert

            Assert.AreEqual(pwdLength, result.Length);
        }

        [TestMethod()]
        public void GetPwdSymbolTypeTest()
        {
            // arrange
            int pwdLength = 8;
            PasswordGenerator pg = new PasswordGenerator(8, true, true, true, true);
            // act
            string result = pg.GetPwd();


            // assert
            // TODO: vrem sa verificam ca parola primita contine toate categoriile de caractere pe care le-am cerut.
            //Assert.AreEqual();
        }

    }
}