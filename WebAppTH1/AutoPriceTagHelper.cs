using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTH1
{
    //[HtmlTargetElement("*")]
    //[HtmlTargetElement("auto-price", Attributes = "model")] // works, must have model
    //[HtmlTargetElement("auto-price",Attributes ="make")] // works, must have make
    //[HtmlTargetElement("auto-price", Attributes = "make,model")] // works, must have make and model
    //[HtmlTargetElement("auto-price", Attributes = "[make ^='p']")] // works, make starts with p
    //[HtmlTargetElement("auto-price", Attributes = "[model $='r']")] // works, make starts with p
    [HtmlTargetElement("auto-price", Attributes = "[make ^='p'],[model $= 'r'")] // fails, shows all
    public class AutoPriceTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

        }
    }
}
