using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EntityService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EntityService.svc or EntityService.svc.cs at the Solution Explorer and start debugging.
    public class EntityService : IEntityService
    {

        public object Listele()
        {
        

            return "Naber";
        }

        public bool Ekle()
        {
            throw new NotImplementedException();
        }

        public bool Guncelle()
        {
            throw new NotImplementedException();
        }

        public bool Sil()
        {
            throw new NotImplementedException();
        }

        public Urun UrunSec(int id)
        {
            throw new NotImplementedException();
        }

        public void ResetContext()
        {
            throw new NotImplementedException();
        }
    }
}
