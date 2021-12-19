using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " oyununun kampanyası oluşturuldu. ");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.Name+" oyununun kampanyası silindi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " oyununun kampanyası güncellendi.");
        }
    }
}
