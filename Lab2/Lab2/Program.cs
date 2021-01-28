using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Lab2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int SalesPrice = Convert.ToInt32(TextBox1.Text);
                // When a user inputs an integer, I want it to be able to handle input of fractions
                // without getting an exception error. 



                // If a user inputs a whole number or fractional number (like 20.25), it should be able
                // to handle it.
                double DiscountPercentage = Convert.ToDouble(TextBox2.Text);


                double discountValue = this.CalculateDiscountValue(SalesPrice, DiscountPercentage);
                double TotalPrice = this.TotalPriceCalculate(SalesPrice, discountValue);
                Label1.Text = discountValue.ToString("c");
                Label2.Text = TotalPrice.ToString("c");

            }
        }
        protected double CalculateDiscountValue(int SalesPrice, double DiscountPercentage)
        {
            double discountAmount = SalesPrice * DiscountPercentage;
            return discountAmount;
        }

        protected double TotalPriceCalculate(int SalesPrice, double discountAmount)
        {
            double TotalPrice = SalesPrice - discountAmount;
            return TotalPrice;
        }


    }

}
