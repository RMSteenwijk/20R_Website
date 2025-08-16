using Piranha.Extend;
using Piranha.Extend.Fields;

public class HeaderBlock
{
    [Field(Title = "Header text")]
    public HtmlField TopRightText { get; set; }

    [Field(Title = "Ignorethis text")]
    public HtmlField IgnoreThis { get; set; }
}