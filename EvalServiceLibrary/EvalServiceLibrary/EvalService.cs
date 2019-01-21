using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EvalServiceLibrary
{

    //Tüm Endpointlerden tek bir yere ulaşabilmek için
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EvalService : IEvalService
    {
        private List<Eval> evals = new List<Eval>();
        public void SubmitEval(Eval eval)
        {
            eval.id = Guid.NewGuid().ToString();
            eval.TimeSubmitted = DateTime.Now;
            evals.Add(eval);
        }

        public List<Eval> GetEval()
        {
            return evals;
        }

        public void RemoveEval(string id)
        {
            evals.Remove(evals.Find(e => e.id.Equals(id)));

            //evals.Remove(evals.Find(delegate(Eval e)
            //{
            //    return e.id.Equals(id);

            //}));
        }

    }
}
