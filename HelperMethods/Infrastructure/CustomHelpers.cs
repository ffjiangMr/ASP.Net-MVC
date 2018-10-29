using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Infrastructure
{
    public static class CustomHelpers
    {
        public static MvcHtmlString ListArrayItems(this HtmlHelper html, String[] list)
        {
            TagBuilder tag = new TagBuilder("ul");
            foreach (var item in list)
            {
                TagBuilder itemTag = new TagBuilder("li");
                itemTag.SetInnerText(item);
                tag.InnerHtml += itemTag.ToString();
            }
            return new MvcHtmlString(tag.ToString());
        }

        public static MvcHtmlString DisplayMessage(this HtmlHelper html, String msg)        
        {
            String result = String.Format("This is the message:<p>{0}></p>",msg);
            return new MvcHtmlString(result);
        }

    }
}