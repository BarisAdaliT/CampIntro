using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //T eleman türü
    //ne tip eleman vericegimi bilmiyorum cod sırasında ben buna karar vericem -
    //-sen sadece sana eleman vericegimden haberdar ol
    class MyList<T>
    {
        // T tipine sahip Items adında bir dizi olusturdum
        T[] Items;
        //constructor
        //ben Items'ı kulandıgım anda otomatik çalısan çagırma gereksimi olmayan bir fonk
        public MyList()
        {
            //Items degişkeninin hafızada nasıl tutulacagına burada karar verdim 
            Items = new T[0];
        }
        public void Add(T item)
        {
            // Items dizisinin referans numarasını(bellekteki yerini) tempArray dizisine verdim
            // bu sayede Items dizisinin içinde ki degerleri kaybetmedim 
            T[] tempArray = Items;
            //her yeni bir eleman eklemek istedigimde dizinin eleman sayısını artırıyorum 
            Items = new T[Items.Length + 1];
            //yukarıda Items dizisi (new) yuzunden yeni bir referans noktası alıcak
            // eski referans noktasını tekrar atmak için tempArray ile esitleyerek referans noktasını geri-
            //-kazandım
            // dizinin her elemanı için dönmesi lazım
            for (int i = 0; i < tempArray.Length; i++)
            {
                Items[i] = tempArray[i];
            }
            //Items dizisinde boş ver acıtıltan sonra boş yere ekleme işlemini yaptık 
            Items[Items.Length - 1] = item;
        }
    }
}
