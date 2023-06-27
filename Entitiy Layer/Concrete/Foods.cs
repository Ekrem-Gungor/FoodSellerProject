using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy_Layer.Concrete
{
    public class Foods
    {
        [Key]
        public int FoodID { get; set; }
        [StringLength(50)]
        public string FoodName { get; set; }
        [StringLength(250)]
        public string FoodImage { get; set; }
        [StringLength(100)]
        public string FInStock { get; set; }
        [StringLength(100)]
        public string FUnitPrice { get; set; }
        public bool FoodStatus { get; set; }


        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
