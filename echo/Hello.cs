using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Sample
{
	public class HelloCommand : IRequest<string>
	{
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class HelloHandler : IRequestHandler<HelloCommand, string>
    {
        public Task<string> Handle(HelloCommand request, CancellationToken cancellationToken)
        {
            string responseMessage =
                $"Hello {request.Name}. I find it hard to believe you are {request.Age} years old!";
            return Task.FromResult(responseMessage);
        }
    }


}

