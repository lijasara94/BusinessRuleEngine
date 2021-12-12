using BusinessRuleEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Products
{
    public class Book : PhysicalProduct, IGeneratePackingSlipForRoyaltyDepartment
    {
        public Book()
        {
            Name = "Book";
            Description = "Book";
        }
        public override Product FulfilProductOrder()
        {
            base.FulfilProductOrder();
            GeneratePackingSlipForRoyaltyDepartment();
            return this;
        }
        public void GeneratePackingSlipForRoyaltyDepartment()
        {
            IsPackingSlipGenerated_RoyaltyDepartment = true;
            ProductPaymentActions.Add("Generate Packaging Slip for Royalty Department");
        }
    }
}
