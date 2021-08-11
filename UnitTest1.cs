using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestClient;

namespace UnitTestcalculate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange  --- variables and provide values

            int num = 20;
            int deno = 4;
            int expectedresult = 4;


            // Act ------  call the function to test

            Program p = new Program();
           int actualResult= p.divide(num, deno);

            //Assert  ----  getting the result

            Assert.AreEqual(expectedresult, actualResult);

        }
    }
}
