using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

[SiteType(Title = "20R Main Site", Id = "20R-Main-Site")]
public class TwentyRSite : SiteContent<TwentyRSite>
{
    [Region(Title = "Footer", Display = RegionDisplayMode.Setting)]
    public FooterBlock FooterContents { get; set; } = new();

    [Region(Title = "Header", Display = RegionDisplayMode.Setting)]
    public HeaderBlock HeaderContents { get; set; } = new();
}