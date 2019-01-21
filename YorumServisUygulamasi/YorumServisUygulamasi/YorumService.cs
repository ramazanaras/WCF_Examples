using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YorumServisUygulamasi
{
    public class YorumService : IYorumService
    {
        List<Yorum> yorumozel = new List<Yorum>();
        public void YorumYaz(Yorum yorum)
        {
            yorum.YorumID = Guid.NewGuid().ToString();
            yorumozel.Add(yorum);

        }

        public List<Yorum> YorumListesi()
        {
            return yorumozel;
        }

        public void YorumSil(string ID)
        {
            yorumozel.Remove(yorumozel.FirstOrDefault(x => x.YorumID == ID));

        }
    }
}
