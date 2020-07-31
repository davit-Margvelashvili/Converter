using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Converter.Core.Models;

namespace Converter.Core.Abstractions
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();

        Task<Category> AddAsync(Category category);
    }
}