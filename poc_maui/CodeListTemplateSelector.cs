using System;
using poc_maui.Models;

namespace poc_maui
{
    public class CodeListTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CodeItem1Template { get; set; }
        public DataTemplate CodeItem2Template { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var codeItem = (CodesModel)item;

            if (!string.IsNullOrEmpty(codeItem.CodeText) && codeItem.CodeText.Length > 450) 
            {
                return CodeItem1Template;
            }
            else
            {
                return CodeItem2Template;
            }
        }
    }
}

