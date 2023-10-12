using CervezasColombia_CS_API_PostgreSQL_Dapper.Models;
using CervezasColombia_CS_API_PostgreSQL_Dapper.Services;
using Microsoft.AspNetCore.Mvc;

namespace tadb_202320_ex03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutobusesController : Controller
    {
        private readonly AutobusService _AutobusService;

        public AutobusesController(AutobusService AutobusService)
        {
            _AutobusService = AutobusService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var losAutobuses = await _AutobusService
                .GetAllAsync();

            return Ok(losAutobuses);
        }

         [HttpGet("{id_autobus:int}")]
        public async Task<IActionResult> GetDetailsByIdAsync(int id_autobus)
        {
            try
            {
                var unAutobusDetallado = await _AutobusService
                    .GetDetailsByIdAsync(id_autobus);

                return Ok(unAutobusDetallado);
            }
            catch (AppValidationException error)
            {
                return NotFound(error.Message);
            }
        }
    }
}