using System;
using Castle.DynamicProxy;

namespace OpenCookly.Common.Interception
{
    public abstract class BaseInterceptor<TAspect, TInterceptor>
        : IInterceptor
        where TAspect : BaseAspect<TInterceptor, TAspect>
        where TInterceptor : BaseInterceptor<TAspect, TInterceptor>
    {
        public BaseInterceptor()
        {

        }
        #region IInterceptor implementation
        public void Intercept(IInvocation invocation)
        {
            var methodAttributes = invocation.Method.GetCustomAttributes(typeof(TAspect), false);
            var typeAttributes = invocation.TargetType.GetCustomAttributes(typeof(TAspect), false);

            var methodHasAttribute = methodAttributes.Length > 0;
            var typeHasAttribute = typeAttributes.Length > 0;

            if (methodHasAttribute || typeHasAttribute)
            {
                Run(invocation);
            } else
            {
                invocation.Proceed();
            }
        }


        public abstract void Run(IInvocation invocation);
        #endregion

    }
}

