using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NMVS.Models
{
    public partial class ItemData
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ItemNo { get; set; }
        [Required]
        [MaxLength(100)]
        public string ItemName { get; set; }
        [MaxLength(20)]
        public string ItemType { get; set; }
        [MaxLength(50)]
        public string ItemUm { get; set; }
        [MaxLength(50)]
        public string ItemPkgQty { get; set; }
        [MaxLength(100)]
        public string ItemPkg { get; set; }
        public float ItemWhUnit { get; set; }

        public Boolean Active { get; set; }
        public Boolean Flammable { get; set; }

    }
}