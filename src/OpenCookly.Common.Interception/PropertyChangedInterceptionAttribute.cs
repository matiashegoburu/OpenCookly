using System;

namespace OpenCookly.Common.Interception
{
    public class PropertyChangedAspect<T>
        : BaseSetterAspect<T, PropertyChangedInterceptor<T>, PropertyChangedAspect<T>>
    {
        public PropertyChangedAspect()
        {
        }
    }
}

