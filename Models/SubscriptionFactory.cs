using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription_Management_System.Models
{
    internal class SubscriptionFactory
    {
        public ISubscription CreateSubscription(string subscriptionType)
        {
            switch (subscriptionType.ToLower())
            {
                case "basic":
                    return new BasicSubscription();
                case "premium":
                    return new PremiumSubscription();
                case "family":
                    return new FamilySubscription();
                default:
                    throw new ArgumentException("Invalid subscription type");
            }
        }
    }
}
