using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //servisi tanımladık
            ProductServiceConsumer.ProductServiceClient client = new ProductServiceConsumer.ProductServiceClient("BasicHttpBinding_IProductService");//endpointteki namespacei verdik.
            var list = client.GetProducts(1);



            Console.Read();
        }
    }
}
