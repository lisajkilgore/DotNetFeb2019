using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Operators_And_Methods
    {
        [TestMethod]
        public void TestMethod1()


        {
            int a = 1;
            int b = 2;
            int c = a + b;
            Assert.AreEqual(3, c);

            int d = 3;
            int e = 4;
            int f = e - d;
            Assert.AreEqual(1, f);

            int g = 4;
            int h = 5;
            int i = g * h;
            Assert.AreEqual(20, i);

            int j = 25;
            int k = 5;
            int l = 25 / 5;
            Assert.AreEqual(5, l);

            int m = 4;
            int n = 1;
            int o = m % n;
            Assert.AreEqual(4, o);
        }

        [TestMethod]
        public void AddTwoNumbersReturnSum_Test()


        {
            int sum = AddTwoNumbersReturnSum(3, 7);
            Console.WriteLine(sum);
            Assert.AreEqual(10, sum);
        }

        public int AddTwoNumbersReturnSum(int a, int b)
        {
            int sum = a + b;
            return sum;

        }

        [TestMethod]
        public void Subtract_Test()
        {
            int sub = Subtract_Test(4, 8);
            Console.WriteLine(sub);
            Assert.AreEqual(4, sub);
        }

       public int Subtract_Test(int a, int b)
            {
           int sub = b - a;
           return sub;
            }

            }

    }
        
           