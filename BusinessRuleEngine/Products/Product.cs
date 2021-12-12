

namespace BusinessRuleEngine.Products
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPackingSlipGenerated_Shipping { get; set; }
        public bool IsAgentCommissionGenerated { get; set; }
        public bool IsPackingSlipGenerated_RoyaltyDepartment { get; set; }
        public List<string> ProductPaymentActions { get; set; }
        public abstract Product FulfilProductOrder();
    }
}
