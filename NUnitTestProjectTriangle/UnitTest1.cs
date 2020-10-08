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
        public void Test4_NotIsosceles()
        {
            var testresult = TriangleSolver.Analyze(1, 1, 1);
            Boolean flag = true;
            if (testresult == "This is an isosceles triangle.\n")
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
        public void Test5_scalene()
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
        [Test]
        public void Test6_NotScalene()
        {
            var testresult = TriangleSolver.Analyze(1, 1, 1);
            Boolean flag = true;
            if (testresult == "This is a scalene triangle.\n")
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
        public void Test7_negative_input()
        {
            var testresult = TriangleSolver.Analyze(-2, -1, 1);
            Boolean flag = false;
            if (testresult == "\nInvalid input")
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
        public void Test8_Zero()
        {
            string functioncalling = TriangleSolver.Analyze(0,0,0);
            Assert.AreEqual("\nInvalid input", functioncalling);
            

        }
    }
}