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
        public void Test1_equilateral()
        {
            var testresult = TriangleSolver.Analyze(5, 5, 5);
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
        [Test]
        public void Test2_NotEquilateral()
        {
            var testresult = TriangleSolver.Analyze(5, 5, 8);
            Boolean flag = true;
            if (testresult == "This is an equilateral triangle.")
            {
                flag = false;

                Assert.IsTrue(flag);
            }
            else
            {
                Assert.IsTrue(flag);
            }

        }
        [Test]
        public void Test3_Isosceles()
        {
            var testresult = TriangleSolver.Analyze(5, 5, 8);
            Boolean flag = false;
            if (testresult == "This is an isosceles triangle.\n")
            {
                flag = true;

                Assert.IsTrue(flag);
            }
            else
            {
                Assert.IsTrue(flag);
            }

        }
        [Test]
        public void Test3_scalene()
        {
            string testresult = TriangleSolver.Analyze(2, 5, 8);
            Boolean flag = false;
            if (testresult == "This is a scalene triangle.\n")
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