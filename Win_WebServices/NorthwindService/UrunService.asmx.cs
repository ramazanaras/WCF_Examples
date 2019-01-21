using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace NorthwindService
{
    /// <summary>
    /// Summary description for UrunService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UrunService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        KuzeyYeliDataContext db = new KuzeyYeliDataContext();//Linq to sql yapısı


        /*
 Hata!
 * Parametresiz oluşturucusu olmadığından System.Data.Linq.Binary seri hale getirilemez.Linq to sqldeki sınıflar serilize edilemediğinden dolayı böyle bir hata veriyor.DTO sınıfı yapmalıyız.UrunlerDTO gibi 
 
 */
        //[WebMethod]
        //public List<Urunler> TumunuListele()
        //{
        //    return db.Urunlers.ToList();
        //}

        public Oturum Oturum { get; set; }


        [WebMethod]
        [SoapHeader("Oturum")]//yukarıdaki propertinin adıdır.
        public List<UrunResult> TumunuListele()//bu metodun çalışmasında headerda oturum bilgisi getirilir.yani bu metoda erişebilmek için oturum bilgisi gerekiyor.
        {
            if (Oturum.KullaniciAdi == "admin" && Oturum.Parola == "123")
            {
                //map ettik.
                return db.Urunlers.Select(x => new UrunResult
                {
                    UrunID = x.UrunID,
                    UrunAdi = x.UrunAdi,
                    Fiyat = x.Fiyat,
                    Stok = x.Stok
                }).ToList();


            }
            else
            {
                return null;
            }
        }



    }


    //DTO sınıfı
    public class UrunResult
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal? Fiyat { get; set; } //nullable
        public short? Stok { get; set; }//nullable

    }


    //güvenlik için bir sınıf oluşturduk.Soapheader protokolü
    public class Oturum : SoapHeader
    {
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }

    }
}


/*
 Hata!
 * Parametresiz oluşturucusu olmadığından System.Data.Linq.Binary seri hale getirilemez.Linq to sqldeki sınıflar serilize edilemediğinden dolayı böyle bir hata veriyor.DTO sınıfı(UrunResult) yapmalıyız.
 
 */