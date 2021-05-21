using System;
using System.Diagnostics;
using System.IO;
using NUnit.Framework;
using PenUnitTesting.Data;
using PenUnitTesting.Utils;
using Unit_test;

namespace PenUnitTesting
{
    public class Tests
    {
        private const double defaultSizeLetter = 1;
        private const int defaultInkContainerValue = 10;
        private const string defaultColor = "red";
        
        [TestCaseSource(typeof(TestData), nameof(TestData.DifferentInkCounterAndSizeLetters))]
        public void TestDifferentSizeLetters(int inkCounterValue, double sizeLetters, string actualWord, string expectedWord)
        {
            var pen = new Pen(inkCounterValue, sizeLetters);
            Assert.AreEqual(pen.write(actualWord), expectedWord, "Written word didn't equal expected word");
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.DifferentInkCounterAndWordValues))]
        public void TestDifferentInkCounterValues(int inkCounterValue, string actualWord, string expectedWord)
        {
            var pen = new Pen(inkCounterValue);
            Assert.AreEqual(pen.write(actualWord), expectedWord, "Written word didn't equal expected word");
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.DifferentWords))]
        public void TestDifferentWordsToWrite(string actualWord, string expectedWord)
        {
            var pen = new Pen(defaultInkContainerValue, defaultSizeLetter);
            Assert.AreEqual(pen.write(actualWord), expectedWord, "Written word didn't equal expected word");
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.DifferentColors))]
        public void TestDifferentColors(string color)
        {
            var pen = new Pen(defaultInkContainerValue, defaultSizeLetter, color);
            Assert.AreEqual(pen.getColor(), color, "Method 'getColor' didn't return actual color value");
        }
        
        [Test]
        public void TestDoSomethingElse()
        {
            var path = PathFunctions.GetPath(@"Resources/files/myFile.txt");
            var pen = new Pen(defaultInkContainerValue, defaultSizeLetter, defaultColor);
            TraceFunctions.AddTextWriterTraceListener(path);
            pen.doSomethingElse();
            Trace.Flush();
            Assert.AreEqual(File.ReadAllLines(path)[0], defaultColor, "Method 'doSomethingElse' didn't write color value into the file");
        }
    }
}