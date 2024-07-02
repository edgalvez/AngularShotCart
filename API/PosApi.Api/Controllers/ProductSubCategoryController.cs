using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PosApi.Data;
using PosApi.Data.Models;
using PosApi.Shared.Models;

namespace PosApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSubCategoryController : ControllerBase
    {
        public PosContex _contex;
        public ProductSubCategoryController(PosContex contex)
        {
            _contex = contex;
        }

        [HttpGet]
        public async Task<List<ProductSubCategory>> GetAll() { 
            return await _contex.ProductSubCategory.ToListAsync();
        }

        [HttpPost] 
        public async Task<ProductSubCategory> Post(ProductSubCategory subCategory) {
            await _contex.ProductSubCategory.AddAsync(subCategory);
            await _contex.SaveChangesAsync();
            return subCategory;
        }

    }
}
