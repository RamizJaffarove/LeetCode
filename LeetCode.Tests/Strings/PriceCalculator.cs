namespace LeetCode.Tests.Strings;

public class PriceCalculator
{
    public (DayPricePair, DayPricePair) Calculate(List<DayPricePair> data)
    {
        double maxDiff = double.MinValue;
        DayPricePair maxDiffDay1 = data.First();
        DayPricePair maxDiffDay2 = data.First();

        for (var i = 0; i < data.Count; i++)
        {
            var day1 = data[i];
            for (var j = i + 1; j < data.Count; j++)
            {
                var day2 = data[j];
                var diff = day2.Price - day1.Price;

                if (diff > maxDiff)
                {
                    maxDiff = diff;
                    maxDiffDay1 = day1;
                    maxDiffDay2 = day2;
                }
            }
        }

        return (maxDiffDay1, maxDiffDay2);
    }

    public class DayPricePair
    {
        public int Day { get; set; }

        public double Price { get; set; }
    }
}