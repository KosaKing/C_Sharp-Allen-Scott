using System;
using System.Collections.Generic;


namespace GradeBook
{
    public class Statistics
    {
        public double Average;
        public double High;
        public double Low;
        public char Grade
        {
            get
            {
                switch(AverageFunction)
            {
              case var d when d >= 90:
              return 'A';
              
              case var d when d >= 80:
              return 'B';
             
              
              case var d when d >= 70:
              return 'C';
              
              
              case var d when d >= 60:
              return 'D';
              

              default:
              return 'F';
              
            }
            }
        }

        public double Sum;
        public int count;

        public Statistics()
        {
            Sum = 0.0;
          count = 0;
          High = double.MinValue;
          Low = double.MaxValue;
        }

        public void Add(double number)
        {
            Sum += number;
            count ++;
            
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }

        public double AverageFunction
        {
            get
            {
                return Sum/count;
            }

        }
    }
}
