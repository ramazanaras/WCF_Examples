using NorthWindLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel; //eklendi
using System.Text;
using System.Threading.Tasks;


using SurrogateLibrary;//ekledik
namespace NorthwindServiceLibrary
{
    [ServiceContract] //servisi dışarıya sunmak için 
    public interface IProductService
    {

        [OperationContract] //metodu dışarıya açtık
        SurrogateProduct[] GetProducts(int CategoryId);  //Serviste dışarıya DTO sınıfları gönderiyoruz.

        [OperationContract] //metodu dışarıya açtık
        SurrogateProduct[] GetProductByName(string FirstLetter);


    }
}



//referencelara NorthwindLibraryi ekledik
//referencelara SurrogateLibrary ekledik