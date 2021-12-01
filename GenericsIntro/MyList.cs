using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //constructor = bir class new'lendiğinde çalışan bloğa constructor denir.

        //MyList<T> adında bir class oluşturduk. items adında bir dizi oluşturduk.
        //ctor tab tab yaparak bir constructor oluşturduk.
        //Add(T item) adında bir metot oluşturduk. Bu metot ile dizimizin içine eleman eklemek istiyoruz.
        //Ama yeni eleman eklemek için bir önceki dizinin boyutunu 1 arttırmamız gerekiyor.
        //items=new T[items.Length+1]; ile yeni bir dizi oluşturuyoruz.
        //Oluşturduğumuz dizi bir önceki diziden bir eleman daha fazla boyutu olan bir dizi.
        //Önceki diziyi T[] tempArray adlı diziye atıyoruz.
        //Daha sonrasında ise for ile tempArray deki elemanları
        //tek tek döndürüp items[i]=tempArray[i] ile items'a atıyoruz.
        //items[items.Length-1]=item; yaparak son eklediğimiz elemanı da dizimizin içine atıyoruz.

        public MyList()
        {
            items = new T[0]; 
        }
        
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

            Console.WriteLine(item+" eklendi.");



        }
        
    }
}
