using SRCM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Domain.Interfaces
{
    public interface IAppointmentRepository
    {
        Appointment GetById(Guid id);
        IEnumerable<Appointment> Search(Expression<Func<Appointment, bool>> predicate);
        IEnumerable<Appointment> Search(Expression<Func<Appointment, bool>> predicate, int pageNumber, int pageSize);
        Appointment Add(Appointment entity);
        Appointment Update(Appointment entity);
        void Remove(Guid id);
        void Remove(Expression<Func<Appointment, bool>> predicate);
    }
}
