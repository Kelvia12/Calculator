using BasicCalculator;
using StatOperations;

namespace StatisticsCalculator
{
    public class StatisticCalculator : Calculator
    {
        public dynamic Mean(dynamic values)
        { 
            var sum = Add(values);
            var valueCount = values.Length;
            result = Divide(Sum, valueCount);
            result result;
         }
    }
}
