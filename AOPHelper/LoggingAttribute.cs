using HelperUtils;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPHelper
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed class LoggingAttribute : OnMethodBoundaryAspect
    {
        public string BusinessName { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
        {
            LogHelper.Writelog(BusinessName + "开始执行");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            LogHelper.Writelog(BusinessName + "结束执行");
        }
    }
}
