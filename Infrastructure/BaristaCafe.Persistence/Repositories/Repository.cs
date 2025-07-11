﻿
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BaristaCafeContext _context;

        public Repository(BaristaCafeContext context)
        {
            _context = context;
        }

        public async Task CrateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {

            return await _context.Set<T>().ToListAsync();

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);

        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();

        }
    }
}
