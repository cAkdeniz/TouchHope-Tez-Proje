﻿using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TouchHope.Core.Utilities.Interceptors;
using TouchHope.Core.Utilities.IoC;

namespace TouchHope.Core.Aspects.Autofac.Performance
{
    public class PerformanceAspect: MethodInterception
    {
        private int _interval;
        private Stopwatch stopwatch;
        public PerformanceAspect(int interval)
        {
            _interval = interval;
            stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }
        protected override void OnBefore(IInvocation invocation)
        {
            stopwatch.Start();
        }
        protected override void OnAfter(IInvocation invocation)
        {
            if (stopwatch.Elapsed.TotalSeconds > _interval)
            {
                Debug.WriteLine("Performance --> " + invocation.Method.DeclaringType.FullName + "." + invocation.Method.Name+" ===> "+stopwatch.Elapsed.TotalSeconds);
            }
            stopwatch.Stop();
        }
    }
}
