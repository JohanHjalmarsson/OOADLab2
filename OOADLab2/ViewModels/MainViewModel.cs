using System;
using OOADLab2.Models;
using OOADLab2.Services;

namespace OOADLab2.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private string labelText;
        private RandomNiceWordGenerator randomNiceWordGenerator;
        public string LabelText
        {
            get => labelText;
            set => SetProperty(ref labelText, value);
        }


        public MainViewModel()
        {
            randomNiceWordGenerator = new RandomNiceWordGenerator();
            LabelText = randomNiceWordGenerator.GetRandomNiceWord();
        }


        public void MvButtonClicked()
        {
            LabelText = randomNiceWordGenerator.GetRandomNiceWord();
        }
    }
}
