using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksSurrogateLibrary
{
    //DTO SINIFIMIZ
    public class ProductSurrogate
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }
        public int? ProductSubCategoryId { get; set; }
        public string Class { get; set; }
    }
}
