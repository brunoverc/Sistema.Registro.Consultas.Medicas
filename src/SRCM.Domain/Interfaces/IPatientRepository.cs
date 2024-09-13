using SRCM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Domain.Interfaces
{
    public interface IPatientRepository
    {
        Patient GetById(Guid id);
        IEnumerable<Patient> Search(Expression<Func<Patient, bool>> predicate);
        IEnumerable<Patient> Search(Expression<Func<Patient, bool>> predicate, int pageNumber, int pageSize);
        Patient Add(Patient entity);
        Patient Update(Patient entity);
        void Remove(Guid id);
        void Remove(Expression<Func<Patient, bool>> predicate);
    }
}
