using GameProjectDemo.Abstract;
using System;

namespace GameProjectDemo.Entities
{
    //Kodlarımızı yazarken şuna mutlaka dikkat edelim. Somut sınıflar , burdaki gibi 'Gamer.cs',
    //eğer çıplak kalıyorsa, yani herhangi bir inheritance veya implamentasyon almıyorsa,
    //ileri de nesnellik zaafiyeti yaşayacağız. Sırf bu tip kurallar için bir adet interface oluştururuz.
    //IEntity den Gamer.cs'ye implamente edelim.

    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

}
