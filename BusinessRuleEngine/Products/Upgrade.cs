using BusinessRuleEngine.Models;
using BusinessRuleEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Products
{
    public class Upgrade : Product
    {
        private IEmailService emailService;
        private UserAccount userAccount;
        public Upgrade(IEmailService emailService, UserAccount userAccount)
        {
            this.emailService = emailService;
            this.userAccount = userAccount;
            this.Description = "Upgrade";
            this.Name = "Upgrade";
            ProductPaymentActions = new List<string>();
        }
        public override Product FulfilProductOrder()
        {
            UpgradeMemberShip();
            emailService.SendEmail("Account is upgraded", userAccount.EmailId);
            userAccount.IsSentAccountUpgradationMail = true;
            return this;
        }

        public void UpgradeMemberShip()
        {
            this.userAccount.IsUserAccountUpgraded = true;
            ProductPaymentActions.Add("Accoint is upgraded");
        }
    }
}
