using NorthwindFramework.Core.Repositories;
using NorthwindFramework.Core.Service;
using NorthwindFramework.Core.UnitOfWork;
using NorthwindFramework.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NorthwindFramework.Service.Services
{
    public class Service<TEntity> : IEntityService<TEntity>
        where TEntity : class, IEntity, new()
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IEntityRepository<TEntity> _entityRepository;
        public Service(IUnitOfWork unitOfWork, IEntityRepository<TEntity> entityRepository)
        {
            _unitOfWork = unitOfWork;
            _entityRepository = entityRepository;


        }

        public async  Task<TEntity> AddAsync(TEntity entity)
        {
            await _entityRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _entityRepository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
           return await _entityRepository.GetAllAsync();
            
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _entityRepository.GetByIdAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _entityRepository.Remove(entity);
            _unitOfWork.Commit();

        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _entityRepository.RemoveRange(entities);
            _unitOfWork.CommitAsync();
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entityRepository.SingleOrDefaultAsync(predicate);

        }

        public TEntity Update(TEntity entity)
        {
            _entityRepository.Update(entity);
            _unitOfWork.Commit();
            return entity;
        }

        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return  _entityRepository.Where(predicate);

        }
    }
}
