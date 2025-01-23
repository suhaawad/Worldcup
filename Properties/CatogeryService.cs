using Microsoft.EntityFrameworkCore;
using worldcup.Data;
using worldcup.Models;

namespace worldcup.Services.AdminServices
{
    public class CategoryService : ICatogeryService
    {
        private readonly ApplicationDbContext _context;

        // Constructor to inject dependencies
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Method to retrieve categories
        public async Task<IEnumerable<Categories>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
