namespace ProjCQRS.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using ProjCQRS.Api.Entity;
    using ProjCQRS.Api.Medatr.Command;
    using ProjCQRS.Api.Medatr.Query;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryMediatrController : ControllerBase
    {
        private readonly IMediator mediator;

        public CategoryMediatrController(IMediator mediatr)
        {
            this.mediator = mediatr;
        }

        [HttpGet("getcategories")]
        public async Task<ActionResult<Category>> GetCategories()
        {
            return this.Ok(await this.mediator.Send(new GetAllCategoryQuery()));
        }

        [HttpGet("getcategory/{Id}")]
        public async Task<IActionResult> GetCategory(int Id)
        {
            Category category = new Category();
            List<Product> products = new List<Product>();
            Expression<Func<Category, bool>> filter = s => s.Id == Id;
            var result = await mediator.Send(new GetCategoryQuery { filter = filter });

            var PQuanity = result.Products.Select(a => new { a.Id, a.Title, a.Quantity, a.Description, a.Category }).Where(b => b.Category.Id == result.Id).FirstOrDefault();

            if (result.MinStockquantity < PQuanity.Quantity)
            {
                Product product = new Product
                {
                    Id = PQuanity.Id,
                    Title = PQuanity.Title,
                    Description = PQuanity.Description,
                    Quantity = PQuanity.Quantity
                };
                products.Add(product);
                category.Id = result.Id;
                category.CategoryName = result.CategoryName;
                category.MinStockquantity = result.MinStockquantity;
                category.Products = products;
            }

            result = category;
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost("createcategory")]
        public async Task<IActionResult> CreateCategory([FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Expression<Func<Category, bool>> filter = s => s.CategoryName == category.CategoryName;

            var isExist = await mediator.Send(new GetCategoryQuery { filter = filter });
            if (isExist != null)
            {
                ModelState.AddModelError("", "Category already exist");
                return StatusCode(404, ModelState);
            }
            var result = await mediator.Send(new CreateCategoryCommand { Category = category });
            if (result == null)
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {category.CategoryName}");
                return StatusCode(500, ModelState);
            }
            return Ok(result);
        }

        [HttpPost("updatecategory")]
        public async Task<IActionResult> UpdateCategory([FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Expression<Func<Category, bool>> filter = s => s.Id == category.Id;
            var isExist = await mediator.Send(new GetCategoryQuery { filter = filter });
            if (isExist == null)
            {
                ModelState.AddModelError("", "Category not exist");
                return StatusCode(404, ModelState);
            }
            var result = await mediator.Send(new UpdateCategoryCommand { Category = category });
            if (result == null)
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {category.CategoryName}");
                return StatusCode(500, ModelState);
            }
            return Ok(result);
        }

        [HttpDelete("deletecategory")]
        public async Task<IActionResult> DeleteCategory([FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Expression<Func<Category, bool>> filter = s => s.Id == category.Id;
            var isExist = await mediator.Send(new GetCategoryQuery { filter = filter });
            if (isExist == null)
            {
                ModelState.AddModelError("", "Category not exist");
                return StatusCode(404, ModelState);
            }
            var result = await mediator.Send(new DeleteCategoryCommand { Id = category.Id});
            if (!result)
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record");
                return StatusCode(500, ModelState);
            }
            return Ok(result);
        }
    }
}
