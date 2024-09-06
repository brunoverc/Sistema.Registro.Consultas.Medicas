using Microsoft.EntityFrameworkCore;
using SRCM.Core.DomainObjects;
using SRCM.Domain.Interfaces;
using SRCM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly SRCMDbContext Db;
        protected readonly DbSet<T> DbSet;

        public Repository(SRCMDbContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        protected IQueryable<T> query()
        {
            return DbSet;
        }

        public void Dispose()
        {
            Db?.Dispose();
            GC.SuppressFinalize(this);
        }

        public long Count()
        {
            return DbSet.LongCount();
        }

        public long Count(Expression<Func<T, bool>> predicate)
        {
            var result = DbSet.LongCount(predicate);
            return result;
        }
    }
}
