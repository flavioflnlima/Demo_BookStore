using System.Collections.Generic;
using System.Linq;
using BookStore.Context;
using BookStore.Domain;
using BookStore.Repositories.Contracts;

namespace BookStore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookStoreDataContext _db;

        public BookRepository()
        {
            this._db = new BookStoreDataContext();
        }

        public List<Livro> Get(int skip = 0, int take = 25)
        {
            return _db.Books.OrderBy(x => x.Title).Skip(skip).Take(take).ToList();
        }

        public Livro Get(int id)
        {
            return _db.Books.Find(id);
        }

        public List<Livro> GetWithAuthors(int skip = 0, int take = 25)
        {
            return _db.Livro.Include(x => x.Authors).OrderBy(x => x.Title).Skip(skip).Take(take).ToList();
        }

        public Book GetWithAuthors(int id)
        {
            return _db.Books.Include(x => x.Authors).Where(x => x.Id == id).FirstOrDefault();
        }

        public void Create(Book entity)
        {
            _db.Books.Add(entity);
            _db.SaveChanges();
        }

        public void Update(Book entity)
        {
            _db.Entry<Book>(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Books.Remove(_db.Books.Find(id));
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}