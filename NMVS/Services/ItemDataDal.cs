using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NMVS.Models;

namespace NMVS.Services
{
    public class ItemDataDal : InItemData
    {
        private readonly ApplicationDbContext _context;
        public ItemDataDal(ApplicationDbContext context)
        {
            _context = context;
        }
       
        public async Task<bool> AddItemData(ItemData itemData)
        {
            Boolean result = false;
            var currenItem = await _context.ItemDatas.FirstOrDefaultAsync(item => item.ItemNo.Equals(itemData.ItemNo) && item.ItemName.Equals(itemData.ItemName));
            if (currenItem == null)
            {
                _context.ItemDatas.Add(itemData);
                result = await _context.SaveChangesAsync() > 0;
            }
            return result;
        }

        public async Task<IEnumerable<ItemData>> GetAllItemData()
        {
            return await _context.ItemDatas.ToListAsync();
        }

        public async Task<ItemData> GetItemDataById(int id)
        {
            return await _context.ItemDatas.FirstOrDefaultAsync(item => item.Id == id);
        }

        public async void ToggleActive(int id)
        {
            var model = await _context.ItemDatas.FirstOrDefaultAsync(item => item.Id == id);
            model.Active = !model.Active;
            _context.ItemDatas.Update(model);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateItemData(ItemData itemData)
        {
            Boolean result = false;
            var currentItem = await _context.ItemDatas.FirstOrDefaultAsync(item => item.ItemNo.Equals(itemData.ItemNo) && item.ItemName.Equals(itemData.ItemName) && item.Id != itemData.Id);
            if (currentItem == null)
            {
                _context.ItemDatas.Update(itemData);
                result = await _context.SaveChangesAsync() > 0;
            }
            return result;
        }
    }
}