using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel; //referencelara ekledik. (ServiceContract ve OperationContractları kullabilmek için )

namespace MathLib
{
    [ServiceContract(Name = "MathOperationService", Namespace = "http://www.azon.com/MathOperations/MathService")] //Servisi dışarıya sunmak için
    public interface IMathOperations
    {
        [OperationContract] //metodu dışarıya sunmak için
        int Topla(int x, int y);

        [OperationContract]
        int Carp(int x, int y);

        
        int Bol(int x, int y);
    }
}


