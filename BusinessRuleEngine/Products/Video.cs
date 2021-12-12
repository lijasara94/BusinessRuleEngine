using BusinessRuleEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Products
{
    public class Video : Product, IGeneratePackingSlip
    {
        public string Title { get; set; }
        public bool isComboOfferApplied { get; set; }
        public Video(string title)
        {
            Title = title;
            Name = "Video";
            Description = "Video";
            ProductPaymentActions = new List<string>();
        }
        public override Product FulfilProductOrder()
        {
            GeneratePackingSlip();
            foreach (var offer in ComboOffers.GetVideoOffers())
            {
                if (offer.Key.ToLower() == Title.ToLower())
                {
                    ProductPaymentActions.Add(offer.Value);
                    isComboOfferApplied = true;
                }
            }

            return this;

        }
        public void GeneratePackingSlip()
        {
            IsPackingSlipGenerated_Shipping = true;

            ProductPaymentActions.Add("Generate Packiing Slip for Shipping");
        }


    }
}
