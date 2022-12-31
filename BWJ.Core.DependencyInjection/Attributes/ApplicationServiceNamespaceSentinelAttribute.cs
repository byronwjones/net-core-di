using System;

namespace BWJ.Core.DependencyInjection.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ApplicationServiceNamespaceSentinelAttribute : ApplicationServiceAttribute
    {
        public ApplicationServiceNamespaceSentinelAttribute(ApplicationServiceLifetime serviceType) :
            base(serviceType, true)
        { }
    }
}
