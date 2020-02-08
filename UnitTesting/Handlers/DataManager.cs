using System.Threading.Tasks;
using UnitTesting.Repository;

namespace UnitTesting.Handlers
{
    public class DataManager : IDataManager
    {
        private IDbRepository _dbRepository;
        public DataManager(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;

        }
        public async Task<string> GetFormattedData(string input)
        {
            var dataFromRepo = await _dbRepository.GetData();
            string formatedData = $"{dataFromRepo}:{input}";
            return await Task.FromResult(formatedData);
        }
    }
    public interface IDataManager
    {
        Task<string> GetFormattedData(string input);
    }
}
