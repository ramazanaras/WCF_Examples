using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization; //eklendi
using System.Text;
using System.Threading.Tasks;

namespace YorumServisUygulamasi
{
    [DataContract]    //Serilize edilmesini sağlıyoruz 
    public class Yorum
    {
        [DataMember]
        public string YorumID { get; set; }

        [DataMember]
        public string YorumYazanKisi { get; set; }

            [DataMember]
        public string YorumIcerik { get; set; }


    }
}
