using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Proxy_Real_World_Practice
    {
        public static void Run()
        {
            Console.WriteLine("Proxy Real-world practice");
            MathProxy proxy = new MathProxy();
            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4,2));
        }

        public interface IMath
        {
            double Add(double x, double y);
            double Sub(double x, double y);
            double Mul(double x, double y);
            double Div(double x, double y);
        }

        class Math : IMath
        {
            public double Add(double x, double y) { return x + y; }
            public double Sub(double x, double y) { return x - y; }
            public double Mul(double x, double y) { return x * y; }
            public double Div(double x, double y) { return x / y; }
        }

        class MathProxy : IMath
        {
            private Math _math = new Math();
            public double Add(double x, double y)
            {
                return _math.Add(x, y);
            }
            public double Sub(double x, double y)
            {
                return _math.Sub(x, y);
            }
            public double Mul(double x, double y)
            {
                return _math.Mul(x, y);
            }
            public double Div(double x, double y)
            {
                return _math.Div(x, y);
            }
        }
    }
}
