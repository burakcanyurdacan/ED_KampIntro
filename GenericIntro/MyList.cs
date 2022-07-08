using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor = yapıcı metot. İçine oluşturulmak istenen parametre yazılır ve constructor'un içinde bulunduğu class çağırıldığında otomatik olarak çalışır.
        public MyList()
        {
            //Kendi generic listemi oluştururken, yapıcı metodun içinde 0 elemanlı bir dizi oluşturuyorum. Heap adresi veriyorum.
            items = new T[0];
        }
        public void Add(T item)
        {
         //Add metodu çağrıldığında, mevcuttaki 0 elemanlı dizimin sayısını 1 arttırıyorum. Dışarıdan gelen parametreyi de dizinin yeni index'ine aktarıyorum. Ancak her seferinde yenileme işlemi yapıldığı için heap adresi değişiyor. Bunun önüne geçmek için önce tempArray isminde bir geçici dizi oluşturup, heap'te items dizimin referans numarasını ve eğer elemanım varsa elemanlarımı ona tutturuyorum. Böylelikle veri kaybı olmuyor.
         //Sonra for döngüsüyle tempArray içindeki eleman sayısı kadar dönüp, yeni heap adresiyle oluşturduğum items dizime, temp'teki eski elemanlarımı aynı index'lerine geri yerleştiriyorum. For döngüsü bittikten sonra, items dizisinin eleman sayısının 1 eksiği olan index'e, dışarıdan gelen değeri yazdırıyorum.

            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        //Bu metot bir sonraki dersin konusudur.
        public T[] GetItems
        {
            get { return items; }
        }
    }
}
