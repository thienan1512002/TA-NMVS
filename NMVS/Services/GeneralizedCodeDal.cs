using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NMVS.Models;

namespace NMVS.Services
{
    public class GeneralizedCodeDal : IGeneralizedCode
    {
        private readonly ApplicationDbContext _context;
        public GeneralizedCodeDal(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(GeneralizedCode code)
        {
            Boolean result = false;
            var model = await _context.GeneralizedCodes.FirstOrDefaultAsync(x => x.CodeFldName == code.CodeFldName && x.CodeValue == code.CodeValue);
            if (model == null)
            {
                _context.GeneralizedCodes.Add(code);
                result = await _context.SaveChangesAsync() > 0;
            }
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            Boolean result = false;
            var model = await _context.GeneralizedCodes.FirstOrDefaultAsync(x => x.Id == id);
            if (model != null)
            {
                _context.GeneralizedCodes.Remove(model);
                result = await _context.SaveChangesAsync() > 0;
            }
            return result;
        }

        public async Task<IEnumerable<GeneralizedCode>> GetAll()
        {
            return await _context.GeneralizedCodes.ToListAsync();
        }

        public async Task<bool> Update(GeneralizedCode code)
        {
            Boolean result = false;
            var model = await _context.GeneralizedCodes.FirstOrDefaultAsync(x => x.CodeFldName == code.CodeFldName && x.CodeValue == code.CodeValue && x.Id != code.Id);
            if (model == null)
            {
                _context.GeneralizedCodes.Update(code);
                result = await _context.SaveChangesAsync() > 0;
            }
            return result;
        }

        public async Task<GeneralizedCode> GetById(int id)
        {
            return await _context.GeneralizedCodes.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}