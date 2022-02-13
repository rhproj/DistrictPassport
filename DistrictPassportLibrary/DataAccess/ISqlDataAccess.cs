using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistrictPassportLibrary.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> QLoadData<T, U>(string querry, U parameters, string conStrName);
        Task QSaveData<T>(string querry, T parameters, string conStrName);
        Task<List<T>> SpLoadData<T, U>(string storedProcedure, U parameters, string conStrName);
        Task SpSaveData<T>(string storedProcedure, T parameters, string conStrName);
    }
}
