using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NMVS.Models;

namespace NMVS.Services
{
    public class UploadReportDal : IUploadReports
    {
        private readonly ApplicationDbContext _context;
        public UploadReportDal(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddError(UploadError error)
        {
            _context.UploadErrors.Add(error);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> AddReport(UploadReport report)
        {
            _context.UploadReports.Add(report);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<UploadReport>> GetAllReports()
        {
            return await _context.UploadReports.ToListAsync();
        }

        public async Task<UploadReport> GetReportById(int id)
        {
            return await _context.UploadReports.Include(x => x.UploadErrors).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}