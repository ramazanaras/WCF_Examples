using KuzeyRuzgari.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyRuzgari.Service
{
    [ServiceContract]  //dış dünyaya açıyoruz
    public interface IProduct
    {
        [OperationContract] //dış dünyaya açıyoruz
        List<KuzeyRuzgari.Model.DTO.Urun> GetAllProduct();





    }
}
