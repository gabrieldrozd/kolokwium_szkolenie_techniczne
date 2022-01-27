using kolokwium.Models;
using kolokwium.NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kolokwium.API
{
    public class ApiMethods
    {
        public ApiMethods()
        {
            NHibernateBase nHibernateBase = new NHibernateBase();
            nHibernateBase.Initialize();
        }

        public List<Druzyna> GetDruzyna()
        {
            using (var session = NHibernateBase.Session)
            {
                return session.Query<Druzyna>().Select(
                    x => new Druzyna
                    {
                        Id = x.Id,
                        Nazwa = x.Nazwa
                    }).ToList();
            }
        }

        public List<TypRozgrywek> GetTypRozgrywek()
        {
            using (var session = NHibernateBase.Session)
            {
                return session.Query<TypRozgrywek>().Select(
                    x => new TypRozgrywek
                    {
                        Id = x.Id,
                        Nazwa = x.Nazwa
                    }).ToList();
            }
        }
    }
}