using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<string>();

            // Calculated Values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double overallScores = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            if (Q1Results.CoffeeScore < Q1Results.FoodScore)
            {
                tasks.Add("Investigate coffee receipts and ingredients.");
            }

            if (overallScores > 8.0)
            {
                tasks.Add("Work with leadership to reward staff.");
            }
            else
            {
                tasks.Add("Work with employees for improving ideas.");
            }

            if (responseRate < 0.33)
            {
                tasks.Add("Research options to improve response rate.");
            }
            else if (responseRate >= 0.33 && responseRate < 0.66)
            {
                tasks.Add("Reward participants with free coffee coupon.");
            }
            else
            {
                tasks.Add("Rewards participants with discount coffee coupon.");
            }
        }
    }
}
