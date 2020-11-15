using BookStore.Context;
using BookStore.Domain;
using BookStore.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private BookStoreDataContext _db = new BookStoreDataContext();
        public void Create(Autor autor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Autor> Get()
        {
            throw new NotImplementedException();
        }

        public Autor Get(int id)
        {
            throw new NotImplementedException();
        }

        public Autor GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Autor autor)
        {
            throw new NotImplementedException();
        }
    }
}