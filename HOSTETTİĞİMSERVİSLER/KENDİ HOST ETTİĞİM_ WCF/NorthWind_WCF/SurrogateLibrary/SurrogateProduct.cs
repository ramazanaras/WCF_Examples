using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;//referencelara ekledik .(DataContract ve DataMember sınıflarını kullabilmek için)
namespace SurrogateLibrary
{
    //DTO SINIFIMIZ (Serviste dışarıya DTO sınıflarını yollucaz)
    [DataContract]
    public class SurrogateProduct
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public int? CategoryId { get; set; }


    }
}
