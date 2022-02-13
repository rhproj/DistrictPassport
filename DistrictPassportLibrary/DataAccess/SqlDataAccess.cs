using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistrictPassportLibrary.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }


        #region Querries
        public async Task<List<T>> QLoadData<T, U>(string querry, U parameters, string conStrName)
        {
            string conStr = _config.GetConnectionString(conStrName);

            using (IDbConnection connection = new SqlConnection(conStr))
            {
                var rows = await connection.QueryAsync<T>(querry, parameters, commandType: CommandType.Text);
                return rows.ToList();
            }
        }

        public async Task QSaveData<T>(string querry, T parameters, string conStrName)
        {
            string connSrt = _config.GetConnectionString(conStrName);

            using (IDbConnection connection = new SqlConnection(connSrt))
            {
                await connection.ExecuteAsync(querry, parameters, commandType: CommandType.Text);
            }
        } 
        #endregion

        #region Stored Procedures
        public async Task<List<T>> SpLoadData<T, U>(string storedProcedure, U parameters, string conStrName)
        {
            string connSrt = _config.GetConnectionString(conStrName);

            using (IDbConnection connection = new SqlConnection(connSrt))
            {
                var rows = await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                return rows.ToList();
            }
        }

        public async Task SpSaveData<T>(string storedProcedure, T parameters, string conStrName)
        {
            string connSrt = _config.GetConnectionString(conStrName);

            using (IDbConnection connection = new SqlConnection(connSrt))
            {
                await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion
    }
}
