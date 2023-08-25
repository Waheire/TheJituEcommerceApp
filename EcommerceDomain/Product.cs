using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public List<Order> Orders{ get; set; }
        public List<Cart> Carts { get; set; }
    }
}
