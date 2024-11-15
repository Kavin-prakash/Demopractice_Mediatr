using MediatR;

public class GetProductsQuery : IRequest<IEnumerable<Product>>
{

};