using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostsharpExample.Aspects
{
    [Serializable]
    public sealed class TraceAttribute : OnMethodBoundaryAspect
    {
        private readonly string _name;

        [NonSerialized]
        System.Diagnostics.Stopwatch watch;

        public TraceAttribute(string name)
        {
            _name = name;
        }

        public TraceAttribute()
        {
        }

        //Executed at runtime, before the method.
        public override void OnEntry(MethodExecutionArgs args)
        {
            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Console.WriteLine(string.Format("Begin Method {0}", _name ?? args.Method.Name));
        }

        //Executed at runtime, when exception has ocurred
        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine(string.Format("Exception in method {0}:{1} ", _name ?? args.Method.Name, args.Exception.Message));
        }

        //Executed at runtime, after the method if exception has not ocurred.
        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.WriteLine(string.Format("Success Method {0}", _name ?? args.Method.Name));
        }

        //Executed at runtime, after the OnSuccess or OnException ,it's the last execution and always is executed 
        public override void OnExit(MethodExecutionArgs args)
        {
            watch.Stop();
            Console.WriteLine(string.Format("End method {0}. Tiempo {1}", _name ?? args.Method.Name, watch.ElapsedMilliseconds));
        }
    } 
}
