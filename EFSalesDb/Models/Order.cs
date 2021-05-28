using System;
using System.Collections.Generic;

#nullable disable

namespace EFSalesDb.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
// virtual to properties means this property is not in the db but in the class
        public virtual Customer Customer { get; set; }
// this is a way to attach a collection of orderlines to the Order
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
