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
        public MemberShip(IEmailService emailService)
        {
            this.emailService = emailService;
        }
        public override Product FulfilProductOrder()
        {
            throw new NotImplementedException();
        }
    }
}
