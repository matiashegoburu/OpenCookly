using System;
using Castle.DynamicProxy;

namespace OpenCookly.Common.Interception
{
    public abstract class BaseSetterInterceptor<T, TInterceptorAttribute, TInterceptor>
        : BaseInterceptor<TInterceptorAttribute, TInterceptor>
        where TInterceptorAttribute : BaseSetterAspect<T, TInterceptor, TInterceptorAttribute>
        where TInterceptor : BaseSetterInterceptor<T, TInterceptorAttribute, TInterceptor>
    {
        public BaseSetterInterceptor()
        {
        }

        #region implemented abstract members of OpenCookly.Common.Interception.BaseInterceptor
        public override void Run(IInvocation invocation)
        {
            if (!invocation.Method.Name.StartsWith("set_"))
            {
                invocation.Proceed();
                return;
            }

            OnBeforeSet(invocation);
            invocation.Proceed();
            OnAfterSet(invocation);
        }

        public abstract void OnBeforeSet(IInvocation invocation);

        public abstract void OnAfterSet(IInvocation invocation);
        #endregion

    }
}

