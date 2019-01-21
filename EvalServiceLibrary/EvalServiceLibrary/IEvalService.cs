using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;//**
using System.ServiceModel;//**
using System.Text;

namespace EvalServiceLibrary
{

    [ServiceContract]  //dışarıya servis edilebilmesini sağlar.
    public interface IEvalService
    {
        [OperationContract]  //dışarıya servis edilebilmesini sağlar.
        void SubmitEval(Eval eval);
        [OperationContract]
        List<Eval> GetEval();

        [OperationContract]
        void RemoveEval(string id);
    }
}
