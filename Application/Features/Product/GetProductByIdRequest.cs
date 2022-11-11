using Application.Features.Auth;
using Application.Mapping;
using Application.Mapping.Profiles;
using DAL.Exceptions;
using Domain.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product
{
    public class GetProductByIdValidator : AbstractValidator<GetProductByIdRequest>
    {
        public GetProductByIdValidator()
        {
            RuleFor(request => request.Id).NotEmpty().NotNull();
        }
    }

    public class GetProductByIdRequest : IRequest<GetProductByIdResponse>
    {
        public Guid Id { get; set; }
    }

    public class GetProductByIdResponse
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public double AverageRating { get; set; }
        public string? ImgUrl { get; set; }
    }

    public class GetProductByIdRequestHandler : IRequestHandler<GetProductByIdRequest, GetProductByIdResponse>
    {
        private readonly IProductRepository repository;
        private readonly Mapper<ProductProfile> mapper = new();

        public GetProductByIdRequestHandler(IProductRepository repository)
        {
            this.repository = repository;
        }

        public async Task<GetProductByIdResponse> Handle(GetProductByIdRequest request, CancellationToken cancellationToken)
        {
            var product = await repository.GetByIdAsync(request.Id, cancellationToken);

            if (product == null)
            {
                throw new EntityNotFoundException();
            }

            return mapper.Map<Domain.Models.Product, GetProductByIdResponse>(product);
        }
    }

}
