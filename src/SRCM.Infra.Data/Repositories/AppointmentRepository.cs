using SRCM.Domain.Entities;
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
    public class AppointmentRepository : Repository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(SRCMDbContext context) : base(context) { }

        public Appointment Add(Appointment entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public Appointment GetById(Guid id)
        {
            var context = DbSet.AsQueryable();
            var appointment = context.FirstOrDefault(c => c.Id == id);
            return appointment;
        }

        public void Remove(Guid id)
        {
            var obj = GetById(id);
            if (obj != null)
            {
                DbSet.Remove(obj);
            }
        }

        public void Remove(Expression<Func<Appointment, bool>> predicate)
        {
            var context = DbSet.AsQueryable();
            var entities = context.Where(predicate);

            DbSet.RemoveRange(entities);
        }

        public IEnumerable<Appointment> Search(Expression<Func<Appointment, bool>> predicate)
        {
            var context = DbSet.AsQueryable();
            var entities = context.Where(predicate);
            return entities;
        }

        public IEnumerable<Appointment> Search(Expression<Func<Appointment, bool>> predicate, int pageNumber, int pageSize)
        {
            var context = DbSet.AsQueryable();
            var entities = context.Where(predicate).Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return entities;
        }

        public Appointment Update(Appointment entity)
        {
            DbSet.Update(entity);
            return entity;
        }
    }
}
