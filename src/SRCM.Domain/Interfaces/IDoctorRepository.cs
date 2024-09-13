using SRCM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Domain.Interfaces
{
    public interface IDoctorRepository
    {
        Doctor GetById(Guid id);
        IEnumerable<Doctor> Search(Expression<Func<Doctor, bool>> predicate);
        IEnumerable<Doctor> Search(Expression<Func<Doctor, bool>> predicate, int pageNumber, int pageSize);
        Doctor Add(Doctor entity);
        Doctor Update(Doctor entity);
        void Remove(Guid id);
        void Remove(Expression<Func<Doctor, bool>> predicate);
    }
}
