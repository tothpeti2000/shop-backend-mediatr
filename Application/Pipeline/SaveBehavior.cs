using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Pipeline
{
    public class SaveBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IUnitOfWork uow;

        public SaveBehavior(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var response = await next();

            if (typeof(TRequest).Name.EndsWith("Command"))
            {
                await uow.SaveChangesAsync();
            }

            return response;
        }
    }
}
