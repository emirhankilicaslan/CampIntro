using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //Method syntax
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler, sepete eklendi : " + product.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, sepete eklendi: " + urunAdi);
        }
    }
}
