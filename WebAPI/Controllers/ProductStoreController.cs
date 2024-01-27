using Business.Repositories.ProductStoreRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductStoresController : ControllerBase
    {
        private readonly IProductStoreService _productstoreService;

        public ProductStoresController(IProductStoreService productstoreService)
        {
            _productstoreService = productstoreService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult>Add(ProductStore productstore)
        {
            var result = await _productstoreService.Add(productstore);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(ProductStore productstore)
        {
            var result = await _productstoreService.Update(productstore);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(ProductStore productstore)
        {
            var result = await _productstoreService.Delete(productstore);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _productstoreService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productstoreService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
