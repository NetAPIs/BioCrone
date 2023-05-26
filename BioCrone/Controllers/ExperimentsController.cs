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
    }
}
