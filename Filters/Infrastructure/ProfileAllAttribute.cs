using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace Filters.Infrastructure
{
    public class ProfileAllAttribute:ActionFilterAttribute
    {
        private Stopwatch timer;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write($"<div>Total elapsed tiem : {timer.Elapsed.TotalMilliseconds:F6}</div>");
        }
    }
}