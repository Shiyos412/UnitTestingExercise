﻿using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Right-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int a, int b, int c)
        {
            return (a + b + c);
        }
        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }
        // Create a Multiply method that passes 2 integers
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        // Create a Divide method that passes 2 integers
        public int Divide(int a, int b)
        {
            return a / b;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
        public double Pie()
        {
            return Math.PI;
        }

        public int[] Below10Above0()
        {
            
            return new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            
        }
        
    }
}
