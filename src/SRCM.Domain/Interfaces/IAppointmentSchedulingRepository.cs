using SRCM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Domain.Interfaces
{
    public interface IAppointmentSchedulingRepository
    {
        AppointmentScheduling GetById(Guid id);
        IEnumerable<AppointmentScheduling> Search(Expression<Func<AppointmentScheduling, bool>> predicate);
        IEnumerable<AppointmentScheduling> Search(Expression<Func<AppointmentScheduling, bool>> predicate, int pageNumber, int pageSize);
        AppointmentScheduling Add(AppointmentScheduling entity);
        AppointmentScheduling Update(AppointmentScheduling entity);
        void Remove(Guid id);
        void Remove(Expression<Func<AppointmentScheduling, bool>> predicate);
    }
}
