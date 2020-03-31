using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2_Calculator
{
    /* 
     * Calculator w/ Tests Challenge
Create a Calculator class that has the ability to complete all of the following processes:
Add
Subtract
Multiply
Divide
Write Unit Tests for all of your calculator's functionalities.

 

Bonus Challenges:

Allow use of whole numbers and numbers with decimals
Have the ability to return fractions instead of percentages
Allow the calculator to take in as many numbers as the user provides */


        //I have chosen to do this in a class library assembly. 
    public class Class1
    {
        public int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        public int Divid(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }


        //Bonus
        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }
        public double Subtract(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }
        public double Multiply(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }
        public double Divid(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }
    }
}
