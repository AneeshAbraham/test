using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTesting.Repository
{
    public class DbRepository : IDbRepository
    {
        public async Task<string> GetData()
        {
            return await Task.FromResult("Hello from repository");
        }
    }

    public interface IDbRepository
    {
        Task<string> GetData();
    }
}
