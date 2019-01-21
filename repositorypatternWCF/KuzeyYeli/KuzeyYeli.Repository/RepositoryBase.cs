using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Entity;//ekledik manage nugettan entity framework eklemiştik.Entityframework.dll'den gelir.
using KuzeyYeli.ORM.Models;//ekledik
namespace KuzeyYeli.Repository
{
    public class RepositoryBase<T> : IEntityRepository<T> where T:class
    {
        //SIngleton Pattern(Hep aynı contexti kullanma mantığıdır.)(Ramde bir tane context nesnesi var.Herkes onu kullanır diyoruz)
      static  KuzeyYeliContext context;  //Her RepositoryBase sınıfı çağırıldığında yeni bir context üretecek.Bunun önüne geçmek için başına static yaptıkki.tek bir context oluştursun(Ortak bir instance üretmek için static yaptık)
        public  KuzeyYeliContext Context
        {
            get {
                if (context == null)
                    context = new KuzeyYeliContext();
                return context;
            }
            set { context = value; }
        }
      //==============
       



        public IQueryable<T> Listele()
        {
            return Context.Set<T>();//urun gönderirsem urun çekicek.kategori gönderirsem kategori çekicek gibi
            //Hata:Error	1	The type 'T' must be a reference type in order to use it as parameter 'TEntity' in the generic type or method 'System.Data.Entity.DbContext.Set<TEntity>()'	C:\Users\RAMAZAN\Desktop\KuzeyYeli\KuzeyYeli.Repository\RepositoryBase.cs	32	20	KuzeyYeli.Repository
            //yani diyorki T tipi refences tipli olmalı o yüzden yukarıda  where T:class bu şekilde ekledik
        }

        public bool Ekle(T entity)
        {
            try
            {
                Context.Set<T>().Add(entity);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                //hata loglaması yapılmalı
                return false;
               
            }
        }

        public bool Guncelle()
        {
            try
            {
                Context.SaveChanges();//değişiklikleri kaydet dememiz yeterli
                return true;
            }
            catch (Exception)
            {
                  //hata loglaması yapılmalı
                return false;
            }
        }

        public bool Sil(T entity)
        {
            try
            {
                Context.Set<T>().Remove(entity);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                //hata loglaması yapılmalı
                //System.Diagnostic içinde StackTrace Sınıfı ile loglama yapabilirsiniz
                return false;
               
            }
        }


        //tek bir nesne çekmek için
        public virtual T ElemanSec(int id) //ezebilmek için virtual yaptık 
        {
            return null;
        }
    }
}
