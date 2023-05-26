using BioCrone.Data;
using BioCrone.Models;
using BioCrone.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace BioCrone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperimentsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IExperimentServices _services;

        public ExperimentsController(DataContext context, IExperimentServices services)
        {
            _context = context;
            _services = services;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Experiment>> GetAllExperiments()
        {
            return _services.GetAllExperiments();
        }

        [HttpPost]
        public async Task<IActionResult> AddExperiment(Experiment experiment)
        {
           return await _services.AddExperiment(experiment);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExperiment(int id)
        {
            return await _services.GetExperiment(id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExperiment(int id)
        {
            return await _services.DeleteExperiment(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateExperiment(int id, Experiment updatedExperiment)
        {
            return await _services.UpdateExperiment(id, updatedExperiment);
        }
    }
}
