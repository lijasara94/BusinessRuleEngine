using BusinessRuleEngine.Products;
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
            bool isPackingSlipGenerated_RoyaltyDept = false;

            //Act

            var product = physicalProduct.FulfilProductOrder();

            //Assert
            
            Assert.Equal(isPackingSlipGenerated,product.IsPackingSlipGenerated_Shipping);
            Assert.Equal(isAgentCommissionGenerated, product.IsAgentCommissionGenerated);
            Assert.Equal(isPackingSlipGenerated_RoyaltyDept, product.IsPackingSlipGenerated_RoyaltyDepartment);
            Assert.Equal("Generate Packiing Slip for Shipping", product.ProductPaymentActions[0]);
            Assert.Equal("Generate Agent Commision",product.ProductPaymentActions[1]);

        }

        [Fact]
        public void OrderBookTest()
        {

            //Arrange
             Book book = new Book();
            bool isAgentCommissionGenerated = true;
            bool isPackingSlipGenerated = true;
            bool isPackingSlipGenerated_RoyaltyDept = true;

            //Act

            var product = book.FulfilProductOrder();

            //Assert

            Assert.Equal(isPackingSlipGenerated, product.IsPackingSlipGenerated_Shipping);
            Assert.Equal(isAgentCommissionGenerated, product.IsAgentCommissionGenerated);
            Assert.Equal(isPackingSlipGenerated_RoyaltyDept, product.IsPackingSlipGenerated_RoyaltyDepartment);
            Assert.Equal("Generate Packiing Slip for Shipping", product.ProductPaymentActions[0]);
            Assert.Equal("Generate Agent Commision", product.ProductPaymentActions[1]);
            Assert.Equal("Generate Packaging Slip for Royalty Department", product.ProductPaymentActions[2]);

        }
    }
}