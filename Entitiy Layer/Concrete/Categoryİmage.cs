using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy_Layer.Concrete
{
	public class Categoryİmage
	{
        [Key]
        public int CİmageID { get; set; }
        [StringLength(250)]
        public string CİmageURL { get; set; }

    }
}
