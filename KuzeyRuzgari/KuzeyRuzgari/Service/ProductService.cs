using KuzeyRuzgari.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyRuzgari.Service
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)] //Tüm servisler tek bir instance üzerinden çalışssın
    public class ProductService : IProduct, ICategory
    {
        NorthwindEntities db = new NorthwindEntities();
        public List<Model.DTO.Urun> GetAllProduct()
        {
            //MAPPING YAPTIK
            return db.Products.Select(x => new KuzeyRuzgari.Model.DTO.Urun
                 {
                     UrunID = x.ProductID,
                     UrunAdi = x.ProductName,
                     Stok = x.UnitsInStock

                 }).ToList(); //dış dünyaya DTO sınıflarını gönderiyoruz. 
        }

        List<Model.DTO.Kategori> ICategory.GetAllCategories()
        {
            //MAPPING YAPTIK
            return db.Categories.Select(x => new KuzeyRuzgari.Model.DTO.Kategori
            {
                KategoriID = x.CategoryID,
                KategoriAdi = x.CategoryName

            }).ToList();   //dış dünyaya DTO sınıflarını gönderiyoruz. 
        }  
    }
}
