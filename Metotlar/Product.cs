using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class Product
    {
        //ürünü anlatan bir veri tipi
        //property --> özellikler
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }

        public int stokAdedi { get; set; }
    }
}
