using Microsoft.AspNetCore.Mvc;
using CI_CD.Data;
using CI_CD.Service;
using CI_CD.DTOs.Product;


[ApiController]
[Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService service)
        {
            _productService = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddProductDTO product) { 
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            bool confirmation = await _productService.AddProductAsync(product);
            
            if(!confirmation) 
                return BadRequest("No se Pudo insertar el Producto");

            return CreatedAtAction(nameof(Post), product); 

        }

            [HttpGet]
            public async Task<IActionResult> GetAll() {
                
                var products = await _productService.getAllProductsAsync();
                
                if (!products.Any())
                    return NoContent();  
       
           

                var response = new
                {
                    success = true,
                    message = "Productos obtenidos correctamente",
                    total = products.Count(),
                    data = products
                };

                return Ok(response); 


            }


            }

