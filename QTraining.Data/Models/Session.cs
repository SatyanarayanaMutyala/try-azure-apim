using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace QTraining.Data.Models
{
    public class Session
    {
        [Key]        
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [Range(0.2D, 7.0D)]
        public decimal Credits { get; set; }
        [MaxLength(100)]
        public string Category { get; set; }

    }
}
