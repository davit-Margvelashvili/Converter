using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Converter.Core.Models;

namespace Converter.Core.Abstractions
{
    public interface IUnitRepository
    {
        Task<List<Unit>> GetByCategoryAsync(int categoryId);

        Task<Unit> AddAsync(Unit unit);
    }
}