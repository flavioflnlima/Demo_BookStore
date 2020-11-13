using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repositories.Contracts
{
    public interface IAuthorRepository : IDisposable
    {
        List<Autor> Get();
        Autor Get(int id);
        Autor GetByName(string name);
        void Create(Autor autor);
        void Update(Autor autor);
        void Delete(int id);
    }
}
