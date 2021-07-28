using System;
using System.Collections.Generic;
using System.Text;
using Vendexpay.Core;
using Vendexpay.Core.Repository;
using Vendexpay.Infrastructure.Repository;
using Vendexpay.Model;

namespace Vendexpay.Infrastructure
{
    public class UnitOfWork : IUnitOfWork 
    {
        readonly ApplicationDbContext _context;



        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }






        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
