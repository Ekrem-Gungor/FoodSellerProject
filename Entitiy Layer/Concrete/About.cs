using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        [StringLength(1000)]
        public string ADetails1 { get; set; }
        [StringLength(1000)]
        public string ADetails2 { get; set; }
        [StringLength(100)]
        public string AImage1 { get; set; }
        [StringLength(100)]
        public string AImage2 { get; set; }

    }
}
