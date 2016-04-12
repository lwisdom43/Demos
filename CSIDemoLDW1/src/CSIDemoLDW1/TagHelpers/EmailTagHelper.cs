using System.Threading.Tasks;
using Microsoft.AspNet.Razor.TagHelpers;

namespace CSIDemoLDW1.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "csiweb.com";
        public string MailTo { get; set; }
        //public override void Process(TagHelperContext context, TagHelperOutput output)
        //{
        //    output.TagName = "a";

        //    var address = MailTo + "@" + EmailDomain;
        //    output.Attributes["href"] = "mailto:" + address;
        //    output.Content.SetContent(address);
        //}

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + EmailDomain;
            output.Attributes["href"] = "mailto:" + target;
            output.Content.SetContent(target);
        }
    }
}
