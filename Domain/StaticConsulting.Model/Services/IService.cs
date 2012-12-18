using System.Linq;

namespace StaticConsulting.Model.Services
{
    public interface IService
    {
        IQueryable<Service> Services();
    }
}