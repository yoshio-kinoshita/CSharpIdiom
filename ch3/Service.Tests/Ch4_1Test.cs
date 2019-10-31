using Xunit;
using System.Collections.Generic;
using Service.ch4;

namespace Service.Tests
{
    public class Ch4_1Test
    {

        private readonly Ch4_1 _ch4_1;

        public Ch4_1Test()
        {
            _ch4_1 = new Ch4_1();
        }

        [Fact]
        public void Ch4_1_1Test()
        {
            Assert.Equal(25, _ch4_1.Ch4_1_1());
        }

        [Fact]
        public void Ch4_1_2Test()
        {
            var langs = new string[] { "C#", "VB", "C++" };
            var nums = new List<int> { 10, 20, 30, 40 };
        }

        [Fact]
        public void Ch4_1_3Test()
        {
            var dict = new Dictionary<string, string>() {
                {"ja", "日本語"},
                {"en", "英語"},
                {"es", "スペイン語"},
                {"de", "ドイツ語"}
            };
            var dict2 = new Dictionary<string, string>()
            {
                ["ja"] = "日本語",
                ["en"] = "英語",
                ["es"] = "スペイン語",
                ["de"] = "ドイツ語"
            };
        }

        [Fact]
        public void Ch4_1_4Test()
        {
            var person = new Person()
            {
                Name = "木下喜雄",
                Birthday = new System.DateTime(1999, 9, 21),
                PhoneNumber = "090-1111-2222"
            };
        }
    }
}
