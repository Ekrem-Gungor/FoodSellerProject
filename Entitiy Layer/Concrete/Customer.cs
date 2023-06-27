using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy_Layer.Concrete
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        [StringLength(100)]
        public string CustomerImage { get; set; }
        [StringLength(150)]
        public string CustomerPassword { get; set; }
        [StringLength(50)]
        public string ContactNo { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        [StringLength(20)]
        public string City { get; set; }
        public bool CustStatus { get; set; }


    }
}
