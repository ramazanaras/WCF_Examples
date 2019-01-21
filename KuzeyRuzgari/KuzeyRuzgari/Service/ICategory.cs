using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel; //ekledik
using System.Text;
using System.Threading.Tasks;

namespace KuzeyRuzgari.Service
{
    [ServiceContract] //dış dünyaya açmak için
    public interface ICategory
    {
        [OperationContract]  //dış dünyaya açmak için
        List<KuzeyRuzgari.Model.DTO.Kategori> GetAllCategories();



    }
}
