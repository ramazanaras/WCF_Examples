using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUrunlerService" in both code and config file together.
    [ServiceContract] //servisin dışarıya açılması için
    public interface IUrunlerService
    {
        [OperationContract]//metodun dışarıya açılması için
        string DoWork();

        [OperationContract]
        List<UrunDTO> UrunListesi();


    }
}
