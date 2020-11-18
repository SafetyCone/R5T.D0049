using System;
using System.Threading.Tasks;


namespace R5T.D0049
{
    public interface IExceptionSink
    {
        Task Consume(Exception exception);
    }
}
