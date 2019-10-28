using System;
using System.Collections.Generic;

namespace Service
{
    /// <summary>
    /// ラムダ式
    /// </summary>
    public class Ch3_2
    {

        /// <summary>
        /// 匿名メソッドの利用
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="judge"></param>
        /// <returns></returns>
        public int Count3_2_1(int[] numbers, Predicate<int> judge)
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
