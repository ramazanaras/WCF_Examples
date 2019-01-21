using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace NorthwindService
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class MusteriService : System.Web.Services.WebService
    {
        KuzeyYeliDataContext db = new KuzeyYeliDataContext();

        [WebMethod]
        public List<MusteriResult> TumunuListele()
        {

            //map ettik(dönüştürdük)
            return db.Musterilers.Select(x => new MusteriResult
            {
                MusteriID=x.MusteriID,
                MusteriAdi=x.MusteriAdi,
                Telefon=x.Telefon,
                SirketAdi=x.SirketAdi


            }
                ).ToList();

        }
    }



    //DTO sınıfı
    public class MusteriResult
    {
        public string MusteriID { get; set; }
        public string SirketAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string Telefon { get; set; }

    }


}


//http://localhost:2499/MusteriService.asmx