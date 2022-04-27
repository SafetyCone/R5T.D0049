using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0049
{
    [ServiceDefinitionMarker]
    public interface IExceptionSink : IServiceDefinition
    {
        Task Consume(Exception exception);
    }
}
