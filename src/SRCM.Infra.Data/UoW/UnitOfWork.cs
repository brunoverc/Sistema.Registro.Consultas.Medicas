using SRCM.Domain.Shared.Transaction;
using SRCM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SRCMDbContext _context;

        public UnitOfWork(SRCMDbContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
