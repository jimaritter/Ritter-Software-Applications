using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Products;
using CherishedPetBoarding.Model.Repository;

namespace CherishedPetBoarding.Model.Sales
{
    public class LineItem : Business<LineItem>, ILineItem
    {
        private readonly ILineItem _lineItem;
        public virtual int Id { get; set; }
        public virtual int LineNumber { get; set; }
        public virtual string Description { get; set; }
        public virtual Product Product { get; set; }
        public virtual int Quantity { get; set; }
        public virtual Double UnitPrice { get; set; }
        public virtual Double Tax { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; }

        public LineItem()
        {
            
        }

        public LineItem(ILineItem lineItem)
        {
            _lineItem = lineItem;
        }
    }
}
