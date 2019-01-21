using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using WcfService.Models;//ekledik
namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UrunlerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UrunlerService.svc or UrunlerService.svc.cs at the Solution Explorer and start debugging.
    public class UrunlerService : IUrunlerService
    {
        KuzeyYeliContext ctx = new KuzeyYeliContext();
        public string DoWork()
        {
            return "Merhaba WCF";
        }


        //Hata veriyor.
        // Bir arabirim olduğundan System.Collections.Generic.ICollection`1[[WebService.Models.Urunler, WebService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]] türünün WebService.Models.Kategoriler.Urunlers üyesi seri hale getirilemez.
        //public List<Urunler> UrunlerListesi()
        //{
        //    return ctx.Urunlers.ToList();
        //}


        public List<UrunDTO> UrunListesi()
        {

            //Urunler Sınıfını UrunDTO sınıfına map ettik.(dönüştürdük.)
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