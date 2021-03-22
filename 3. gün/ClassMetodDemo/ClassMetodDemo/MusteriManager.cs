using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    public class MusteriManager
    {
        void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "Musteri eklendi");
        }
       void Remove(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "Musteri silindi");
        }
        void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "musteri güncellendi");
        }

    }
}
