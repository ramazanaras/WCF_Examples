using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;//ekledik.
using System.Web;

namespace WcfService
{

    [DataContract] //sınıfın dışarıya açılması için.Sözleşmeye dahil olması için.
    public class UrunDTO
    {

        //virtual propertiler hariç. diğer propertileri aldık.Çünkü o propertiler bu sınıfın serilize edilmesini engelliyor ve hata veriyor.Servis tarafında

        [DataMember] //propertilerin dışarıya açılması için.
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