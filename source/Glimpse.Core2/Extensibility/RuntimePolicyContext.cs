using Glimpse.Core2.Framework;

namespace Glimpse.Core2.Extensibility
{
    public class RuntimePolicyContext : IRuntimePolicyContext
    {
        public IRequestMetadata RequestMetadata { get; set; }

        public IGlimpseLogger Logger { get; set; }

        private object RequestContext { get; set; }

        public RuntimePolicyContext(IRequestMetadata requestMetadata, IGlimpseLogger logger, object requestContext)
        {
            RequestMetadata = requestMetadata;
            Logger = logger;
            RequestContext = requestContext;
        }

        public T GetRequestContext<T>() where T : class
        {
            return RequestContext as T;
        }

    }
}