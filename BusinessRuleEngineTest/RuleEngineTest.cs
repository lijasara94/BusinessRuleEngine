using BusinessRuleEngine;
using Xunit;

namespace BusinessRuleEngineTest
{
    public class RuleEngineTest
    {
        [Fact]
        public void OrderPhysicalProduct_ShouldGnerateAgentCommisionAndPackingSlip()
        {
           
            //Arrange
            PhysicalProduct physicalProduct = new PhysicalProduct();
            bool isAgentCommissionGenerated = true;
            bool isPackingSlipGenerated = true;

            //Act

            var product = physicalProduct.FulfilProductOrder();

            //Assert
            
            Assert.Equal(isPackingSlipGenerated,product.IsPackingSlipGenerated_Shipping);
            Assert.Equal(isAgentCommissionGenerated, product.IsAgentCommissionGenerated);
            Assert.Equal("Generate Packiing Slip for Shipping", product.ProductPaymentActions[0]);
            Assert.Equal("Generate Agent Commision",product.ProductPaymentActions[1]);

        }
    }
}