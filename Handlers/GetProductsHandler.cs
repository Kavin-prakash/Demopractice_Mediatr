

using DemoPracticeMediatr.Data;
using MediatR;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
{
    private readonly MockProducts _mockProducts;
    public GetProductsHandler(MockProducts mockProducts)
    {
        _mockProducts = mockProducts;
    }
    public async Task<IEnumerable<Product>> Handle(GetProductsQuery request,
        CancellationToken cancellationToken)
    {

        return await _mockProducts.GetAllProducts();
    }
    

}