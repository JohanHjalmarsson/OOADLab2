using System;
namespace OOADLab2.Models
{
    public class ContentConverter
    {
        private string text;
        public string Text 
        {
            get => GetConvertedText();
            set => text = value; 
        }

        public ContentConverter(string Text)
        {
            this.Text = Text;
        }


        public string GetConvertedText() 
        {
            return text;
        }

    }
}
