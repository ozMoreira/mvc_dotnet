using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Fiap.Aula04.Web.TagHelpers
{
    //Tag: <botao texto="Cadastrar"></botao>
    //Tag resultado: <button class = "btn btn-primary">Texto</button>
    public class BotaoTagHelper : TagHelper
    {
        public String? Texto { get; set; } = "Cadastrar";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //Definir o nome da tag HTML
            output.TagName = "button";
            //Definir os atributos da tag HTML
            output.Attributes.SetAttribute("class", "btn btn-primary");
            //Definir o conteúdoda tag HTML
            output.Content.SetContent(Texto);
        }
    }
}
