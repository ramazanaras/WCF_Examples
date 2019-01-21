using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IstConsumer.ServiceReference1;
namespace IstConsumer
{

  
    class Program
    {
        IstConsumer.ServiceReference1.ProductionServiceClient client = new IstConsumer.ServiceReference1.ProductionServiceClient("ProductionWsEndPoint");
        static void Main(string[] args)
        {
            
        }
    }
}
