using AdventureWorksSurrogateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdventureWorksServiceApplication
{

    [ServiceContract] //dış dünyaya açtık
    public interface IProductionService
    {
        [OperationContract]  //dış dünyaya açtık
        //BusinessLibrarydeki metotlar aslında buradakiler
        List<ProductSurrogate> GetProductBySubCategory(int SubCategoryId); //Servis dışarıya DTO(Surrogate) sınıfı yollar.


    }
}
