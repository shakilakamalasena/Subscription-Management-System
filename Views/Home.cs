using Subscription_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subscription_Management_System.Views
{
    public partial class Home : Form
    {
        SubscriptionFactory subscriptionFactory = new SubscriptionFactory();

        public Home()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            int months = int.Parse(txt_period.Text);
            int userCount = int.Parse(txt_userCount.Text);
            string subscriptionType = cmb_plan.Text;

            ISubscription subscription = subscriptionFactory.CreateSubscription(subscriptionType);
            double totalCost = subscription.GetPrice(months, userCount);

            lbt_plan.Text = subscription.GetName();
            lbl_userCount.Text = userCount.ToString();
            lbl_period.Text = months.ToString();
            lbl_cost.Text = "$ " + totalCost.ToString();
            txt_features.Text = subscription.GetFeatures();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_plan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subscriptionType = cmb_plan.Text;
            switch (subscriptionType.ToLower())
            {
                case "basic":
                    txt_userCount.Text = "1";
                    break;
                case "premium":
                    txt_userCount.Text = "1";
                    break;
                case "family":
                    txt_userCount.Text = "";
                    break;
                default:
                    throw new ArgumentException("Invalid subscription type");
            }
        }
    }
}
