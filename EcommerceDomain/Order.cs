using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }

        public Shipment Shipment { get; set; }
        public Payment Payment { get; set; }

    }
}
