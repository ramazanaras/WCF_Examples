using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.WCFService
{
    [ServiceContract]//dışarıya açılması için
    public interface IServiceBase<DTO>
    {

        [OperationContract] //dışarıya açılması için
        IQueryable<DTO> Listele();
        [OperationContract]
        bool Ekle(DTO entity);
        [OperationContract]
        bool Guncelle(DTO entity);
        [OperationContract]
        bool Sil(DTO entity);

    }
}
