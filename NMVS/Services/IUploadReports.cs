using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NMVS.Models;
namespace NMVS.Services
{
    public interface IUploadReports
    {
        Task<IEnumerable<UploadReport>> GetAllReports();

        Task<UploadReport> GetReportById(int id);

        Task<Boolean> AddReport(UploadReport report);

        Task<Boolean> AddError(UploadError error);

    }
}