using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bookshop.Models
{
    public class CoverType
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Cover Type")]
        public string Name { get; set; }
    }
}
