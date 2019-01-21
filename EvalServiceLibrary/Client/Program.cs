using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            

            EvalServiceReference.EvalServiceClient client = new EvalServiceReference.EvalServiceClient();
            client.SubmitEval(new EvalServiceReference.Eval
            {
            Commets="Ramazan",
            Submitter="Ali"
            
            
            
            });

            client.SubmitEval(new EvalServiceReference.Eval
            {
                Commets = "Mehmet",
                Submitter = "ayşe"



            });

            var data = client.GetEval();



            Console.Read();
        }
    }
}
