using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveExclamationMarks.Library;
using System.Text;

namespace RemovMarks.Test
{
    [TestClass]
    public class RemoveTester
    {
        private const int RandomTestsCount = 100, MinRandomStringLength = 1, MaxRandomStringLength = 50;
        private const string AllowedChars = "!!!!!!abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ@#$%^&*()";
        [TestMethod]
        public  void BasicTests()
        {
            Assert.AreEqual("", RemoveExclamationMarks.Library.RemoveExclamationMarks.RemoverMarks(""), "Input: Empty string");
            Assert.AreEqual("", RemoveExclamationMarks.Library.RemoveExclamationMarks.RemoverMarks("!"), "Input: " + "!");
            Assert.AreEqual("", RemoveExclamationMarks.Library.RemoveExclamationMarks.RemoverMarks("!!"), "Input: " + "!!");
            Assert.AreEqual("Hi", RemoveExclamationMarks.Library.RemoveExclamationMarks.RemoverMarks("Hi!"), "Input: " + "Hi!");
            Assert.AreEqual("?", RemoveExclamationMarks.Library.RemoveExclamationMarks.RemoverMarks("!?!"), "Input: " + "!?!");
        }
        [TestMethod]
        public  void RandomTests()
        {
            Random r = new Random();
            for (int i = 0; i < RandomTestsCount; i++)
            {
                string input = GetRandomString(r);
                Assert.AreEqual(input.Replace("!",string.Empty), 
                    RemoveExclamationMarks.Library.RemoveExclamationMarks.RemoverMarks(input), "Input: " + input);
            }
        }

        public string GetRandomString(Random r)
        {
            int leght = r.Next(MinRandomStringLength, MaxRandomStringLength);
            StringBuilder result = new StringBuilder();
            for(int i=0;i<leght;i++)
            {
                result.Append(AllowedChars[r.Next(0, AllowedChars.Length)]);
            }
            return result.ToString();
        }
    }
}
