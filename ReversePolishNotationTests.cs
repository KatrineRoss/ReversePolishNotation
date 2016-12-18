using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReversePolishNotationLib;

namespace ReversePolishNotationTests
{
    [TestClass]
    public class ReversePolishNotationTests
    {
        [TestMethod]
        public void RPN_5plus3_53plus()
        {
            string expression = "5+3";
            string expected = "53+";

            ReversePolishNotation r = new ReversePolishNotation();
            string actual = r.RPN(expression);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RPN_5xI3plus6I_536plusx()
        {
            string expression = "5*(3+6)";
            string expected = "536+*";

            ReversePolishNotation r = new ReversePolishNotation();
            string actual = r.RPN(expression);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void RPN_4minus3x7plus1_437xminus1plus()
        {
            string expression = "4-3*7+1";
            string expected = "437*-1+";

            ReversePolishNotation r = new ReversePolishNotation();
            string actual = r.RPN(expression);

            Assert.AreEqual(expected,actual);
        }
    }
}
