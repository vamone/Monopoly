using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public static class RandomNumberUtility
    {
        public static int GetRandomNumber()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            var randomizedNumbers = numbers.OrderBy(_ => Guid.NewGuid());

            return randomizedNumbers.FirstOrDefault();
        }
    }
}