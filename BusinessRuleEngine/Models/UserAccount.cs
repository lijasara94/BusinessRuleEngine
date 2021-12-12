using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Models
{
    public class UserAccount
    {
        public string UserName  { get; set; }
        public string EmailId { get; set; }

        public bool IsUserActivated { get; set; }
        public bool IsSentActivationMail { get; set; }

        public bool IsUserAccountUpgraded { get; set; }
        public bool IsSentAccountUpgradationMail { get; set; }
    }
}
