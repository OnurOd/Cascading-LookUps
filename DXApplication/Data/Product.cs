using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication.Data
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Name { get; set; }
        public int StoreQuantity { get; set; }
        public decimal BasePrice { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
