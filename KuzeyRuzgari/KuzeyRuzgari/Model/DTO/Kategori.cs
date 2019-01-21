using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyRuzgari.Model.DTO
{
    [DataContract] //dış dünyaya açıyoruz
    public class Kategori
    {
        [DataMember] //dış dünyaya açıyoruz
        public int KategoriID { get; set; }

        [DataMember] //dış dünyaya açıyoruz
        public string KategoriAdi { get; set; }




    }
}
