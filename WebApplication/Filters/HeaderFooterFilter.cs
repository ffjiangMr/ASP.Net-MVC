namespace WebApplication.Filters
{
    #region using directive

    using System;
    using System.Web.Mvc;
    using WebApplication.ViewModels;

    #endregion

    public class HeaderFooterFilter:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ViewResult v = filterContext.Result as ViewResult;
            if (v != null)
            {
                BaseViewModel bvm = v.Model as BaseViewModel;
                if (bvm != null)
                {
                    bvm.UserName = filterContext.HttpContext.User.Identity.Name;
                    bvm.FooterData = new FooterViewModel();
                    bvm.FooterData.CompanyName = "One by One";
                    bvm.FooterData.Year = DateTime.Now.ToString("s");
                }
            }
        }
    }
}