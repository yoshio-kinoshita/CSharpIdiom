using Xunit;
using Service.Ch1;
using System;

namespace Service.Tests.Ch1
{
    public class Ch1_Test
    {

        [Fact]
        public void StructTest()
        {
            var a = new MyPoint(10, 20);
            var b = a;

            Console.WriteLine($"a: ({a.X}, {a.Y})");
            Console.WriteLine($"b: ({b.X}, {b.Y})");

            a.X = 80;

            Console.WriteLine($"a: ({a.X}, {a.Y})");
            Console.WriteLine($"b: ({b.X}, {b.Y})");

        }

    }

}