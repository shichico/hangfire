﻿using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace Hangfire.Common
{
    public interface ITransientDependencyInjector : ICallHandler
    {
         
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
    public class TransientDependencyAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return container.Resolve<ITransientDependencyInjector>();
        }
    }
}