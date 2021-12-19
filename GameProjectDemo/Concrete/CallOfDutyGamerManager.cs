using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class CallOfDutyGamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public CallOfDutyGamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Register(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer.NationalityId, gamer.FirstName, gamer.LastName, gamer.DateOfBirth.Year))
            {
                base.Register(gamer);
                Console.WriteLine("The gamer named " + gamer.FirstName + gamer.LastName + " registered for Call Of Duty game.");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }


    }
}
