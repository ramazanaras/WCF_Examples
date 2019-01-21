using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;   //ekledik
using System.Text;
using System.Threading.Tasks;

namespace YorumServisUygulamasi
{
    [ServiceContract]  //dış dünyaya açılıyor
    public interface IYorumService
    {
        [OperationContract] //dış dünyaya açılıyor
        void YorumYaz(Yorum yorum);

        [OperationContract] //dış dünyaya açılıyor
        List<Yorum> YorumListesi();


        [OperationContract] //dış dünyaya açılıyor
        void YorumSil(string ID);


    }
}
