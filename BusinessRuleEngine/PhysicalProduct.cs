using BusinessRuleEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class PhysicalProduct : IOrderFulfilment, IGeneratePackingSlip, IGenerateAgentCommission
    {
        public void FulfilOrder()
        {
            GeneratePackingSlip();
            GenerateAgentCommision();
        }

        public void GenerateAgentCommision()
        {
            Console.WriteLine("Generate Agent Commision");
        }

        public void GeneratePackingSlip()
        {
            Console.WriteLine("Generate Packiing Slip for Shipping");
        }
    }
}
