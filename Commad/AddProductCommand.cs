namespace DemoPracticeMediatr.Command;
using MediatR;

public record AddProductCommand(Product Product) : IRequest;

public record GetProductByIdQuery(int Id) : IRequest<Product>;