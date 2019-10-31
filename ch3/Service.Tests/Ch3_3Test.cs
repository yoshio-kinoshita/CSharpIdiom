
using Xunit;
using System;
using System.Collections.Generic;

namespace Service.Tests
{
    public class Ch3_3Test
    {
        public Ch3_3Test()
        {
        }

        [Fact]
        public void Ch3_3_1ExsitsTest()
        {
            var list = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            Assert.False(list.Exists(s => s[0] == 'A'));
        }

        [Fact]
        public void Ch3_3_2FindTest()
        {
            var list = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            Assert.Equal("London", list.Find(s => s.Length == 6));
        }

        [Fact]
        public void Ch3_3_3FindIndexTest()
        {
            var list = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            Assert.Equal(5, list.FindIndex(s => s == "Berlin"));
        }

        [Fact]
        public void Ch3_3_4FindAllTest()
        {
            var list = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            Assert.Equal(2, list.FindAll(s => s.Length <= 5).Count);
        }

        [Fact]
        public void Ch3_3_5RemoveAllTest()
        {
            var list = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            Assert.Equal(2, list.RemoveAll(s => s.Contains("on")));
        }

        [Fact]
        public void Ch3_3_6ForEachTest()
        {
            var list = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            list.ForEach(s => Console.WriteLine(s));
        }

        [Fact]
        public void Ch3_3_7ConverAllTest()
        {
            var list = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            var lowerList = list.ConvertAll(s => s.ToLower());
            lowerList.ForEach(s => Console.WriteLine(s));
        }

    }
}