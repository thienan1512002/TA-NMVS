using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NMVS.Models;

namespace NMVS.Services
{
    public interface IGeneralizedCode
    {
        Task<IEnumerable<GeneralizedCode>> GetAll();

        Task<Boolean> Add(GeneralizedCode code);

        Boolean Update(GeneralizedCode code);

        void Delete(int id);
    }
}