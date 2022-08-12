using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LifeTime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountController : ControllerBase
    {
        private readonly IFirsCounter firsCounter;
        private readonly ISecondCounter secondCounter;

        public CountController(IFirsCounter firsCounter, ISecondCounter secondCounter )
        {
            this.firsCounter = firsCounter;
            this.secondCounter = secondCounter;
        }
        // GET: api/<CountController>
        [HttpGet]
        public int Get()
        {
            firsCounter.IncrementAndGet();
            return secondCounter.IncrementAndGet();
        }
    }
}
