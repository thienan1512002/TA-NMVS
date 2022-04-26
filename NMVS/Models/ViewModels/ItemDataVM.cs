using System;

namespace NMVS.Models.ViewModels
{
    public class ItemDataVM
    {
        public int Id { get; set; }

        
        public string ItemNo { get; set; }
       
        public string ItemName { get; set; }
        
        public string ItemType { get; set; }
       
        public string ItemUm { get; set; }
       
        public string ItemPkgQty { get; set; }
        
        public string ItemPkg { get; set; }
        public float ItemWhUnit { get; set; }

        public Boolean Active { get; set; }
        public Boolean Flammable { get; set; }
    }
}