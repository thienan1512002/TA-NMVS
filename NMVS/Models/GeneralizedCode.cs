using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NMVS.Models
{

    public partial class GeneralizedCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Field Name")]
        public string CodeFldName { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Value")]
        public string CodeValue { get; set; }
        [Required]
        [MaxLength(200)]
        [Display(Name = "Description")]
        public string CodeDesc { get; set; }

    }
}
