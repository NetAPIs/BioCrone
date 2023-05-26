using BioCrone.Models;
using Microsoft.AspNetCore.Mvc;

namespace BioCrone.Services
{
    public interface IExperimentServices
    {
        ActionResult<IEnumerable<Experiment>> GetAllExperiments();
        Task<IActionResult> AddExperiment(Experiment experiment);
        Task<IActionResult> GetExperiment(int id);
        Task<IActionResult> DeleteExperiment(int id);
        Task<IActionResult> UpdateExperiment(int id, Experiment updatedExperiment);
    }
}
