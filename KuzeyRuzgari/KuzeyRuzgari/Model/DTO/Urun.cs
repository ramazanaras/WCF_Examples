using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyRuzgari.Model.DTO
{
    [DataContract] //dış dünyaya açıyoruz
    public class Urun
    {
        [DataMember]  //dış dünyaya açıyoruz
        public int UrunID { get; set; }
        [DataMember]
        public string UrunAdi { get; set; }
        [DataMember]
        public short? Stok { get; set; }


    }
}
