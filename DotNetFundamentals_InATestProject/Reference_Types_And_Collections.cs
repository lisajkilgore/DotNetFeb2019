using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Reference_Types_And_Collections
    {
        [TestMethod]
        public void ReferenceTypes()
        {
            //Classes 
            //Interfaces

            string hello = "Hello World";
        }
        public void Collections();
        {
        string[] arrayOfStrings = {"This", "Can", "be anything", "of stroings"};
        int[] arrayOfNumber = { 1, 3, 53, 2789 };
        List<string> listOfStrings = new List<string>();
        Queue<string> firstInFirstOut = new Queue<string>();
        Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
        SortedList<int, string> SortedKeyValuePair = new SortedList<int, string>();
        Stack<string> lastInFirstOut = new Stack<string>();

        }

    [TestMethod]

    public string SayHello(string hello)
    {
        string greeting = "Hello" + hello;
        Console.WriteLine($"Hello {Hello}");

        [TestMethod]
}

    }
}

