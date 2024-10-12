using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription_Management_System.Models
{
    internal class FamilySubscription : ISubscription
    {
        public string GetName()
        {
            return "Family Subscription";
        }
        public double GetPrice(int months, int userCount)
        {
            if (userCount == 1)
            {
                return 30 * months * userCount;
            }
            else
            {
                return (30 + 5 * (userCount-1)) * months;
            }
        }

        public string GetFeatures()
        {
            return "Access to HD content, No Ads, Offline downloads, and Multiple users allowed";
        }
    }
}
