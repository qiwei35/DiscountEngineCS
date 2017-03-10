using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class DiscountTracker
    {

        IDictionary<string, double> promotions;

           public DiscountTracker()
        {
            promotions = new Dictionary<string, double>();
        }

        public void AddToDiscountTracker(String name,Double promo)
        {
            promotions.Add(name, promo);
        }

        public IDictionary<string, double> GetDiscountTracker()
        {
            return promotions;
        }

    }
}
