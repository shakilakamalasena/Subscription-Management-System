using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscription_Management_System.Models
{
    internal interface ISubscription
    {
        string GetName();
        double GetPrice(int months, int userCount);
        string GetFeatures();
    }
}
