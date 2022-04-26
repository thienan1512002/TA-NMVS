using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NMVS.Models
{
    public partial class UploadError
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("UploadReport")]
        public int UploadId { get; set; }

        public string Error { get; set; }

        public UploadReport UploadReport { get; set; }
    }
}