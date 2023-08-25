using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}
