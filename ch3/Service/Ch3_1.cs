using System;

namespace Service
{
    /// <summary>
    /// ラムダ式以前
    /// </summary>
    public class Ch3_1
    {

        /// <summary>
        /// 汎用性のないCountメソッド
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int Count3_1_1(int num)
        {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            int count = 0;

            foreach (var n in numbers)
            {
                if (n == num)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// 配列を引数に受け取るCountメソッド
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public int Count3_1_2(int[] numbers, int num)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (n == num)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// デリゲートの宣言
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public delegate bool Judgement(int value);

        public int Count3_1_3(int[] numbers, Judgement judge)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (judge(n) == true)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// 匿名メソッドの利用
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="judge"></param>
        /// <returns></returns>
        public int Count3_1_6(int[] numbers, Predicate<int> judge)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (judge(n) == true)
                {
                    count++;
                }

            }
            return count;
        }
    }
}
