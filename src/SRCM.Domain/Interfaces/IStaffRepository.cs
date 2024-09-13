using SRCM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Domain.Interfaces
{
    public interface IStaffRepository
    {
        Staff GetById(Guid id);
        IEnumerable<Staff> Search(Expression<Func<Staff, bool>> predicate);
        IEnumerable<Staff> Search(Expression<Func<Staff, bool>> predicate, int pageNumber, int pageSize);
        Staff Add(Staff entity);
        Staff Update(Staff entity);
        void Remove(Guid id);
        void Remove(Expression<Func<Staff, bool>> predicate);
    }
}
