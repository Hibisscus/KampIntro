using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
     class SepetManager
    {
        public void Ekle(Product productTakmaisim) // sonunda aç kapa parantez varsa  işin içinde method vardır
        { 
            Console.WriteLine("Sepete eklendi : " + productTakmaisim.Adi + " Fiyatı= " + productTakmaisim.Fiyati+"TL" );

        }

        public void Add()
        {

        }
    }
}
