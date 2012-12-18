using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Users;

namespace CherishedPetBoarding.Model.Phones
{
    public class Phone :  Business<Phone>, IPhone
    {
        public virtual int Id { get; set; }
        public virtual string Number { get; set; }
        public virtual int Type { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
    }
}
