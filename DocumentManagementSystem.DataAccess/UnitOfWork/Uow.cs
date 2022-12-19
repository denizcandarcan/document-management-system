using DocumentManagementSystem.DataAccess.Contexts;
using DocumentManagementSystem.DataAccess.Interfaces;
using DocumentManagementSystem.DataAccess.Repositories;
using DocumentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly DocumentContext _context;

        public Uow(DocumentContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);

        }
        
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
