using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
    public class ProfileActionAttribute : FilterAttribute, IActionFilter
    {

        private Stopwatch timer;

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            timer.Stop();
            if (filterContext.Exception == null)
            {
                filterContext.HttpContext.Response.Write($"<div>Action method elapsed time: {timer.Elapsed.TotalSeconds:F6}</div>");
            }
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {            
            timer = Stopwatch.StartNew();

            //throw new NotImplementedException();
        }
    }
}