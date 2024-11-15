using System.Collections;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using DemoPracticeMediatr.Command;
namespace DemoPracticeMediatr.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<ActionResult> GetProducts()
    {
        var products = await _mediator.Send(new GetProductsQuery());
        return Ok(products);
    }

    [HttpPost]
    public async Task<ActionResult> PostProducts(Product product)
    {
        await _mediator.Send(new AddProductCommand(product));
        return StatusCode(201);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> DetailsByProductId(int id)
    {

        var productId = await _mediator.Send(new GetProductByIdQuery(id));

        return Ok(productId);
    }

}
