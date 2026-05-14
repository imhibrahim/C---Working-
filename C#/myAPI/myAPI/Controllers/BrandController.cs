using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myAPI.Migrations;
using myAPI.model;

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly ApplicationDbContext brandDb;

        public BrandController(ApplicationDbContext brandDb)
        {
            this.brandDb = brandDb;
        }

        [HttpPost]
        public async Task<ActionResult<Brand>> CreateBrand(Brand brand)
        {
            await brandDb.Brand.AddAsync(brand);
            await brandDb.SaveChangesAsync();

            return Ok(brand);
        }


        [HttpGet]
        public async Task<ActionResult<List<Brand>>> fatch()
        {
           var data= await brandDb.Brand.ToListAsync();
            return Ok(data);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<List<Brand>>> fatchbyId(int id)
        {
            var data = await brandDb.Brand.FindAsync(id);
            if (data==null)
            {
                return NotFound();
            }
            return Ok(data);
        }



        [HttpPut("{id}")]
        public async Task<ActionResult<Brand>> Update(int id, Brand brand)
        {
            if (id != brand.Id)
            {
                return BadRequest();
            }

            brandDb.Entry(brand).State = EntityState.Modified;
            await brandDb.SaveChangesAsync();
            return Ok(brand);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Brand>> delete(int id)
        {
            var brandId = await brandDb.Brand.FindAsync(id);
            if (brandId ==null)
            {
                return NotFound();
            }

            brandDb.Brand.Remove(brandId);
            await brandDb.SaveChangesAsync();
            return Ok("Data id deleted");
        }

    }
}