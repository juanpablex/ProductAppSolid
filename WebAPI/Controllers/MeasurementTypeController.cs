using Business.Repositories.MeasurementTypeRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementTypesController : ControllerBase
    {
        private readonly IMeasurementTypeService _measurementtypeService;

        public MeasurementTypesController(IMeasurementTypeService measurementtypeService)
        {
            _measurementtypeService = measurementtypeService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult>Add(MeasurementType measurementtype)
        {
            var result = await _measurementtypeService.Add(measurementtype);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(MeasurementType measurementtype)
        {
            var result = await _measurementtypeService.Update(measurementtype);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(MeasurementType measurementtype)
        {
            var result = await _measurementtypeService.Delete(measurementtype);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _measurementtypeService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _measurementtypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
