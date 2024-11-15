using DemoPracticeMediatr.Data;
using DemoPracticeMediatr.Command;
using MediatR;
public class AddProductHandler : IRequestHandler<AddProductCommand>
{
    private readonly MockProducts _mockproducts;

    public AddProductHandler(MockProducts mockProducts)
    {
        _mockproducts = mockProducts;
    }

    public async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        await _mockproducts.AddProduct(request.Product);
        return;
    }

    // public async Task Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    // {

    //     await _mockproducts.GetProductById(request.Id);

    //     return;
    // }
}