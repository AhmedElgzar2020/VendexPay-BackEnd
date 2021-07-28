using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Vendexpay.Core.Repository;
using Vendexpay.Core.Service;
using Vendexpay.Core.VM;
using Vendexpay.Infrastructure.Repository;
using Vendexpay.Model;

namespace Vendexpay.Service
{
    public class BaseService<T, TVM> : IBaseService<T, TVM> where T : BaseEntity where TVM : BaseVM
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepo<T> _baseRepo;

        public BaseService(IMapper mapper,IBaseRepo<T> baseRepo)
        {
            _mapper = mapper;
            _baseRepo = baseRepo;

        }
        public void Add(TVM entity)
        {
            _baseRepo.Add(_mapper.Map<T>(entity));
            _baseRepo.Complate();
        }

        public void Update(int Id,TVM model)
        {
            var entity=_baseRepo.Get(Id);
            entity = _mapper.Map<T>(model);
            _baseRepo.Complate();
        }

        public void Delete(int Id)
        {
            var entity = _baseRepo.Find(x => x.Id == Id).FirstOrDefault();
            if (entity != null)
                _baseRepo.Remove(_mapper.Map<T>(entity));
        }

        public List<TVM> Find(Expression<Func<T, bool>> predicate)
        {
            return _mapper.Map<List<T>,List<TVM>>(_baseRepo.Find(predicate).ToList());
        }

        public TVM Get(int Id)
        {
            return _mapper.Map<TVM>(_baseRepo.Find(x => x.Id == Id).FirstOrDefault());
        }

        public List<TVM> GetAll()
        {
            return _mapper.Map<IEnumerable  <T>, List<TVM>>(_baseRepo.GetAll());
        }
    }
}
