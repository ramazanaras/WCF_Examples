using System;
using System.Collections.Generic;

namespace KuzeyYeli.ORM.Models
{
    public partial class Kategoriler
    {
        public Kategoriler()
        {
            this.Urunlers = new List<Urunler>();
        }

        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string Tanimi { get; set; }
        public byte[] Resim { get; set; }
        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
