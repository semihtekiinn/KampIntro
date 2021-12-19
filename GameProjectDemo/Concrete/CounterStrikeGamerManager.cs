using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class CounterStrikeGamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public CounterStrikeGamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Register(Gamer gamer)
        {
            if (true)
            {
                base.Register(gamer);
                Console.WriteLine("The gamer named "+gamer.FirstName + gamer.LastName +" registered for Counter Strike game.");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }
    }
}
