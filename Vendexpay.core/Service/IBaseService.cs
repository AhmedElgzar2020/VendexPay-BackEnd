using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Vendexpay.Core.VM;
using Vendexpay.Model;

namespace Vendexpay.Core.Service
{
    public interface IBaseService<T,TVM> where T :BaseEntity where TVM : BaseVM
    {
        TVM Get(int Id);
        List<TVM> GetAll();
        List<TVM> Find(Expression<Func<T, bool>> predicate);
        void Add(TVM entity);
        void Update(int Id, TVM model);
        void Delete(int Id);

    }
}
