using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sandbox461.Data
{
    public class MailMessage
    {
        [Key]
        public int MailId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Subject { get; set; }

        [Required]
        public MailAddress From { get; set; }

        [Required]
        public List<MailAddress> To { get; set; }

        [Required]
        public List<MailAddress> CC { get; set; }

        [Required]
        public List<MailAddress> Bcc { get; set; }
    }

    public class MailAddress
    {
        [Key]
        public int MailAddressId { get; set; }

        [Required]
        [StringLength(128)]
        public string Address { get; set; }

        [Required]
        [StringLength(128)]
        public string DisplayName { get; set; }

    }
}