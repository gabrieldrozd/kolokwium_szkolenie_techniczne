using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.NHibernate;

namespace WebApplication1.API
{
    public class Kolokwium_API
    {
        public Kolokwium_API()
        {
            NHibernateBase nHibernate = new NHibernateBase();
            nHibernate.Initialize();
        }

        public void AddBook(Book book)
        {
            using (var session = NHibernateBase.Session)
            {
                session.Save(book);
            }
        }

        public List<IdName> GetBookTypes()
        {
            using (var session = NHibernateBase.Session)
            {
                return session.Query<BookType>().Select(
                    x => new IdName
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList();
            }
        }
    }
}