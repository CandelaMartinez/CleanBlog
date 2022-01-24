
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace CleanBlog.Core.Extensions
{
     public static class HtmlExtensions
    {

        public static IHtmlString GetGridHtml(this HtmlHelper html, IPublishedContent contentItem, string framework, string propertyAlias, bool fluidImages)
        {
            if (fluidImages)
                //reemplaza todos los images que hay en el grid con image y su clase fluid
            {
                return html.Raw(html.GetGridHtml(contentItem, framework, propertyAlias).ToString().Replace("<img ", "<img class=\"img-fluid\" "));
            }
            else
            {
                return html.GetGridHtml(contentItem, propertyAlias, framework);
            }
        }
    }
}
