using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NMVS.Models;

namespace NMVS.Services
{
    public interface IGeneralizedCode
    {
        Task<IEnumerable<GeneralizedCode>> GetAll();
        Task<GeneralizedCode> GetById(int id);
        Task<Boolean> Add(GeneralizedCode code);

        Task<Boolean> Update(GeneralizedCode code);

        Task<Boolean> Delete(int id);
    }
}