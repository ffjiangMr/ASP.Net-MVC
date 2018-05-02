namespace WebApplication.Controllers.Binder
{
    #region using directive

    using System;
    using System.ComponentModel;
    using System.Web.Mvc;

    #endregion

    public class SensitiveWorldFilterModelBinder : DefaultModelBinder
    {
        protected override void SetProperty(ControllerContext controllerContext, ModelBindingContext bindingContext, PropertyDescriptor propertyDescriptor, object value)
        {
            if (propertyDescriptor.PropertyType == typeof(String))
            {
                value = bindingContext.PropertyFilter(value as String);
            }
            base.SetProperty(controllerContext, bindingContext, propertyDescriptor, value);
        }

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var value = base.BindModel(controllerContext, bindingContext);
            if (bindingContext.ModelType == typeof(String))
            {
                value = bindingContext.PropertyFilter(value as String);
            }
            return value;
        }

    }
}