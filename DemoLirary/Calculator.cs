using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLirary
{
    public static class Calculator
    {
        public static double Add(double a, double b) => a + b;

        public static double Sustract(double a, double b) => a - b;

        public static double Multiply(double a, double b) => a * b;

        public static double Divide(double a, double b) => b != 0 ? a / b : 0;
        
        

    }
}
