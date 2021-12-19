using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("The player named "+gamer.FirstName+" "+gamer.LastName+" deleted from the system.");
        }

        public virtual void Register(Gamer gamer)
        {
            Console.WriteLine("The player named " + gamer.FirstName + " " + gamer.LastName + " registered to the system.");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "'s information updated.");
        }
    }
}
