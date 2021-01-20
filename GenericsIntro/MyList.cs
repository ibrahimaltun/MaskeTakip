using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T:Type:Tip'den geliyor.
        //T nin amacı;kullanıcı new'lerken verdiği
        //tipe göre özellikler çalışır.
    {
        T[] items;
        //constructor;
        //bir blok çalıştıırıldığında çalışan yere denir.
        //constructor bir method'dur ve ile aynı isimdedir.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //item:eleman
        {
            T[] tempArray = items;//tempArray : Geçici Dizi
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
