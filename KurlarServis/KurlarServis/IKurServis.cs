using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KurlarServis
{

    [ServiceContract]
    public interface IKurServis
    {
        [OperationContract]//metodun dışarıya açılmasını sağlar
        List<string> ParaBirimleriGetir();


        [OperationContract]
        List<double> KurlariGetir(string kurTipi);

    }
}
