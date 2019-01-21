using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;//eklendi
using System.Text;

namespace EvalServiceLibrary
{
    [DataContract]//client tarafında ulaşabilmek için
    public class Eval
    {
        [DataMember]  //client tarafında ulaşabilmek için
        public string id { get; set; }
        [DataMember]
        public string Submitter { get; set; }
        [DataMember]
        public string Commets { get; set; }
        [DataMember]
        public DateTime TimeSubmitted { get; set; }

    }
}
