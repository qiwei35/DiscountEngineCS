using System;
using System.Collections.Generic;
using System.Linq;

namespace Avengers
{
    using PromotionCS;
    using DiscountFields = IList<string>;

    public static class DiscountConsole
    {
        // given a set of discount fields
        static DiscountFields DefaultDiscountFields = new List<string> { "X", "Y" };

        public static KeyValuePair<string, double> EnterField(string field)
        {
            Console.WriteLine("Enter discount value for {0}:", field);

            double discountValue = 0.0;
            var parseSuccess = false;

            while (!parseSuccess)
            {
                parseSuccess = double.TryParse(Console.ReadLine(), out discountValue);

                if (!parseSuccess)
                {
                    Console.WriteLine("Invalid discount value given, try again for {0}:", field);
                }
            }

            return new KeyValuePair<string, double>(field, discountValue);
        }

        public static void Main()
        {
            var fieldDiscountPairs = DefaultDiscountFields
                .Select(field => EnterField(field));

            var discountTracker = new DiscountTracker();

            foreach (var fieldDiscountPair in fieldDiscountPairs)
            {
                discountTracker.AddToDiscountTracker(fieldDiscountPair.Key, fieldDiscountPair.Value);
            }

            // print summary
            var discountTrackerItems = discountTracker.GetDiscountTracker();

            foreach (var fieldDiscountPair in discountTrackerItems)
            {
                Console.WriteLine("Discount for '{0}': {1}", fieldDiscountPair.Key, fieldDiscountPair.Value);
            }
        }
    }
}
