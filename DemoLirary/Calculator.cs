using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLirary
{
    public static class Calculator
    {
        public static int Add(int a, int b) => a + b;

        public static int Sustract(int a, int b) => a - b;

        public static int Multiply(int a, int b) => a * b;

        public static int Divide(int a, int b) => b != 0 ? a / b : 0;
        
        

    }
}
