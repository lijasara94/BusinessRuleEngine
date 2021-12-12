using BusinessRuleEngine.Models;
using BusinessRuleEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Products
{
    public class MemberShip : Product
    {
        private IEmailService emailService;
        private UserAccount userAccount;
        public MemberShip(IEmailService emailService, UserAccount userAccount)
        {
            this.emailService = emailService;
            this.userAccount = userAccount;
            this.Name = "Membership";
            this.Description = "Membership";
            this.ProductPaymentActions = new List<string>();
        }
        public override Product FulfilProductOrder()
        {
            ActivateMemberShip();
            emailService.SendEmail("Account is activated", userAccount.EmailId);
            userAccount.IsSentActivationMail= true;
            return this;
        }

        public void ActivateMemberShip()
        {
            this.userAccount.IsUserActivated = true;
            ProductPaymentActions.Add("Accoint is activated");
        }
    }
}
