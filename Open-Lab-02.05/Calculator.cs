using System;

namespace Open_Lab_02._05
{
    public class Calculator
    {
        public bool DivisibleByFive(int number)
        {
            int answer = number % 5;
            if (answer == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
