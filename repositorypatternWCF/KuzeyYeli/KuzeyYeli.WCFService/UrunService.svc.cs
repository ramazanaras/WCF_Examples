using KuzeyYeli.DTO.Urun;
using KuzeyYeli.ORM.Models;
using KuzeyYeli.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KuzeyYeli.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UrunService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UrunService.svc or UrunService.svc.cs at the Solution Explorer and start debugging.
    public class UrunService : IUrunService
    {
        UrunRepository repository = new UrunRepository();

        public IQueryable<UrunDTO> Listele()
        {
            //map işlemi (Urunler sınıfını UrunDTO'ya dönüştürme)
            return repository.Listele().Select(x => new UrunDTO
            {
                BirimdekiMiktar = x.BirimdekiMiktar,
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
            });
        }

        public bool Ekle(UrunDTO entity)
        {
         //map işlemi (UrunDTO'yu sınıfını Urunler'e dönüştürme)
            Urunler urn=new Urunler{
             BirimdekiMiktar = entity.BirimdekiMiktar,
                EnAzYenidenSatisMikatari = entity.EnAzYenidenSatisMikatari,
                Fiyat = entity.Fiyat,
                KategoriID = entity.KategoriID,
                Sonlandi = entity.Sonlandi,
                Stok = entity.Stok,
                TedarikciID = entity.TedarikciID,
                UrunAdi = entity.UrunAdi,
                UrunID = entity.UrunID,
                UrunResimUrl = entity.UrunResimUrl,
                YeniSatis = entity.YeniSatis
            
            
            };

            return repository.Ekle(urn);//repository bizden entity ister.DTO istemez.
        }

        public bool Guncelle(UrunDTO entity)
        {
            Urunler gun = repository.ElemanSec(entity.UrunID);

                gun.BirimdekiMiktar = entity.BirimdekiMiktar;
                gun.EnAzYenidenSatisMikatari = entity.EnAzYenidenSatisMikatari;
                gun.Fiyat = entity.Fiyat;
                gun.KategoriID = entity.KategoriID;
                gun.Sonlandi = entity.Sonlandi;
                gun.Stok = entity.Stok;
                gun.TedarikciID = entity.TedarikciID;
                gun.UrunAdi = entity.UrunAdi;
                gun.UrunResimUrl = entity.UrunResimUrl;
                gun.YeniSatis = entity.YeniSatis;

           return repository.Guncelle();//değişiklikleri kaydettik.(güncelledik.)
        }

        public bool Sil(UrunDTO entity)
        {
            Urunler gun = repository.ElemanSec(entity.UrunID);
            return repository.Sil(gun);

        }
    }
}
