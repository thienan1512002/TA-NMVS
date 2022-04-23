using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NMVS.Models
{
    public partial class UploadError
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UploadId { get; set; }

        public string Error { get; set; }

        public UploadReport UploadReport { get; set; }
    }
}