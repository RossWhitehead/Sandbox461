using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sandbox461.Data
{
    public class Film
    {
        [Key]
        public int FilmId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public virtual List<FilmMaker> Directors { get; set; }

        public virtual List<FilmMaker> Actors { get; set; }
    }
}