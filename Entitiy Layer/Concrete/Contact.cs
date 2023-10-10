using System;
using System.ComponentModel.DataAnnotations;

namespace EntitiyLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserMail { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        public DateTime ContactDate { get; set; }
        public string Message { get; set; }

    }
}
