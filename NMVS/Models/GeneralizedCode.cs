using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NMVS.Models
{
    
    public partial class GeneralizedCode
    {
        [Required]
        [MaxLength(50)]
        public string CodeFldName { get; set; }
        [Required]
        [MaxLength(50)]
        public string CodeValue { get; set; }
        [Required]
        [MaxLength(200)]
        public string CodeDesc { get; set; }

    }
}
