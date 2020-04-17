using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        Task<Category> FindByIdAsync(int id);
        // EF Core does not require async method to update models
        void Update(Category category);
        void Remove(Category category);
    }
}