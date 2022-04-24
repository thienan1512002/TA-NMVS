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
            _context.GeneralizedCodes.Add(code);
            return await _context.SaveChangesAsync() > 0;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<GeneralizedCode>> GetAll()
        {
            return await _context.GeneralizedCodes.ToListAsync();
        }

        public bool Update(GeneralizedCode code)
        {
            throw new System.NotImplementedException();
        }
    }
}