using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace XamarinUnitTestsVsts.iOS.Service
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
