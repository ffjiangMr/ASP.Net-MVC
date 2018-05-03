namespace WebApplication.ViewModels
{
    #region using directive

    using System;
    using System.Web;

    #endregion

    public class FileUploadViewModel : BaseViewModel
    {
        public HttpPostedFileBase fileUpload { get; set; }
    }
}