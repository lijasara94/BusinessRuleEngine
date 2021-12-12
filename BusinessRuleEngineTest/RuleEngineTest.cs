using BusinessRuleEngine.Models;
using BusinessRuleEngine.Products;
using BusinessRuleEngine.Services;
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

            Assert.Equal(isPackingSlipGenerated, product.IsPackingSlipGenerated_Shipping);
            Assert.Equal(isAgentCommissionGenerated, product.IsAgentCommissionGenerated);
            Assert.Equal(isPackingSlipGenerated_RoyaltyDept, product.IsPackingSlipGenerated_RoyaltyDepartment);
            Assert.Equal("Generate Packiing Slip for Shipping", product.ProductPaymentActions[0]);
            Assert.Equal("Generate Agent Commision", product.ProductPaymentActions[1]);

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

        [Fact]
        public void ActivateMembershipTest()
        {

            //Arrange
            IEmailService emailService = new EmailService();
            UserAccount userAccount = new UserAccount();
            userAccount.EmailId = "test@gmail.com";
            userAccount.UserName = "test";
            bool isMembershipActivated = true;
            bool isSentActivationMail = true;

            MemberShip memberShip = new MemberShip(emailService, userAccount);

            //Act

            var product = memberShip.FulfilProductOrder();

            //Assert

            Assert.Equal(isMembershipActivated, userAccount.IsUserActivated);
            Assert.Equal(isSentActivationMail, userAccount.IsSentActivationMail);

            Assert.Equal("Accoint is activated", product.ProductPaymentActions[0]);

        }
        [Fact]
        public void UpgradeMembershipTest()
        {

            //Arrange
            IEmailService emailService = new EmailService();
            UserAccount userAccount = new UserAccount();
            userAccount.EmailId = "test@gmail.com";
            userAccount.UserName = "test";
            bool isMembershipUpgraded = true;
            bool isSentAccountUpgradationMail = true;

            Upgrade upgrade = new Upgrade(emailService, userAccount);

            //Act

            var product = upgrade.FulfilProductOrder();

            //Assert

            Assert.Equal(isMembershipUpgraded, userAccount.IsUserAccountUpgraded);
            Assert.Equal(isSentAccountUpgradationMail, userAccount.IsSentAccountUpgradationMail);

            Assert.Equal("Accoint is upgraded", product.ProductPaymentActions[0]);

        }
    }
}