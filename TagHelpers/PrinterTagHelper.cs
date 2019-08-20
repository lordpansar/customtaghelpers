using Microsoft.AspNetCore.Razor.TagHelpers; //Add this namespace

namespace TagHelperDemo.TagHelpers
{
    public class PrinterTagHelper : TagHelper //Class must inherit from TagHelper
    {
        //Properties will become HTML attributes of your new tag helper
        public string Text { get; set; }
        public int Number { get; set; }

        //Override the virtual method Process from TagHelper
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //Write your custom logic here
            for (int i = 0; i < Number; i++)
            {
                output.Content.AppendHtml($"{Text}</br>");
            }
        }
    }
}
