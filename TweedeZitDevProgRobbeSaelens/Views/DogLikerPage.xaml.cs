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
    public partial class DogLikerPage : ContentPage
    {
        private List<ImageShort> image;

        public DogLikerPage()
        {
            InitializeComponent();
            this.Refresh();
        }

        private void Button_Favourite_Clicked_1(object sender, EventArgs e)
        {
            this.Favourite();
        }

        private void Favourite()
        {
            DogRepository.PostFavourite(this.image[0].Id);
            DisplayAlert("", "Dog added to your favourites", "OK");
        }

        private async void Refresh()
        {
            image = await DogRepository.GetImagesAsync();
            ImgRandom.Source = image[0].Url;

        }
        private void Button_RandomClicked(object sender, EventArgs e)
        {
            this.Refresh();

        }
    }
}