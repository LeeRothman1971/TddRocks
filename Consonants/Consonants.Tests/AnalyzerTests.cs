﻿namespace Consonants.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AnalyzerTests
    {
        [TestMethod]
        public void GetConsonantStringsLength1Sample1()
        {
            Analyzer analyzer = new Analyzer();
            var result = analyzer.GetConsonantPositions("ab", 1);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result[0]);
        }

        [TestMethod]
        public void GetConsonantStringsLength1Sample2()
        {
            Analyzer analyzer = new Analyzer();
            var result = analyzer.GetConsonantPositions("bc", 1);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void GetConsonantStringsLength2Sample1()
        {
            Analyzer analyzer = new Analyzer();
            var result = analyzer.GetConsonantPositions("abc", 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result[0]);
        }

        [TestMethod]
        public void GetConsonantStringsLength2Sample2()
        {
            Analyzer analyzer = new Analyzer();
            var result = analyzer.GetConsonantPositions("abcd", 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [TestMethod]
        public void GetConsonantStringsLength2Sample3()
        {
            Analyzer analyzer = new Analyzer();
            var result = analyzer.GetConsonantPositions("bcdf", 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(2, result[2]);
        }

        [TestMethod]
        public void GetCountQuartzLength3()
        {
            Analyzer analyzer = new Analyzer();
            Assert.AreEqual(4, analyzer.Count("quartz", 3));
        }

        [TestMethod]
        public void GetCountRtzLength2()
        {
            Analyzer analyzer = new Analyzer();
            Assert.AreEqual(3, analyzer.Count("rtz", 2));
        }

        [TestMethod]
        public void GetCountAbeLength1()
        {
            Analyzer analyzer = new Analyzer();
            Assert.AreEqual(4, analyzer.Count("abe", 1));
        }

        [TestMethod]
        public void GetCountQuartzLength2()
        {
            Analyzer analyzer = new Analyzer();
            Assert.AreEqual(9, analyzer.Count("quartz", 2));
        }

        [TestMethod]
        public void GetCountStringLength3()
        {
            Analyzer analyzer = new Analyzer();
            Assert.AreEqual(4, analyzer.Count("string", 3));
        }

        [TestMethod]
        public void GetCountStraightLength3()
        {
            Analyzer analyzer = new Analyzer();
            Assert.AreEqual(11, analyzer.Count("straight", 3));
        }

        [TestMethod]
        public void GetCountGcjLength2()
        {
            Analyzer analyzer = new Analyzer();
            Assert.AreEqual(3, analyzer.Count("gcj", 2));
        }

        [TestMethod]
        public void GetCountAaaaLength3()
        {
            Analyzer analyzer = new Analyzer();
            Assert.AreEqual(0, analyzer.Count("aaaa", 3));
        }

        [TestMethod]
        public void GetCountTsetseLength2()
        {
            Analyzer analyzer = new Analyzer();
            Assert.AreEqual(11, analyzer.Count("tsetse", 2));
        }
    }
}
