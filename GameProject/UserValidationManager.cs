using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
         public bool Validate(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.BirthYear==1997 && gamer.FirstName=="SEMİH" && gamer.LastName=="TEKİN" && gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        
    }
}
