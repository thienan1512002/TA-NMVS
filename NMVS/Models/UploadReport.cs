using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NMVS.Models
{
    public partial class UploadReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime UploadTime { get; set; }
        [MaxLength(100)]
        public string UploadBy { get; set; }
        public string FileName { get; set; }
        public string UploadFunction { get; set; }
        public int TotalRecord { get; set; }
        public int Inserted { get; set; }
        public int Updated { get; set; }
        public int Errors { get; set; }
        public ICollection<UploadError> UploadErrors { get; set; }
    }
}