
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.Tests
{
    public class Ch3_4Test
    {
        public Ch3_4Test()
        {
        }

        [Fact]
        public void Ch3_4_1LinqToObjectsTest()
        {
            var list = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            IEnumerable<string> query = list.Where(s => s.Length <= 5);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            query = list.Where(s => s.Length <= 5).Select(s => s.ToLower());
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        [Fact]
        public void Ch3_4_4LazyLoadTest()
        {
            string[] names = { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            var query = names.Where(s => s.Length <= 5);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");

            names[0] = "Osaka";
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        [Fact]
        public void Ch3_4_4IIFETest()
        {
            string[] names = { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };
            var query = names.Where(s => s.Length <= 5).ToArray();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");

            names[0] = "Osaka";
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

    }
}