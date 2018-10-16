using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
    public class ProfileResultAttribute : FilterAttribute, IResultFilter
    {

        private Stopwatch timer;

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write($"<div>Result elapsed time : {timer.Elapsed.TotalSeconds:F6}</div>");
            /// home / actionfilter
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //throw new NotImplementedException();
            timer = Stopwatch.StartNew();
        }
    }
}