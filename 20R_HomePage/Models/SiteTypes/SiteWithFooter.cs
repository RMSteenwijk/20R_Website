using Microsoft.AspNetCore.Components.Routing;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

[SiteType(Title = "Site With Footer")]
public class SiteWithFooter : SiteContent<SiteWithFooter>
{
    [Region(Title = "Footer", Display = RegionDisplayMode.Setting)]
    public Footer FooterContents { get; set; }
}

public class Footer
{
    [Field(Title = "Footer logo")]
    public ImageField Logo { get; set; }

    [Field(Title = "Footer text")]
    public HtmlField Column2Text { get; set; }

    [Field(Title = "Footer text")]
    public HtmlField Column3Text { get; set; }
}