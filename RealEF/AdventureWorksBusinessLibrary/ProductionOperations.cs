using AdventureWorksEntityLibrary;
using AdventureWorksSurrogateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace AdventureWorksBusinessLibrary
{
    public class ProductionOperations
    {
        //Arayüze DTO sınıfları yolluyoruz
        public List<ProductSurrogate> GetProductBySubCategory(int SubCategoryId)
        {

            List<ProductSurrogate> result = new List<ProductSurrogate>();

            AdventureWorks2012Entities context = new AdventureWorks2012Entities();
            result = (from p in context.Products
                      where p.ProductSubcategoryID == SubCategoryId
                      orderby p.Name
                      select new ProductSurrogate    //DTO sınıfına dönüştürdük.Arayüze DTO sınıfları yolluyoruz.(Service uygulaması Arayüze DTO sınıfları göndercek.) 
                      {
                          ProductId = p.ProductID,
                          Class = p.Class,
                          ListPrice = p.ListPrice,
                          Name = p.Name,
                          ProductSubCategoryId = p.ProductSubcategoryID.Value


                      }).ToList();






            return result;

        }



    }
}
