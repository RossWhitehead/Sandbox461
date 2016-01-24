using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sandbox461.Data
{
    public class Assessment
    {
        [Key]
        public int AssessmentId { get; set; }

        public int Rating { get; set; }

    }
}