using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TimCoreySolutions;

namespace Tests
{
    public class LinqStringLettersTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetLettersTest()
        {
            //arrange
            //A string
            var input = "HolaMundo";
            //an expected return
            var returnString = new List<char>();
            returnString.Add('A');
            returnString.Add('D');
            returnString.Add('H');
            returnString.Add('L');
            returnString.Add('M');
            returnString.Add('N');
            returnString.Add('O');
            //act
            var result = new LinqStringLetters().GetLetters(input);

            //assert
            var enumerator = result.GetEnumerator();
            foreach (var item in returnString)
            {
                enumerator.MoveNext();
                Assert.AreEqual(item, enumerator.Current);
            }
        }
        [Test]
        public void GetLettersAndCountTest()
        {
            //arrange
            //A string
            var input = "HolaMundo";
            //an expected return
            var returnString = new List<Tuple<char,int>>();
            returnString.Add(new Tuple<char, int>('A', 1));
            returnString.Add(new Tuple<char, int>('D', 1));
            returnString.Add(new Tuple<char, int>('H', 1));
            returnString.Add(new Tuple<char, int>('L', 1));
            returnString.Add(new Tuple<char, int>('M', 1));
            returnString.Add(new Tuple<char, int>('N', 1));
            returnString.Add(new Tuple<char, int>('O', 2));
            returnString.Add(new Tuple<char, int>('U', 1));
            var enumerator = returnString.GetEnumerator();
            //act
            var result = new LinqStringLetters().GetLettersAndCount(input);
            //assert

            foreach (var item in result)
            {
                enumerator.MoveNext();
                Assert.AreEqual(enumerator.Current, item);
            }
        }
    }
}