using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;



/// <summary>
///  Nabin Atreya Sunar
///  ID: C7202333
///  College: The British College
/// </summary>
/// 
namespace UnitTestProject1
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]

        
        public void Test_Moveto_Right_value()
        {
            var v = new CommandParser();
            string[] result = v.ValidationCheck("moveto 10 10", 1, 1);
            Assert.AreEqual(result[0], "moveto", result[1], "10", result[2], "10");

        }

       
        [TestMethod]
        public void Test_Drawto_Right_value()
        {
            var v = new CommandParser();
            string[] result = v.ValidationCheck("drawto 10 10", 1, 1);
            Assert.AreEqual(result[0], "drawto", result[1], "10", result[2], "10");

        }


        public void TestMethod1()
        {
        }
    }
}
