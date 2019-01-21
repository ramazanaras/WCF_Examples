using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEntityService" in both code and config file together.
    [ServiceContract]
    public interface IEntityService
    {
        [OperationContract]//dışarıya açılması için
        object Listele();
        [OperationContract]
        bool Ekle();
        [OperationContract]
        bool Guncelle();
        [OperationContract]
        bool Sil();

        [OperationContract]
        Urun UrunSec(int id);
        void ResetContext();//dışarı açmıyoruz
    }

    [DataContract]//dışarıya açılması için.sözleşmeye dahil ettik
    public class Urun
    {
        [DataMember]//dışarıya açılması için.sözleşmeye dahil ettik
        public int UrunID { get; set; }
        [DataMember]
        public string UrunAdi { get; set; }
        [DataMember]
        public decimal Fiyat { get; set; }
        [DataMember]
        public short Stok { get; set; }

    }





}
