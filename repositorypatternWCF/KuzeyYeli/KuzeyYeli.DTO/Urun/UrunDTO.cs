using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.DTO.Urun
{
    //DTO projesinin referencelarına System.ServiceModel ve System.Runtime.Serilization dll'lerini ekliyoruz. [DataContract] [DataMember]  attributelerinin çıkması için.

    [DataContract]//dışarıya açılması için
    public class UrunDTO //DTO sınıfını yapmamızın amacı Urunler sınıfını Serilize edilebilir şekle getirmek.
    {
        //virtual hariç propertileri ekledik.


        [DataMember]//dışarıya açılması için
        public int UrunID { get; set; }
        [DataMember]
        public string UrunAdi { get; set; }
        [DataMember]
        public Nullable<int> TedarikciID { get; set; }
        [DataMember]
        public Nullable<int> KategoriID { get; set; }
        [DataMember]
        public string BirimdekiMiktar { get; set; }
        [DataMember]
        public Nullable<decimal> Fiyat { get; set; }
        [DataMember]
        public Nullable<short> Stok { get; set; }
        [DataMember]
        public Nullable<short> YeniSatis { get; set; }
        [DataMember]
        public Nullable<short> EnAzYenidenSatisMikatari { get; set; }
        [DataMember]
        public bool Sonlandi { get; set; }
        [DataMember]
        public string UrunResimUrl { get; set; }

    }
}
