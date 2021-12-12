using BusinessRuleEngine;
using Xunit;

namespace BusinessRuleEngineTest
{
    public class RuleEngineTest
    {
        [Fact]
        public void Test1()
        {
           RuleEngine ruleEngine = new RuleEngine();
            ruleEngine.Test();
        }
    }
}