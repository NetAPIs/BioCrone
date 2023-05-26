using BioCrone.Data;
using BioCrone.Models;
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

        public ExperimentsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Experiment>> GetAllExperiments()
        {
            try
            {
                var experiments = _context.Experiments.Find(_ => true).ToList();
                return experiments;
            }
            catch (MongoException ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddExperiment(Experiment experiment)
        {
            await _context.Experiments.InsertOneAsync(experiment);
            return Ok(experiment);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExperiment(int id)
        {
            var experiment = await _context.Experiments.Find(e => e.Id == id).FirstOrDefaultAsync();
            if (experiment == null)
            {
                return NotFound();
            }
            return Ok(experiment);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExperiment(int id)
        {
            var deleteResult = await _context.Experiments.DeleteOneAsync(e => e.Id == id);
            if (deleteResult.DeletedCount == 0)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateExperiment(int id, Experiment updatedExperiment)
        {
            var filter = Builders<Experiment>.Filter.Eq(e => e.Id, id);
            var update = Builders<Experiment>.Update
                .Set(e => e.Name, updatedExperiment.Name)
                .Set(e => e.Description, updatedExperiment.Description)
                .Set(e => e.StartDate, updatedExperiment.StartDate)
                .Set(e => e.EndDate, updatedExperiment.EndDate)
                .Set(e => e.Location, updatedExperiment.Location);

            var experiment = await _context.Experiments.FindOneAndUpdateAsync(filter, update);
            if (experiment == null)
            {
                return NotFound();
            }
            return Ok(updatedExperiment);
        }
    }
}
