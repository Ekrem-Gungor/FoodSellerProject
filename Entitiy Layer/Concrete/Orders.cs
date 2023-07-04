using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy_Layer.Concrete
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        [StringLength(50)]
        public string OrderName { get; set; }
        [StringLength(200)]
        public string OrderDetails { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }


		public int CustomerID { get; set; }
		public virtual Customer Customer { get; set; }

		
		public int FoodID { get; set; }
		public virtual Foods Foods { get; set; }

	}
}
