using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerAndActions.Infrastructure
{
    public class CustomRedirectResult : ActionResult
    {
        public String Url { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {
            String fullUrl = UrlHelper.GenerateContentUrl(this.Url,context.HttpContext);
            context.HttpContext.Response.Redirect(fullUrl);
        }
    }
}