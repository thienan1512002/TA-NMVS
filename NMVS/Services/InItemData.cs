using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NMVS.Models;
namespace NMVS.Services
{
    public interface InItemData
    {
        Task<IEnumerable<ItemData>> GetAllItemData();
        Task<ItemData> GetItemDataById(int id);
        Task<Boolean> AddItemData(ItemData itemData);
        Task<Boolean> UpdateItemData(ItemData itemData);

        void ToggleActive(int id);
    }
}