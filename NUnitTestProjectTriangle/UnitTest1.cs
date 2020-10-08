using NUnit.Framework;

using Ruchika_Shekhawat_8672726;
using System;
using static Ruchika_Shekhawat_8672726.Program;

namespace NUnitTestProjectTriangle
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            var testresult = TriangleSolver.Analyze(5, 5, 8);
            Boolean flag = false;
            if (testresult == "This is an equilateral triangle.")
            {
                flag = true;

                Assert.IsTrue(flag);
            }
            else
            {
                Assert.IsTrue(flag);
            }
               
        }
    }
}