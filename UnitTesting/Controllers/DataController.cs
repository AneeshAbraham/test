using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTesting.Handlers;

namespace UnitTesting.Controllers
{
    [ApiController]
    public class DataController : ControllerBase
    {
        private IDataManager _dataManager;
        public DataController(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [Route("getformated")]
        [HttpGet]
        public async Task<string> GetData([FromQuery] string data)
        {
            return await _dataManager.GetFormattedData(data);

        }
    }
}