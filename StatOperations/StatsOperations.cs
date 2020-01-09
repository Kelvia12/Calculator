using System;
using operations;

namespace StatOperations
{
    public class StatOperations
    {
        public dynamic Mean(dynamic values)
        {
            var sum = operations.Addition.Sum(values);
            var valueCount = values.Length;
            var result = operations.Division.Qotient(sum, valueCount);

            return result;

        }
    }
}
