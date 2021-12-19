using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Order(Product product)
        {
            if (product.Name=="Cs:Go")
            {
                _campaignService.Add(product);
                Console.WriteLine(product.Name + " satışı yapıldı.");
            }
            else
            {
                Console.WriteLine("Oyun bulunamadı.");
            }
        }
    }
}
