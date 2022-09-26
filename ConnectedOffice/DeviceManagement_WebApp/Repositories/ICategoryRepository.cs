using DeviceManagement_WebApp.Models;
using System;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetMostRecentCategory();
    }

}
