using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Repository
{
    public interface IEntityRepository<T>
    {
        IQueryable<T> Listele();
        bool Ekle(T entity);
        bool Guncelle();
        bool Sil(T entity);

        T ElemanSec(int id);

    }
}
