using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Services
{
    public interface IEmailService
    {
        public void SendEmail(string message, string toAddress);
    }
}
