using Ant.Infra.Data.Context;
using Equinox.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AntContext _context;

        public UnitOfWork(AntContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
