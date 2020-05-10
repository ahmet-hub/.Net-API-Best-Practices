using NorthwindFramework.Web.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindFramework.Web.ApiService.Abstract
{
    public interface IApiService<TEntity>
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<CategoryDto> AddAsync(CategoryDto categoryDto);

    }
}
