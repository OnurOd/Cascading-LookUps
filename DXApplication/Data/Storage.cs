using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication.Data
{
    public class Storage
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ProductId { get; set; }
        public decimal SellingPrice { get; set; }
        public string EntryBy { get; set; }
        public DateTime In { get; set; }
        public DateTime Out { get; set; }
    }
}