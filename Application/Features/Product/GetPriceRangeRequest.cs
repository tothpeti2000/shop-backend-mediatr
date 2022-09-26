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
    public class GetPriceRangeRequest : IRequest<GetPriceRangeResponse>
    { }

    public class GetPriceRangeResponse
    { 
        public double Min { get; set; }
        public double Max { get; set; }
    }

    public class GetPriceRangeRequestHandler : IRequestHandler<GetPriceRangeRequest, GetPriceRangeResponse>
    {
        private readonly IProductRepository repository;

        public GetPriceRangeRequestHandler(IProductRepository repository)
        {
            this.repository = repository;
        }

        public async Task<GetPriceRangeResponse> Handle(GetPriceRangeRequest request, CancellationToken cancellationToken)
        {
            var (minPrice, maxPrice) = await repository.GetPriceRangeAsync(cancellationToken);

            return new GetPriceRangeResponse 
            { 
                Min = minPrice,
                Max = maxPrice
            };
        }
    }

}
