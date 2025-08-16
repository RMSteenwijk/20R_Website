using Piranha.Extend;
using Piranha.Extend.Fields;

public class FooterBlock
{
    [Field(Title = "Column 1 logo")]
    public ImageField Logo { get; set; }

    [Field(Title = "Column 2 text")]
    public HtmlField Column2Text { get; set; }

    [Field(Title = "Column 3 text")]
    public HtmlField Column3Text { get; set; }
}