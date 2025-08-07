using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Piranha.Models;

namespace _20R_HomePage.HtmlHelpers
{
    public static class NavigationHelperExtensions
    {
        public static bool ThisOrChildIsActive(this IHtmlHelper htmlHelper, SitemapItem current, StructureItem<Sitemap, SitemapItem> childItems)
        {


            return true;
        }
    }
}
