using System;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculated Values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            double overallScores = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswered Surveys: {unansweredCount}");
            Console.WriteLine($"Overall Score: {overallScores}");

            // Logical Comparisons
            bool higherCoffeeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            bool customerRecommend = Q1Results.WouldRecommend >= 7;
            bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";

            Console.WriteLine($"Coffee Score Higher than Food: {higherCoffeeScore}");
            Console.WriteLine($"Customer Would Recommend Us: {customerRecommend}");
            Console.WriteLine($"Hate Granola, Love Cappucino: {noGranolaYesCappucino}");
        }
    }
}
