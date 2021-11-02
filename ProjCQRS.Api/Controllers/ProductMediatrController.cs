using ProjCQRS.Api.Entity;
using ProjCQRS.Api.Medatr.Command;
using ProjCQRS.Api.Medatr.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjCQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductMediatrController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductMediatrController(IMediator mediatr)
        {
            this.mediator = mediatr;
        }
        [HttpGet("getproducts")]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await mediator.Send(new GetAllProductQuery()));
        }


        [HttpGet("getproduct/{Id}")]
        public async Task<IActionResult> GetProduct(int Id)
        {
            Expression<Func<Product, bool>> filter = s => s.Id == Id;
            return Ok(await mediator.Send(new GetProductQuery { filter = filter }));
        }

        [HttpGet("getproductswithrange/{start}/{finish}")]
        public async Task<IActionResult> GetProductsWithRange(int start, int finish)
        {
            Expression<Func<Product, bool>> filter = a => a.Quantity >= start && a.Quantity <= finish;
            return Ok(await mediator.Send(new GetAllProductQuery { filter = filter }));
        }

        [HttpPost("createproduct")]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }
            Expression<Func<Product, bool>> filter = s => s.Id == product.Id;
            var isExist = await mediator.Send(new GetProductQuery { filter=filter});
            if (isExist != null)
            {
                this.ModelState.AddModelError(string.Empty, "Product already exist");
                return this.StatusCode(404, this.ModelState);
            }
            var result = await mediator.Send(new CreateProductCommand { Product = product });
            if (result==null)
            {
                this.ModelState.AddModelError(string.Empty, $"Something went wrong when saving the record {product.Title}");
                return this.StatusCode(500, this.ModelState);
            }

            return this.Ok(result);
        }

        [HttpPost("updateproduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }
            Expression<Func<Product, bool>> filter = s => s.Id == product.Id;
            var isExist = await mediator.Send(new GetProductQuery { filter=filter});
            if (isExist != null)
            {
                this.ModelState.AddModelError(string.Empty, "Product already exist");
                return this.StatusCode(404, this.ModelState);
            }
            var result = await mediator.Send(new UpdateProductCommand { Product = product });
            if (result == null)
            {
                this.ModelState.AddModelError(string.Empty, $"Something went wrong when saving the record {product.Title}");
                return this.StatusCode(500, this.ModelState);
            }

            return this.Ok(result);
        }
        [HttpDelete("deleteproduct")]
        public async Task<IActionResult> DeleteProduct(Product product)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }
            Expression<Func<Product, bool>> filter = s => s.Id == product.Id;

            var isExist = await mediator.Send(new GetProductQuery {filter=filter }) ;
            if (isExist!=null)
            {
                this.ModelState.AddModelError(string.Empty, "Product not exist");
                return this.StatusCode(404, this.ModelState);
            }
            var result = await mediator.Send(new DeleteProductCommand { Id = product.Id });
            if (!result)
            {
                this.ModelState.AddModelError(string.Empty, $"Something went wrong when saving the record {product.Title}");
                return this.StatusCode(500, this.ModelState);
            }

            return this.Ok(result);
        }
    }
}
