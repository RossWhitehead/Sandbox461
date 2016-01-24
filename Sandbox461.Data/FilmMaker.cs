using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sandbox461.Data
{
    public class FilmMaker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilmMakerId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}