using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1=new Gamer { Id = 1, BirthYear = 1997, FirstName = "SEMİH", LastName = "TEKİN", IdentityNumber = 12345 };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Update(gamer1);



            Product product1 = new Product { Name = "Cs:Go" };
            CampaignManager campaignManager = new CampaignManager();
            OrderManager orderManager = new OrderManager(campaignManager);
            
            orderManager.Order(product1);
            
            campaignManager.Add(product1);
            campaignManager.Update(product1);
            campaignManager.Delete(product1);


        }
    }
}
