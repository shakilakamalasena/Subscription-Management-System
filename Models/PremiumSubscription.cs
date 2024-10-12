using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription_Management_System.Models
{
    internal class PremiumSubscription : ISubscription
    {
        public string GetName()
        {
            return "Premium Subscription";
        }
        public double GetPrice(int months, int userCount = 1)
        {
            return 20 * months * userCount;
        }

        public string GetFeatures()
        {
            return "Access to HD content, No Ads, and Offline downloads";
        }
    }
}
