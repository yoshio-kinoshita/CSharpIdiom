using Xunit;
using System;

namespace Service.Tests
{
    public class Ch3_2Test
    {
        private readonly Ch3_2 _ch3_2;

        public Ch3_2Test()
        {
            _ch3_2 = new Ch3_2();
        }

        [Fact]
        public void Ch3_2_1Test()
        {
            int[] numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            var result = _ch3_2.Count3_2_1(numbers, n => n % 2 == 0);

            Assert.Equal(5, result);
        }

        [Fact]
        public void Ch3_2_1Predicate_0Test()
        {
            int[] numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            // 冗長なコード
            // C#2.0の機能. delegateの変わりに =>(ラムダ演算子)を利用
            Predicate<int> judge = (int n) =>
            {
                if (n % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            var result = _ch3_2.Count3_2_1(numbers, judge);

            Assert.Equal(5, result);
        }

        [Fact]
        public void Ch3_2_1Predicate_1Test()
        {
            int[] numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            // judgeを削除し直接渡す.
            var result = _ch3_2.Count3_2_1(numbers,
            (int n) =>
            {
                if (n % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            Assert.Equal(5, result);
        }

        [Fact]
        public void Ch3_2_1Predicate_2Test()
        {
            int[] numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            // if文をなくす
            var result = _ch3_2.Count3_2_1(numbers, (int n) => { return n % 2 == 0; });
            Assert.Equal(5, result);
        }

        [Fact]
        public void Ch3_2_1Predicate_3Test()
        {
            int[] numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            // {} と return文省略
            var result = _ch3_2.Count3_2_1(numbers, (int n) => n % 2 == 0);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Ch3_2_1Predicate_4Test()
        {
            int[] numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            // ラムダ式では引数の型を省略可。コンパイラが適切に型を推論してくれる。
            var result = _ch3_2.Count3_2_1(numbers, (n) => n % 2 == 0);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Ch3_2_1Predicate_5Test()
        {
            int[] numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            // 引数が１つの場合、()を省略可能
            var result = _ch3_2.Count3_2_1(numbers, n => n % 2 == 0);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Ch3_2_1LamdaExamples()
        {
            int[] numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            // 奇数の数をカウントする
            var result = _ch3_2.Count3_2_1(numbers, n => n % 2 == 0);
            Assert.Equal(5, result);

            // 5以上の数をカウントする
            result = _ch3_2.Count3_2_1(numbers, n => n >= 5);
            Assert.Equal(8, result);

            // 5以上10未満の数をカウントする
            result = _ch3_2.Count3_2_1(numbers, n => n >= 5 && n < 10);
            Assert.Equal(7, result);

            // 数字の1が含まれている数
            result = _ch3_2.Count3_2_1(numbers, n => n.ToString().Contains('1'));
            Assert.Equal(2, result);
        }

    }
}