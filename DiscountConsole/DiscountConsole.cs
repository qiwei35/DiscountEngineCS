using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avengers
{
    using DiscountFields = IList<string>;

    public static class DiscountConsole
    {
        // given a set of discount fields
        public static DiscountFields DefaultDiscountFields = new List<string> { "X", "Y" };

        public static KeyValuePair<string, double> EnterField(string field)
        {
            Console.WriteLine("Enter discount value for {0}:", field);

            var discountValueStr = Console.ReadLine();

            double discountValue = 0.0;
            var parseSuccess = false;

            while (!parseSuccess)
            {
                parseSuccess = double.TryParse(discountValueStr, out discountValue);

                if (!parseSuccess)
                {
                    Console.WriteLine("Invalid discount value given, try again for {0}:", field);
                }
            }

            return new KeyValuePair<string, double>(field, discountValue);
        }

        public static void Main()
        {
            var fieldDiscountDict = DefaultDiscountFields
                .Select(field => EnterField(field))
                .ToDictionary(fieldDiscountPair => fieldDiscountPair.Key, fieldDiscountPair => fieldDiscountPair.Value);
        }
    }
}
