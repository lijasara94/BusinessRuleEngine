
namespace BusinessRuleEngine.Products
{
    public class PhysicalProduct : Product, IGeneratePackingSlip, IGenerateAgentCommission
    {

        public PhysicalProduct()
        {
            Name = "Physical Product";
            Description = "Physical Product";
            ProductPaymentActions = new List<string>();
        }
        public override Product FulfilProductOrder()
        {
            GeneratePackingSlip();
            GenerateAgentCommision();
            return this;
        }

        public void GenerateAgentCommision()
        {
            IsAgentCommissionGenerated = true;
            ProductPaymentActions.Add("Generate Agent Commision");
        }

        public void GeneratePackingSlip()
        {
            IsPackingSlipGenerated_Shipping = true;
            ProductPaymentActions.Add("Generate Packiing Slip for Shipping");
        }
    }
}
