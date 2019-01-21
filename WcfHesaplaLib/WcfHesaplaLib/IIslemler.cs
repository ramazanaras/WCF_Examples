using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfHesaplaLib
{
    [ServiceContract]    //dış dünyaya açıyoruz
    public interface IIslemler
    {

        [OperationContract] //dış dünyaya açıyoruz
        int SayilariTopla(int sayi1,int sayi2);

        [OperationContract]
        int SayilariCikar(int sayi1,int sayi2);


    }
}
