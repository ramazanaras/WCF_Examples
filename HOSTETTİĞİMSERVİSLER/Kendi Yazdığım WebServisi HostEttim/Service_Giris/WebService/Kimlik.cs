using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Services.Protocols;//eklendi

namespace WebService
{
    public class Kimlik : SoapHeader
    {
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }





    }
}


