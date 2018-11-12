﻿using MvcModels.Models;

using System;
using System.Web.Mvc;

namespace MvcModels.Infrastructure
{
    public class AddressSummaryBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            AddressSummary model = (AddressSummary)bindingContext.Model ?? new AddressSummary();
            model.City = GetValue(bindingContext, "Country");
            return model;
        }

        private String GetValue(ModelBindingContext context, String name)
        {
            name = (context.ModelName == "" ? "" : context.ModelName + ".") + name;
            ValueProviderResult result = context.ValueProvider.GetValue(name);
            if (result == null || result.AttemptedValue == "")
            {
                return "<Not specified>";
            }
            else
            {
                return (String)result.AttemptedValue;
            }
        }
    }
}