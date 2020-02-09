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

        public async Task<int> GetMultipleOfThis(int inputValue)
        {
            return await Task.FromResult(inputValue*10);
        }
    }

    public interface IDbRepository
    {
        Task<string> GetData();
        Task<int> GetMultipleOfThis(int inputValue);
    }
}
