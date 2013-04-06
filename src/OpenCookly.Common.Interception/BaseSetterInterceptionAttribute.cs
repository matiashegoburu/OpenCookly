using System;

namespace OpenCookly.Common.Interception
{
    public class BaseSetterAspect<T, TInterceptor, TAspect> 
        : BaseAspect<TInterceptor, TAspect>
        where TInterceptor : BaseSetterInterceptor<T, TAspect, TInterceptor>
        where TAspect : BaseSetterAspect<T, TInterceptor, TAspect>
    {
        public BaseSetterAspect()
        {
        }
    }
}

