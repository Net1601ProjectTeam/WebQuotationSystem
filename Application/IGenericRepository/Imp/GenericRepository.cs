using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IGenericRepository.Imp
{
    public class GenericRepositoryImp<T> : IGenericRepository<T> where T : class
    {
        public readonly AppDBContext _context;

        private readonly DbSet<T> _entitiySet;

        public GenericRepositoryImp(AppDBContext context)
        {
            _context = context;
            _entitiySet = _context.Set<T>();
        }

        public T Add(T entity)
        {
            _context.AddAsync(entity);
            return entity;
        }

        public void Remove(T entity)
              => _context.Remove(entity);

        public T Update(T entity)
        {
            _context.Update(entity);
            return entity;
        }
    }
}
