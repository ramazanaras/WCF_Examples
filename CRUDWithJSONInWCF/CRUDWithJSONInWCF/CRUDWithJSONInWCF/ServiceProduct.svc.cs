using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CRUDWithJSONInWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceProduct" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceProduct.svc or ServiceProduct.svc.cs at the Solution Explorer and start debugging.
    public class ServiceProduct : IServiceProduct
    {
        public List<Product> findAll()
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                return mde.ProductEntities.Select(pe => new Product  //DTO Nesnesine dönüştürüyoruz(Serileştirme hatası vermemesi için ara bir tipe dönüştürdük)
                {

                    Id = pe.Id,
                    Name = pe.Name,
                    Price = pe.Price.Value,
                    Quantity = pe.Quantity.Value

                }).ToList();

            }
        }

        public Product find(string id)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                int nid = Convert.ToInt32(id);
                return mde.ProductEntities.Where(pe => pe.Id == nid).Select(pe => new Product  //DTO Nesnesine dönüştürüyoruz
                {

                    Id = pe.Id,
                    Name = pe.Name,
                    Price = pe.Price.Value,
                    Quantity = pe.Quantity.Value

                }).First();

            }
        }

        public bool create(Product product)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                try
                {
                    ProductEntity pe = new ProductEntity();
                    pe.Name = product.Name;
                    pe.Price = product.Price;
                    pe.Quantity = product.Quantity;
                    mde.ProductEntities.Add(pe);
                    mde.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }


            }
        }

        public bool edit(Product product)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                try
                {
                    int id = Convert.ToInt32(product.Id);
                    ProductEntity pe = mde.ProductEntities.Single(p => p.Id == id);
                    pe.Name = product.Name;
                    pe.Price = product.Price;
                    pe.Quantity = product.Quantity;
                    mde.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }


            }
        }


        public bool delete(Product product)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                try
                {
                    int id = Convert.ToInt32(product.Id);
                    ProductEntity pe = mde.ProductEntities.Single(p => p.Id == id);
                    mde.ProductEntities.Remove(pe);
                    mde.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }


            }
        }


    }
}
