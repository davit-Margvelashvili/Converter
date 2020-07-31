using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Converter.Core.Abstractions;
using Converter.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Converter.Data
{
    public class Repository : ICategoryRepository, IUnitRepository
    {
        private readonly ConverterContext _context;

        public Repository(ConverterContext context)
        {
            _context = context;
        }

        public Task<List<Category>> GetAllAsync() =>
            _context.Categories.ToListAsync();

        public async Task<Category> AddAsync(Category category)
        {
            var result = await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public Task<List<Unit>> GetByCategoryAsync(int categoryId) =>
            _context.Units.Where(u => u.CategoryId == categoryId).ToListAsync();

        public async Task<Unit> AddAsync(Unit unit)
        {
            var result = await _context.Units.AddAsync(unit);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}