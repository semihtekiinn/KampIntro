using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                FirstName = "Semih",
                LastName = "Tekin",
                DateOfBirth = new DateTime(1997, 1, 20),
                NationalityId = "12121212121"
            };

            IGamerCheckService callOfDutyGamerManager = new CallOfDutyGamerManager();
            callOfDutyGamerManager.Register("12121212121", "Semih", "Tekin", (1997));

        }
    }

}
