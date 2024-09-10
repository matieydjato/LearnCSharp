using System;

namespace ConvertingStringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string score = "20";
            int scoreConvertedToInt = Convert.ToInt32(score);
            Console.WriteLine(score); // 20
            Console.WriteLine(score.GetType()); // System.String
            Console.WriteLine(scoreConvertedToInt); // 20
            Console.WriteLine(scoreConvertedToInt.GetType()); // System.Int32

            string totalScore = "1450";
            long totalScoreConvertedToLong = Convert.ToInt64(totalScore);
            Console.WriteLine(totalScore); // 1450
            Console.WriteLine(totalScore.GetType()); // System.String
            Console.WriteLine(totalScoreConvertedToLong); // 1450
            Console.WriteLine(totalScoreConvertedToLong.GetType()); // System.Int64

            string percent = "18,9";
            double percentConvertedToDouble = Convert.ToDouble(percent);
            Console.WriteLine(percent); // 18,9
            Console.WriteLine(percent.GetType()); // System.String
            Console.WriteLine(percentConvertedToDouble); // 18,9
            Console.WriteLine(percentConvertedToDouble.GetType()); // System.Double

            string horizon = "124,98";
            float horizonConvertedToFloat = Convert.ToSingle(horizon);
            Console.WriteLine(horizon); // 124,98
            Console.WriteLine(horizon.GetType()); // System.String
            Console.WriteLine(horizonConvertedToFloat); // 124,98
            Console.WriteLine(horizonConvertedToFloat.GetType()); // System.Single

            string income = "102500000";
            decimal incomeConvertedToDecimal = Convert.ToDecimal(income);
            Console.WriteLine(income); // 102500000
            Console.WriteLine(income.GetType()); // System.String
            Console.WriteLine(incomeConvertedToDecimal); // 102500000
            Console.WriteLine(incomeConvertedToDecimal.GetType()); // System.Decimal
        }
    }
}