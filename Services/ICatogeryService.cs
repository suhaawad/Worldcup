using System.Collections.Generic;
using worldcup.Models;

namespace worldcup.Services.AdminServices
{
    public interface ICatogeryService
    {
        Task<IEnumerable<Categories>> GetCategories();
    }
}