using System;
using Castle.DynamicProxy;

namespace OpenCookly.Common.Interception
{
    public class PropertyChangedInterceptor<T> 
        : BaseSetterInterceptor<T, PropertyChangedAspect<T>, PropertyChangedInterceptor<T>>
    {
        public PropertyChangedInterceptor()
        {
        }

        #region implemented abstract members of OpenCookly.Common.Interception.BaseSetterInterceptor
        public override void OnBeforeSet(IInvocation invocation)
        {

        }

        public override void OnAfterSet(IInvocation invocation)
        {
            var propertyName = invocation.Method.Name.Substring(4);
            var method = invocation.TargetType.GetMethod("OnPropertyChanged");
            method.Invoke(invocation.InvocationTarget, new object[]{propertyName});
        }
        #endregion

    }
}

