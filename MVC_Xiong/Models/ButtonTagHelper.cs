using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVC_Xiong.Models
{
    public class ButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "btn btn-primary");

            //make it a button element with start and end tags
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;

            //make it a submit button
            output.Attributes.SetAttribute("type", "submit");

            //append bootstrap button classes
            string newClasses = "btn btn-primary";
            string oldClasses = output.Attributes["class"]?.Value?.ToString();
            string classes = (string.IsNullOrEmpty(oldClasses)) ?
                newClasses : $"{oldClasses} {newClasses}";
            output.Attributes.SetAttribute("class", classes);
        }
    }
}
