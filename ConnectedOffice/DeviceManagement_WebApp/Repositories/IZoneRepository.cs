using DeviceManagement_WebApp.Models;
using System;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repositories
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        Zone GetMostRecentZone();
    }
}