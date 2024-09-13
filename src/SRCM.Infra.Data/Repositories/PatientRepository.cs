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
    public class PatientRepository : Repository<AppointmentScheduling>, IAppointmentSchedulingRepository
    {
        public PatientRepository(SRCMDbContext context) : base(context)
        {
        }

        public AppointmentScheduling Add(AppointmentScheduling entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public AppointmentScheduling GetById(Guid id)
        {
            var context = DbSet.AsQueryable();
            var patient = context.FirstOrDefault(c => c.Id == id);
            return patient;
        }

        public void Remove(Guid id)
        {
            var obj = GetById(id);
            if (obj != null)
            {
                DbSet.Remove(obj);
            }
        }

        public void Remove(Expression<Func<AppointmentScheduling, bool>> predicate)
        {
            var context = DbSet.AsQueryable();
            var entities = context.Where(predicate);

            DbSet.RemoveRange(entities);
        }

        public IEnumerable<AppointmentScheduling> Search(Expression<Func<AppointmentScheduling, bool>> predicate)
        {
            var context = DbSet.AsQueryable();
            var entities = context.Where(predicate);
            return entities;
        }

        public IEnumerable<AppointmentScheduling> Search(Expression<Func<AppointmentScheduling, bool>> predicate, int pageNumber, int pageSize)
        {
            var context = DbSet.AsQueryable();
            var entities = context.Where(predicate).Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return entities;
        }

        public AppointmentScheduling Update(AppointmentScheduling entity)
        {
            DbSet.Update(entity);
            return entity;
        }
    }
}
