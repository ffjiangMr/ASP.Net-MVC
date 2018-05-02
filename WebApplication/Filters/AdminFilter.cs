namespace WebApplication.Filters
{

    #region using directive

    using System;
    using System.Web.Mvc;

    #endregion

    public class AdminFilter : ActionFilterAttribute
    {
        public AdminFilter()
        {

        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!Convert.ToBoolean(filterContext.HttpContext.Session["IsAdmin"]))
            {
                filterContext.Result = new ContentResult()
                {
                    Content = "Unauthorized to access specified resource."
                };
            }
        }
    }
}