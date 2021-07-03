using Microsoft.AspNetCore.Mvc;
using TotalOneAPI.Services;

namespace TotalOneAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CuriousFactController : ControllerBase
    {
        private readonly ICuriousFactRepository repository;

        public CuriousFactController(ICuriousFactRepository repository) => this.repository = repository;

        [HttpGet]
        public IActionResult GetCuriousFact(string cityName) => Ok(repository.GetCuriousFactForCity(cityName));
    }
}
