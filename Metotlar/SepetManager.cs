using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product product)
        {

            Console.WriteLine("tebrikler.spete eklendi : " + product.Adi);
            //
            //
            //
        }

        public void Ekle2(string urunAdi , string aciklama , double fiyat, int stokAdedi)
        {
            Console.WriteLine("tebrikler.spete eklendi : " + urunAdi);
        }

    }
}
