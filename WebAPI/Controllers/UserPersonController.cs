using Business.Repositories.UserPersonRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPersonsController : ControllerBase
    {
        private readonly IUserPersonService _userpersonService;

        public UserPersonsController(IUserPersonService userpersonService)
        {
            _userpersonService = userpersonService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult>Add(UserPerson userperson)
        {
            var result = await _userpersonService.Add(userperson);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UserPerson userperson)
        {
            var result = await _userpersonService.Update(userperson);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(UserPerson userperson)
        {
            var result = await _userpersonService.Delete(userperson);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _userpersonService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _userpersonService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
