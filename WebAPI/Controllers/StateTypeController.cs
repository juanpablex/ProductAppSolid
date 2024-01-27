using Business.Repositories.StateTypeRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateTypesController : ControllerBase
    {
        private readonly IStateTypeService _statetypeService;

        public StateTypesController(IStateTypeService statetypeService)
        {
            _statetypeService = statetypeService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult>Add(StateType statetype)
        {
            var result = await _statetypeService.Add(statetype);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(StateType statetype)
        {
            var result = await _statetypeService.Update(statetype);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(StateType statetype)
        {
            var result = await _statetypeService.Delete(statetype);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _statetypeService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _statetypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
