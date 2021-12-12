using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Services
{
    public static class ComboOffers
    {
        public static IDictionary<string, string> GetVideoOffers()
        {
            IDictionary<string, string> offerList = new Dictionary<string, string>();
            offerList.Add("Learning to Ski", "Add a free “First Aid” video to the packing slip"); 

            return offerList;
        }
    }
}
