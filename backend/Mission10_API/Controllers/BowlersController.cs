using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_API.Data;

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Mission10_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            //var bowlerData = _bowlerRepository.Bowlers.ToArray();
            var bowlerData = _bowlerRepository.Bowlers.ToArray();


            return bowlerData;
        }
    }
}
