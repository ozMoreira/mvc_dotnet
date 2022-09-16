using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Fiap.Aula04.Web.TagHelpers
{
    public class MensagemTagHelper :TagHelper
    {
        public String? Msg { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            if (Msg != "") output.Attributes.SetAttribute("class", "alert alert-success");
            output.Content.SetContent(Msg);
        }
    }
}
