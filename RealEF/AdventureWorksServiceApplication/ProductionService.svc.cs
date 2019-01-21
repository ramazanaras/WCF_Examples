using AdventureWorksBusinessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdventureWorksServiceApplication
{
   
    public class ProductionService : IProductionService
    {
        ProductionOperations operation = new ProductionOperations();  //Business layerdaki  classımız
        public List<AdventureWorksSurrogateLibrary.ProductSurrogate> GetProductBySubCategory(int SubCategoryId)
        {
            return operation.GetProductBySubCategory(SubCategoryId);
        }

    }
}


///*Service katmanındaki webconfige connectionstring ekliyoruz.yoksa servisten veri çekerken hata verir.
// * 
// //* <connectionStrings>
// ////   <add name="AdventureWorks2012Entities" connectionString="metadata=res://*///AdventureWorksModel.csdl|res://*/AdventureWorksModel.ssdl|res://*/AdventureWorksModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.;initial catalog=AdventureWorks2012;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
// // </connectionStrings>
 
 
 
// */