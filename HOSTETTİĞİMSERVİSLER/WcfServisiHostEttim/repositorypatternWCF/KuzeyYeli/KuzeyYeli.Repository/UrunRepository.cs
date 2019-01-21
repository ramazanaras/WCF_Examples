using KuzeyYeli.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Repository
{
    public class UrunRepository : RepositoryBase<Urunler>
    {
        //Ürün ile ilgili işlerden sorumlu sınıftır.

        //RepositoryBase sınıfındaki metotları burda düşün.
        //Listele ,ekle,guncelle,sil metotları tanımlı olmuş oluyor burda

        //public UrunRepository()
        //{
        //    //Örnek bunun gibi
        //    UrunRepository rep = new UrunRepository();
        //    rep.Ekle(new Urunler());
        //    rep.Listele();
        //}


        //Extra metotlarda yazabiliriz burda

        public bool ZamYap(int urunID ,decimal oran)
        {
            try
            {
                Urunler u = Context.Urunlers.SingleOrDefault(x => x.UrunID == urunID);
                u.Fiyat *= oran;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        //virtual tanımlı metodu burda ezdik.
        public override Urunler ElemanSec(int id)
        {
            return Context.Urunlers.SingleOrDefault(x => x.UrunID == id);
        }

    }
}
