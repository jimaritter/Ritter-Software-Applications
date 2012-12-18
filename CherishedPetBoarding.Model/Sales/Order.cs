using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Products;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Users;

namespace CherishedPetBoarding.Model.Sales
{
    public class Order : Business<Order>, IOrder
    {
        private readonly IOrder _order;
        private DateTime _createdDate = DateTime.Now;
        public virtual int Id { get; set; }
        public Invoice Invoice { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public Order()
        {

        }

        public Order(IOrder order)
        {
            _order = order;
        }
    }
}
