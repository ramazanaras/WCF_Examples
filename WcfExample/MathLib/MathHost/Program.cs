using MathLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ekledik
using System.ServiceModel;
using System.ServiceModel.Description;
namespace MathHost
{
    class Program
    {
        static void Main(string[] args)
        {

            //CONSOLE UI üzerinden servisi host ediyoruz.

            Uri baseAddress=new Uri("http://localhost:59680/AzonServices/MathOperationService/");
            ServiceHost host = new ServiceHost(typeof(MathOperations), baseAddress);
            host.AddServiceEndpoint(typeof(IMathOperations), new WSHttpBinding(), baseAddress.ToString());

            ServiceMetadataBehavior metadataBehaviour = new ServiceMetadataBehavior();
            metadataBehaviour.HttpGetEnabled = true;

            host.Description.Behaviors.Add(metadataBehaviour);

            host.Open();
            Console.WriteLine(host.State.ToString());
            Console.WriteLine("Servis açık durdurmak için bir tuşa basın");
            Console.ReadLine();
            host.Close();
            Console.WriteLine(host.State.ToString());

            Console.Read();
        }
    }
}

//referencelara MathLib projesini ekledik.
//referencelara System.ServiceModel 'i ekledik. (ServiceHost sınıfını kullabilmek için)