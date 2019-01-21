using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;//ekledik
using WebService.Models;
namespace WebService
{
    /// <summary>
    /// Summary description for UrunlerServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UrunlerServis : System.Web.Services.WebService
    {

        KuzeyYeliContext ctx = new KuzeyYeliContext();//code first mimarisi

        [WebMethod]//internette çalışan bir metod olduğunu belirtmemiz lazım .yoksa masaüstü projesinde  erişemeyiz.
        public string HelloWorld()
        {
            return "Hello World";
        }

        //Hata veriyor.
        //[WebMethod]
        //public List<Urunler> UrunlerListesi()
        //{
        //    return ctx.Urunlers.ToList();
        //}




        public Kimlik KimlikBilgisi { get; set; }

        [WebMethod]
        [SoapHeader("KimlikBilgisi")] //yukarıdakki propertinin ismini verdik //UrunlerListesi mteodu Kimlik tipşinde nesne ile açılır.güvenli kısmını yaptık
        public List<UrunDTO> UrunlerListesi()
        {
            //bu bilgileri doğru girersek Urunler listesini çekebiliriz.Güvenlik protokolü yaptık
            if (KimlikBilgisi.KullaniciAdi == "admin" && KimlikBilgisi.Parola == "123")
            {

                return ctx.Urunlers.Select(x => new UrunDTO
                {
                    BirimdekiMiktar = x.BirimdekiMiktar,   //sol taraf UrunDTO sınıfı,sağ taraf Urunler sınıfı
                    EnAzYenidenSatisMikatari = x.EnAzYenidenSatisMikatari,
                    Fiyat = x.Fiyat,
                    KategoriID = x.KategoriID,
                    Sonlandi = x.Sonlandi,
                    Stok = x.Stok,
                    TedarikciID = x.TedarikciID,
                    UrunAdi = x.UrunAdi,
                    UrunID = x.UrunID,
                    UrunResimUrl = x.UrunResimUrl,
                    YeniSatis = x.YeniSatis
                }).ToList();

            }
            else
            {
                return null;
            }




        }


    }
}


/*
 HATA!
 * Bir arabirim olduğundan System.Collections.Generic.ICollection`1[[WebService.Models.Urunler, WebService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]] türünün WebService.Models.Kategoriler.Urunlers üyesi seri hale getirilemez.
 
 * Çünkü Urunler sınıfında aşağıdaki propertiler olduğundan serilize edilemiyor.O yüzden DTO sınıfı hazırlamamız lazım.(UrunDTO)
 * 
 *   public virtual Kategoriler Kategoriler { get; set; }
        public virtual ICollection<SatisDetay> SatisDetays { get; set; }
        public virtual Tedarikciler Tedarikciler { get; set; }
 * 
 * 
 * 
 */