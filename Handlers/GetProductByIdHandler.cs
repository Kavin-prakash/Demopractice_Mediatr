using DemoPracticeMediatr.Command;
using DemoPracticeMediatr.Data;
using MediatR;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly MockProducts _mockproducts;
    public GetProductByIdHandler(MockProducts mockProducts) => _mockproducts = mockProducts;
    public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        return await _mockproducts.GetProductById(request.Id);
    }

}