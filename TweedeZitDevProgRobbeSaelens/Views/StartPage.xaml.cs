using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweedeZitDevProgRobbeSaelens.Models;
using TweedeZitDevProgRobbeSaelens.Repositories;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TweedeZitDevProgRobbeSaelens.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        private List<ImageShort> image;
        public StartPage()
        {
            InitializeComponent();
            this.RandomDog();
        }

        private async void RandomDog()
        {
            image = await DogRepository.GetImagesAsync();
            DogImg.Source = image[0].Url;

        }
    }
}