using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConsulting.Model.Services
{
    public class Service : IService
    {
        private readonly IService _service;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual bool Active { get; set; }

        public Service()
        {
            
        }

        public Service(IService service)
        {
            _service = service;
        }

        public IQueryable<Service> Services()
        {
            throw new NotImplementedException();
        }
    }
}
