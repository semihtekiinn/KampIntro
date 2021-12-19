namespace GameProjectDemo.Abstract
{
    //Kodlarımızı yazarken şuna mutlaka dikkat edelim. Somut sınıflar , burdaki gibi 'Gamer.cs',
    //eğer çıplak kalıyorsa, yani herhangi bir inheritance veya implamentasyon almıyorsa,
    //ileri de nesnellik zaafiyeti yaşayacağız. Sırf bu tip kurallar için bir adet interface oluştururuz.
    //IEntity den Gamer.cs'ye implamente edelim.

    public interface IEntity
    {
    }
}