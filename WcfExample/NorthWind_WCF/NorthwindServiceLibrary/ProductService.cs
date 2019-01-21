using SurrogateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//projeye manage nugettan entity framework yükledik.(Tolist,FirstOrDefault metotlarının çıkması için. yada p.CategoryID gibi ifadelerin çıkması için )

namespace NorthwindServiceLibrary
{
    public class ProductService : IProductService
    {
        //Service dışarıya DTO sınıfları göndercek (istemciye sadece DTO sınıfları veriyoruz.entity sınıfları vermiyoruz)
        public SurrogateProduct[] GetProducts(int CategoryId)
        {

            List<SurrogateProduct> products = new List<SurrogateProduct>();


            using (NorthWindLibrary.NorthwindEntities model = new NorthWindLibrary.NorthwindEntities())
            {
     
                products = (from p in model.Products
                           where p.CategoryID == CategoryId
                           select new SurrogateProduct
                           {
                               CategoryId=p.CategoryID,
                               ProductId=p.ProductID,
                               ProductName=p.ProductName


                           }).ToList<SurrogateProduct>();
            } 

            return products.ToArray();



        }

        public SurrogateProduct[] GetProductByName(string FirstLetter)
        {
            List<SurrogateProduct> products = new List<SurrogateProduct>();


            using (NorthWindLibrary.NorthwindEntities model = new NorthWindLibrary.NorthwindEntities())
            {

                products = (from p in model.Products
                            where p.ProductName.ToUpper().Contains(FirstLetter.ToUpper()) 
                            select new SurrogateProduct
                            {
                                CategoryId = p.CategoryID,
                                ProductId = p.ProductID,
                                ProductName = p.ProductName


                            }).ToList<SurrogateProduct>();
            }

            return products.ToArray();
        }
    }
}
