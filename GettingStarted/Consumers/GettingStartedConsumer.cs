using System.Threading.Tasks;
using Contracts;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace GettingStarted.Consumers
{
    public class GettingStartedConsumer :
        IConsumer<HelloMessage>
    {
        ILogger<GettingStartedConsumer> _logger;

        public GettingStartedConsumer(ILogger<GettingStartedConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<HelloMessage> context)
        {
            _logger.LogInformation($"Received Hello Message: {context.Message.Name}");
            return Task.CompletedTask;
        }
    }
}