using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription_Management_System.Models
{
    internal class BasicSubscription : ISubscription
    {
        public string GetName()
        {
            return "Basic Subscription";
        }
        public double GetPrice(int months, int userCount = 1)
        {
            return 10 * months * userCount;
        }

        public string GetFeatures()
        {
            return "Access to SD content and Ads included";
        }
    }
}
