using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Core
{
    public interface IUnitOfWork
    {
        /*Register Repos*/
        int SaveChanges();
    }
}
