using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hanover.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string CompanyName { get; set; }
        public string OrderDate { get; set; }
        public string Stage { get; set; }
        public List<OrderProductVM> Products { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderInstructions { get; set; }
        public string Notes { get; set; }
    }

    public class OrderProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
    }
}

