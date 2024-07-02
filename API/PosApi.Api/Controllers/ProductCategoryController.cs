using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PosApi.Data;
using PosApi.Data.Models;

namespace PosApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        readonly PosContex _contex;
        public ProductCategoryController(PosContex posContex)
        {
            _contex = posContex;
        }

        [HttpGet]
        public async Task<List<ProductCategory>> GetAll() {
            return await _contex.ProductCategory.Include(x => x.ProducSubtCategories).ToListAsync();
        }

        [HttpPost]
        public async Task<ProductCategory> Post(ProductCategory category) {
            await _contex.ProductCategory.AddAsync(category);
            await _contex.SaveChangesAsync();
            return category;
        }

        [HttpPut("{id}")]
        public async Task<ProductCategory> Put(int id, ProductCategory category) {
            ProductCategory? categoryDB = await _contex.ProductCategory.FirstOrDefaultAsync(x => x.CategoryId == id);
            categoryDB.Name = category.Name;
            categoryDB.Description = category.Description;
            categoryDB.Inactive = category.Inactive;
            await _contex.SaveChangesAsync();
            return category;
        }
    }
}
