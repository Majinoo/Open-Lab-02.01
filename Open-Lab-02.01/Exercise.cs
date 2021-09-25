using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            double[] hodnota = { 2.1, 1.9, 5.1, 4.4, 5.5 };
            return hodnota;
        }

        public double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}